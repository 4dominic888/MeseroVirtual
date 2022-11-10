using Clases;
using Microsoft.VisualBasic.Logging;
using System.ComponentModel;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace MeseroVirtual
{
    public partial class FMenu : Form
    {
        public ListaEnlazadaCategorias ListaCategorias = new ListaEnlazadaCategorias();
        public PilaAlimento AlimentosAlmacenados = new PilaAlimento();
        public bool CambiosRealizados = false;
        public FMenu() => InitializeComponent();

        private void FMenu_Load(object sender, EventArgs e)
        {
            LVComidas.Items.Clear();
            LVComidas.Groups.Clear();
            txtAlimentoImagenPath.Clear();

            DatosAlmacenados();
            ActualizarDatos();
        }

        private void DatosAlmacenados()
        {
            if (File.Exists(@".\datos\BDCategorias.txt")) CargarDatos(@".\datos\BDCategorias.txt", ListaCategorias);
            else File.CreateText(@".\datos\BDCategorias.txt"); //Categorias

            if (File.Exists(@".\datos\BDAlimentos.txt")) CargarDatos(@".\datos\BDAlimentos.txt", AlimentosAlmacenados);
            else File.CreateText(@".\datos\BDAlimentos.txt"); //Alimentos

            if (File.Exists(@".\datos\BDConfig.txt")) CargarDatos(@".\datos\BDConfig.txt", nombreRestaurante.Text);
            else File.CreateText(@".\datos\BDConfig.txt"); //Config
        }
        private void ActualizarDatos()
        {
            #region ListView Agregar
            LVComidas.Clear();
            ListaCategorias.For_Each(item => 
            LVComidas.Groups.Add(new ListViewGroup(item, HorizontalAlignment.Center)));

            AlimentosAlmacenados.For_Each(item =>
                LVComidas.Items.Add(new ListViewItem(item.Nombre, EncontrarGrupo(item.Tipo))));
            #endregion

            #region ComboBox update
            cbAlimentoCategoria.Items.Clear();
            cbAlimentoCategoria.Items.Insert(0, "---Selecciona una categoria---");
            ListaCategorias.For_Each(categoria => cbAlimentoCategoria.Items.Add(categoria));
            cbAlimentoCategoria.SelectedIndex = 0;

            cbFiltro.Items.Clear();
            cbFiltro.Items.Insert(0, "Todos");
            ListaCategorias.For_Each(categoria => cbFiltro.Items.Add(categoria));
            cbFiltro.SelectedIndex = 0;
            #endregion
        }

        #region Botones
        //Alimento CRUD
        private void btnAlimentoImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            abrirImagen.InitialDirectory = @"C:\\";
            abrirImagen.Filter = "JPG y JPEG|*.jpg;*.jpeg|PNG|*.png";
            if (abrirImagen.ShowDialog() == DialogResult.OK) txtAlimentoImagenPath.Text = abrirImagen.FileName;
            else txtAlimentoImagenPath.Text = "";
        }
        private void btnAlimentoBuscar_Click(object sender, EventArgs e)
        {
            if (txtAlimentoBuscarNombre.Text.Trim() != "")
            {
                if (AlimentosAlmacenados.ElementoExistenteNombre(txtAlimentoBuscarNombre.Text))
                {
                    Alimento alimento = AlimentosAlmacenados.BuscarElemento(1, txtAlimentoBuscarNombre.Text);

                    MessageBox.Show("Comida encontrada", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAlimentoAgregar.Enabled = false;
                    btnAlimentoBuscar.Enabled = false;
                    txtAlimentoBuscarNombre.Enabled = false;
                    btnAlimentoEditar.Enabled = true;
                    btnAlimentoEliminar.Enabled = true;

                    txtAlimentoNombre.Text = alimento.Nombre;
                    txtAlimentoImagenPath.Text = alimento.Imagen;
                    cbAlimentoCategoria.SelectedIndex = cbAlimentoCategoria.FindStringExact(alimento.Tipo);
                    txtAlimentoPrecio.Text = alimento.Precio.ToString();
                }
                else MessageBox.Show("Comida no encontrada", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAlimentoAgregar_Click(object sender, EventArgs e)
        {

            PictureImagenAlimento.ImageLocation = "";
            txt_priceAlimento.Clear();
            txt_typeAlimento.Clear();

            Alimento alimento = new Alimento();

            #region Nombre
            if (AlimentosAlmacenados.ElementoExistenteNombre(txtAlimentoNombre.Text)) { MessageBox.Show("El alimento ya ha sido ingresado previamente", nombreRestaurante.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
            else if (txtAlimentoNombre.Text == "") { MessageBox.Show("El nombre ingresado está vacío", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else alimento.Nombre = txtAlimentoNombre.Text;
            #endregion

            #region Categoria
            if (cbAlimentoCategoria.SelectedIndex <= 0) { MessageBox.Show("No ha elegido una categoría", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else alimento.Tipo = cbAlimentoCategoria.SelectedItem.ToString();
            #endregion

            #region Precio
            try
            {
                alimento.Precio = double.Parse(txtAlimentoPrecio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("El precio establecido está vacio o no ha sido colocado correctamente", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            #region Imagen
            if (txtAlimentoImagenPath.Text == "") { MessageBox.Show("No ha elegido una imagen", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else
            {
                string path = Path.Combine(@".\temp\", Path.GetFileName("Img" + txtAlimentoNombre.Text + ".png"));
                alimento.Imagen = path;
                File.Copy(txtAlimentoImagenPath.Text, path, true);
            }
            #endregion

            #region Limpiar Casillas
            txtAlimentoNombre.Clear();
            txtAlimentoImagenPath.Clear();
            cbAlimentoCategoria.SelectedIndex = 0;
            txtAlimentoPrecio.Clear();
            #endregion

            AlimentosAlmacenados.Apilar(alimento);
            ActualizarDatos();
            CambiosRealizados = true;
            
        }
        private void btnAlimentoEditar_Click(object sender, EventArgs e)
        {
            PictureImagenAlimento.ImageLocation = "";
            txt_priceAlimento.Clear();
            txt_typeAlimento.Clear();

            if (txtAlimentoNombre.Text.Trim() == "") { MessageBox.Show("El nombre ingresado está vacío", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if(txtAlimentoNombre.Text.Trim().Equals(txtAlimentoBuscarNombre.Text)) 

            if (cbAlimentoCategoria.SelectedIndex <= 0) { MessageBox.Show("No ha elegido una categoría", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                double.Parse(txtAlimentoPrecio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("El precio establecido está vacio o no ha sido colocado correctamente", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAlimentoImagenPath.Text.Trim() == "") { MessageBox.Show("No ha elegido una imagen", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }


            AlimentosAlmacenados.For_Each(item =>
            {
                if (item.Nombre.Equals(txtAlimentoBuscarNombre.Text))
                {
                    item.Nombre = txtAlimentoNombre.Text;
                    item.Tipo = cbAlimentoCategoria.SelectedItem.ToString();
                    item.Precio = double.Parse(txtAlimentoPrecio.Text);
                    //
                    if (!item.Imagen.Equals(txtAlimentoImagenPath.Text))
                    {

                        if (item.Imagen.ToLower()[2] == 't')
                        {
                            File.Delete(item.Imagen);
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                        }
                        string path = Path.Combine(@".\temp\", Path.GetFileName("Img" + txtAlimentoNombre.Text + ".png"));
                        item.Imagen = path;
                        File.Copy(txtAlimentoImagenPath.Text, path, true);
                    }
                    return;
                }
            });

            ActualizarDatos();

            #region Limpiar Casillas
            txtAlimentoNombre.Clear();
            txtAlimentoImagenPath.Clear();
            cbAlimentoCategoria.SelectedIndex = 0;
            txtAlimentoPrecio.Clear();
            txtAlimentoBuscarNombre.Clear();
            #endregion

            #region Restablecer casillas
            CambiosRealizados = true;
            btnAlimentoAgregar.Enabled = true;
            btnAlimentoBuscar.Enabled = true;
            txtAlimentoBuscarNombre.Enabled = true;
            btnAlimentoEditar.Enabled = false;
            btnAlimentoEliminar.Enabled = false;
            #endregion
        }
        private void btnAlimentoEliminar_Click(object sender, EventArgs e)
        {
            AlimentosAlmacenados.EliminarElementoPila(AlimentosAlmacenados.BuscarElemento(1, txtAlimentoBuscarNombre.Text));
            ActualizarDatos();

            #region Limpiar Casillas
            txtAlimentoNombre.Clear();
            txtAlimentoImagenPath.Clear();
            cbAlimentoCategoria.SelectedIndex = 0;
            txtAlimentoPrecio.Clear();
            txtAlimentoBuscarNombre.Clear();
            #endregion

            #region Restablecer casillas
            CambiosRealizados = true;
            btnAlimentoAgregar.Enabled = true;
            btnAlimentoBuscar.Enabled = true;
            txtAlimentoBuscarNombre.Enabled = true;
            btnAlimentoEditar.Enabled = false;
            btnAlimentoEliminar.Enabled = false;
            #endregion
        }

        //Categoria CRUD

        private void btnAdministrarCategorias_Click(object sender, EventArgs e)
        {
            #region Preparativos iniciales
            bool aplicarCambios = false;
            vCRUD form = new vCRUD();
            form.LB_Categorias.Items.Clear();
            form.listaTemporalCategorias = ListaCategorias;
            form.alimentosTemporalAlmacenados = AlimentosAlmacenados;
            form.listaTemporalCategorias.For_Each(categoria => form.LB_Categorias.Items.Add(categoria));
            #endregion

            //Menu contextual
            #region Agregar Categoria
            form.cMOpciones.Items[0].Click += new EventHandler((sender, e) =>
            {
                string nuevaCategoria = inputBoxParameters("Mesero Virtual", "Ingrese el nombre de la nueva categoría",
                    "La categoría ingresada ya existe", form.LB_Categorias);

                if (nuevaCategoria != "") {
                    form.listaTemporalCategorias.InsertToEnd(nuevaCategoria);
                    form.LB_Categorias.Items.Add(nuevaCategoria); 
                    aplicarCambios = true; 
                }
            });
            #endregion

            #region Modificar Categoria
            form.cMOpciones.Items[1].Click += new EventHandler((sender, e) =>
            {
                string categoriaOriginal = form.LB_Categorias.SelectedItem.ToString();
                string editarCategoria = inputBoxParameters("Mesero Virtual", "Ingrese el nombre que tendrá la categoría",
                    "La categoría ingresada ya existe", form.LB_Categorias, categoriaOriginal);

                if (editarCategoria != "") {
                    form.LB_Categorias.Items[form.LB_Categorias.SelectedIndex] = editarCategoria;
                    form.alimentosTemporalAlmacenados.For_Each(alimento => { if (alimento.Tipo.Equals(categoriaOriginal)) alimento.Tipo = editarCategoria;});
                    form.listaTemporalCategorias.EditarElemento(categoriaOriginal, editarCategoria);

                    aplicarCambios = true; 
                }
            });
            #endregion

            #region Eliminar Categoria
            form.cMOpciones.Items[2].Click += new EventHandler((sender, e) =>
            {
                string categoriaOriginal = form.LB_Categorias.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("¿Deseas eliminar esta sección, se van a eliminar los elementos dentro?", "Mesero Virtual", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result is DialogResult.Yes) {
                    form.LB_Categorias.Items.RemoveAt(form.LB_Categorias.SelectedIndex);
                    form.listaTemporalCategorias.DeleteOfData(categoriaOriginal);
                    form.alimentosTemporalAlmacenados.For_Each(alimento =>
                    {
                        if (alimento.Tipo.Equals(categoriaOriginal)) form.alimentosTemporalAlmacenados.EliminarElementoPila(alimento);
                    });
                    aplicarCambios = true; 
                }
            });
            #endregion

            if (form.ShowDialog() == DialogResult.OK) //Guardar Cambios
            {
                if (aplicarCambios)
                {
                    DialogResult result = MessageBox.Show("¿Deseas aplicar los cambios hechos en la categoría?", "Mesero Virtual", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //solo está el agregar
                        ListaCategorias = form.listaTemporalCategorias;
                        AlimentosAlmacenados = form.alimentosTemporalAlmacenados;
                        ActualizarDatos();
                        CambiosRealizados = true;
                    }
                }
            }
        }

        //Botones Varios
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos(@".\datos\BDAlimentos.txt", AlimentosAlmacenados);
            GuardarDatos(@".\datos\BDCategorias.txt", ListaCategorias);
            GuardarDatos(@".\datos\BDConfig.txt", nombreRestaurante.Text);
            CambiosRealizados = false;
        }
        private void btnMandarPedido_Click(object sender, EventArgs e)
        {
            if (listaPedidos.Items.Count == 0) { MessageBox.Show("No existe ningún pedido", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; };
            string text = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de este pedido", nombreRestaurante.Text, "Mesa 1").Trim();
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.InitialDirectory = @"C\\";
            guardar.Filter = "Archivo de texto (*.txt)|*.txt";
            guardar.FileName = text;

            if(guardar.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(guardar.FileName)) ImprimirPedido(guardar.FileName);
                else ImprimirPedido(guardar.FileName);

                listaPedidos.Items.Clear();
            }

        }
        private void btnEstablecerNombreRestaurante_Click(object sender, EventArgs e)
        {
            nombreRestaurante.Text = txtNombreRestaurante.Text;
            MessageBox.Show("Actualizado", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            CambiosRealizados = true;
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (alimentoSelecionado is null) MessageBox.Show("No selecciono un alimento", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Alimento alimento = alimentoSelecionado;
                alimento.Cantidad++;
                ListViewItem dato = new ListViewItem(alimento.Nombre);
                bool alimentoRepetido = false;
                foreach (ListViewItem item in listaPedidos.Items)
                {
                    if (item.SubItems[0].Text.Equals(alimento.Nombre))
                    {
                        int cantidadAumentada = int.Parse(item.SubItems[1].Text);
                        double precioAumentado = double.Parse(item.SubItems[2].Text.Substring(3));
                        cantidadAumentada++;
                        precioAumentado = alimento.Precio * cantidadAumentada;
                        item.SubItems[1].Text = cantidadAumentada.ToString();
                        item.SubItems[2].Text = "S/. " + precioAumentado.ToString();
                        alimentoRepetido = true;
                        break;
                    }
                }

                if (!alimentoRepetido)
                {
                    dato.SubItems.Add(alimento.Cantidad.ToString());
                    dato.SubItems.Add($"S/. {alimento.Precio}");
                    listaPedidos.Items.Add(dato);
                }
            }
        }

        Alimento alimentoSelecionado;

        #endregion

        #region TextBox format
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
            }
        }
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Buscadores
        private ListViewGroup EncontrarGrupo(string name)
        {
            foreach (ListViewGroup item in LVComidas.Groups) if (name.Equals(item.Header)) return item;
            return null;
        }
        private ListViewItem EncontrarItem(string name)
        {
            foreach (ListViewItem item in LVComidas.Items) if (name.Equals(item.Text)) return item;
            return null;
        }
        #endregion

        #region Save/Load
        private void GuardarDatos(string path, object type)
        {
            switch (type)
            {
                case PilaAlimento:
                    {
                        AlimentosAlmacenados.For_Each(item =>
                        {
                            if (item.Imagen.ToLower()[2] == 't') //si sus imágenes están en el temp
                            {
                                File.Move(item.Imagen, Path.Combine(@".\AlimentosImagenes\", Path.GetFileName("Img" + item.Nombre + ".png")), true);
                                GC.Collect();
                                GC.WaitForPendingFinalizers();
                                item.Imagen = Path.Combine(@".\AlimentosImagenes\", Path.GetFileName("Img" + item.Nombre + ".png"));
                            }
                        });
                        string[] paths = Directory.GetFiles(@".\AlimentosImagenes\");
                        foreach (string imagen in paths)
                        {
                            bool imagenConAlimento = false;
                            AlimentosAlmacenados.For_Each(alimento =>
                            {
                                if (Path.GetFileName(imagen).Equals(Path.GetFileName(alimento.Imagen))) imagenConAlimento = true;
                            });
                            if (!imagenConAlimento)
                            {
                                File.Delete(imagen);
                                GC.Collect();
                                GC.WaitForPendingFinalizers();
                            }
                        }

                        StreamWriter guardar = File.CreateText(path);
                        AlimentosAlmacenados.For_Each(item => guardar.WriteLine(item));
                        guardar.Close();
                        break;
                    }
                case ListaEnlazadaCategorias:
                    {
                        StreamWriter guardar = File.CreateText(path);
                        ListaCategorias.For_Each(item => guardar.WriteLine(item));
                        guardar.Close();
                        break;
                    }
                case string:
                    {
                        StreamWriter guardar = File.CreateText(path);
                        guardar.WriteLine(nombreRestaurante.Text);
                        guardar.Close();
                        break;
                    }
                default: break;
            }
        }
        private void CargarDatos(string path, object type)
        {
            switch (type)
            {
                case PilaAlimento:
                    {
                        StreamReader cargar = File.OpenText(path);
                        string[] variasLineas;
                        while (!cargar.EndOfStream)
                        {
                            variasLineas = cargar.ReadLine().Split('♦');
                            Alimento alimento = new Alimento(
                                variasLineas[0], //Nombre
                                variasLineas[1], //Ruta imagen
                                variasLineas[2], //Tipo
                   double.Parse(variasLineas[3]) //Precio
                                );

                            AlimentosAlmacenados.Apilar(alimento);
                        }

                        cargar.Close();
                    } break;

                case ListaEnlazadaCategorias:
                    {
                        StreamReader cargar = File.OpenText(path);
                        string[] variasLineas;
                        while (!cargar.EndOfStream) ListaCategorias.InsertToEnd(cargar.ReadLine());
                        cargar.Close();
                    } break;

                case string:
                    {
                        StreamReader cargar = File.OpenText(path);
                        string[] variasLineas;
                        while (!cargar.EndOfStream) nombreRestaurante.Text = cargar.ReadLine();
                        cargar.Close();
                        break;
                    }

                default: break;
            }
        }
        #endregion

        private void FMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CambiosRealizados)
            {
                DialogResult dialog = MessageBox.Show("¿Desea guardar los cambios hechos?", "Mesero Virtual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog is DialogResult.Yes)
                {
                    GuardarDatos(@".\datos\BDAlimentos.txt", AlimentosAlmacenados);
                    GuardarDatos(@".\datos\BDCategorias.txt", ListaCategorias);
                    GuardarDatos(@".\datos\BDConfig.txt", nombreRestaurante.Text);
                }
                else
                {
                    AlimentosAlmacenados.For_Each(alimento =>
                    {
                        if (alimento.Imagen.ToLower()[2] == 't')
                        {
                            File.Delete(alimento.Imagen);
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                        }
                    });
                    //Borrar imágenes del temp

                }
                CambiosRealizados = false;
            }

        }

        private void ImprimirPedido(string path)
        {
            StreamWriter escribir = File.CreateText(path);
            foreach (ListViewItem item in listaPedidos.Items)
            {
                escribir.WriteLine($"{item.SubItems[0].Text} x{item.SubItems[1].Text}");
            }
            escribir.Flush();
            escribir.Close();
        }

        private string inputBoxParameters(string titulo, string descripcion, string errorMensaje, ListBox list, string defaultAnswer = "")
        {
            string text = Microsoft.VisualBasic.Interaction.InputBox(descripcion, titulo, defaultAnswer).Trim();
            foreach (string item in list.Items) if (item.Equals(text)) { MessageBox.Show(errorMensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning); return ""; }
            return text;
        }

        private void VerInformacion(object sender, MouseEventArgs e)
        {
            txt_typeAlimento.Text = LVComidas.SelectedItems[0].SubItems[0].Text;
            Alimento verAlimento = AlimentosAlmacenados.BuscarElemento(1, txt_typeAlimento.Text);
            txt_priceAlimento.Text = "S/. " + verAlimento.Precio.ToString();
            PictureImagenAlimento.ImageLocation = verAlimento.Imagen;
            alimentoSelecionado = verAlimento;
        }

        private void menuContextual_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (listaPedidos.SelectedItems[0].Index != -1) menuContextual.Items[0].Enabled = true;
                else menuContextual.Items[0].Enabled = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                menuContextual.Items[0].Enabled = false;
            }
        }

        private void tsmRetirarPedido_Click(object sender, EventArgs e)
        {
            AlimentosAlmacenados.For_Each(alimento =>
            {
                foreach (ListViewItem item in listaPedidos.Items)
                {
                    if (item.SubItems[0].Text.Equals(alimento.Nombre)) alimento.Cantidad = 0;
                }
            });

            listaPedidos.Items.RemoveAt(listaPedidos.SelectedItems[0].Index);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e) => FiltroGeneral();

        private void FiltroGeneral()
        {
            LVComidas.Items.Clear();
            if (txtFiltro.Text.Trim().Equals("") && cbFiltro.SelectedIndex == 0)
            {
                AlimentosAlmacenados.For_Each(item =>
                LVComidas.Items.Add(new ListViewItem(item.Nombre, EncontrarGrupo(item.Tipo))));
            }
            else
            {
                AlimentosAlmacenados.For_Each(item =>
                {
                    if (item.Nombre.Trim().ToLower().Contains(txtFiltro.Text.ToLower()))
                    { 
                        LVComidas.Items.Add(new ListViewItem(item.Nombre, EncontrarGrupo(item.Tipo))); 
                        if(!(cbFiltro.SelectedIndex == 0))
                            if(!(cbFiltro.SelectedItem.ToString() == item.Tipo)) LVComidas.Items.Remove(EncontrarItem(item.Nombre));

                    }
                    //else
                    //    LVComidas.Items.Remove(EncontrarItem(item.Nombre));
                });
            }
        }

        private void cbFiltroCambia(object sender, EventArgs e) => FiltroGeneral();
    }
}