using Clases;
using System.IO;
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
        }
        private void ActualizarDatos()
        {
            #region ListView Agregar
            ListaCategorias.For_Each(item => 
            LVComidas.Groups.Add(new ListViewGroup(item, HorizontalAlignment.Center)));

            AlimentosAlmacenados.For_Each(item =>
                LVComidas.Items.Add(new ListViewItem(item.Nombre, EncontrarGrupo(item.Tipo))));
            #endregion

            #region ComboBox update
            cbAlimentoCategoria.Items.Clear();
            cbAlimentoCategoria.Items.Insert(0, "---Selecciona una categoria---");
            foreach (ListViewGroup item in LVComidas.Groups) cbAlimentoCategoria.Items.Add(item.Header);
            cbAlimentoCategoria.SelectedIndex = 0;
            #endregion
        }

        private void ActualizarComboBox()
        {
            #region ComboBox update
            cbAlimentoCategoria.Items.Clear();
            cbAlimentoCategoria.Items.Insert(0, "---Selecciona una categoria---");
            foreach (ListViewGroup item in LVComidas.Groups) cbAlimentoCategoria.Items.Add(item.Header);
            cbAlimentoCategoria.SelectedIndex = 0;
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
                    Alimento alimento = AlimentosAlmacenados.BuscarElementoExistenteNombre(txtAlimentoBuscarNombre.Text);

                    MessageBox.Show("Comida encontrada", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (EncontrarGrupo(alimento.Tipo) is null) { MessageBox.Show($"Ha ocurrido un error", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else LVComidas.Items.Add(new ListViewItem(alimento.Nombre, EncontrarGrupo(alimento.Tipo)));

            #region Limpiar Casillas
            txtAlimentoNombre.Clear();
            txtAlimentoImagenPath.Clear();
            cbAlimentoCategoria.SelectedIndex = 0;
            txtAlimentoPrecio.Clear();
            #endregion

            AlimentosAlmacenados.Apilar(alimento);
            CambiosRealizados = true;
            //CambiosRealizados = true;
            
        }
        private void btnAlimentoEditar_Click(object sender, EventArgs e)
        {
            //PictureImagenAlimento.ImageLocation = "";
            //txt_priceAlimento.Clear();
            //txt_typeAlimento.Clear();

            //Alimento alimento = new Alimento();

            //#region Nombre
            //if (txtAlimentoNombre.Text == "") { MessageBox.Show("El nombre ingresado está vacío", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            //else alimento.Nombre = txtAlimentoNombre.Text;
            //#endregion

            //#region Categoria
            //if (cbAlimentoCategoria.SelectedIndex <= 0) { MessageBox.Show("No ha elegido una categoría", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            //else alimento.Tipo = cbAlimentoCategoria.SelectedItem.ToString();
            //#endregion

            //#region Precio
            //try
            //{
            //    alimento.Precio = double.Parse(txtAlimentoPrecio.Text);
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("El precio establecido está vacio o no ha sido colocado correctamente", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //#endregion

            //#region Imagen
            //if (txtAlimentoImagenPath.Text == "") { MessageBox.Show("No ha elegido una imagen", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            //else
            //{
            //    string path = Path.Combine(@".\temp\", Path.GetFileName("Img" + txtAlimentoNombre.Text + ".png"));
            //    alimento.Imagen = path;
            //    File.Copy(txtAlimentoImagenPath.Text, path, true);
            //}
            //#endregion

            //if (EncontrarGrupo(alimento.Tipo) is null) { MessageBox.Show($"Ha ocurrido un error", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            //#region Limpiar Casillas
            //txtAlimentoNombre.Clear();
            //txtAlimentoImagenPath.Clear();
            //cbAlimentoCategoria.SelectedIndex = 0;
            //txtAlimentoPrecio.Clear();
            //#endregion

            //AlimentosAlmacenados.For_Each(item =>
            //{
            //    if (item.Nombre.Equals(txtAlimentoBuscarNombre.Text))
            //    {
            //        if(item.Imagen != alimento.Imagen)
            //        {
            //            File.Delete(item.Imagen);
            //            GC.Collect();
            //            GC.WaitForPendingFinalizers();
            //        }
            //        item = alimento;
            //    }
            //});



            //CambiosRealizados = true;
            MessageBox.Show("No implementado aun");
            btnAlimentoAgregar.Enabled = true;
            btnAlimentoBuscar.Enabled = true;
            txtAlimentoBuscarNombre.Enabled = true;
            btnAlimentoEditar.Enabled = false;
            btnAlimentoEliminar.Enabled = false;
        }

        //Categoria CRUD

        private void btnAdministrarCategorias_Click(object sender, EventArgs e)
        {
            bool aplicarCambios = false;
            vCRUD form = new vCRUD();
            form.LB_Categorias.Items.Clear();
            ListaCategorias.For_Each(categoria => form.LB_Categorias.Items.Add(categoria));

            //Menu contextual
            #region Agregar Categoria
            form.cMOpciones.Items[0].Click += new EventHandler((sender, e) =>
            {
                string nuevaCategoria = inputBoxParameters("Mesero Virtual", "Ingrese el nombre de la nueva categoría",
                    "La categoría ingresada ya existe", form.LB_Categorias);

                if (nuevaCategoria != "") { form.LB_Categorias.Items.Add(nuevaCategoria); aplicarCambios = true; }
            });
            #endregion

            #region Modificar Categoria
            form.cMOpciones.Items[1].Click += new EventHandler((sender, e) =>
            {
                string editarCategoria = inputBoxParameters("Mesero Virtual", "Ingrese el nombre que tendrá la categoría",
                    "La categoría ingresada ya existe", form.LB_Categorias);

                if (editarCategoria != "") { form.LB_Categorias.Items[form.LB_Categorias.SelectedIndex] = editarCategoria; aplicarCambios = true; }
            });
            #endregion

            #region Eliminar Categoria
            form.cMOpciones.Items[2].Click += new EventHandler((sender, e) =>
            {
                DialogResult result = MessageBox.Show("¿Deseas eliminar esta sección, se van a eliminar los elementos dentro?", "Mesero Virtual", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result is DialogResult.Yes) { form.LB_Categorias.Items.RemoveAt(form.LB_Categorias.SelectedIndex); aplicarCambios = true; }
            });
            #endregion

            if (form.ShowDialog() == DialogResult.OK) //Guardar Cambios
            {
                DialogResult result = MessageBox.Show("¿Deseas aplicar los cambios hechos?", "Mesero Virtual", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Aun no se implementa esta opción");
                }
            }
        }

        //Botones Varios
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos(@".\datos\BDAlimentos.txt", AlimentosAlmacenados);
            GuardarDatos(@".\datos\BDCategorias.txt", ListaCategorias);
            CambiosRealizados = false;
        }

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
                                File.Move(item.Imagen, Path.Combine(@".\AlimentosImagenes\", Path.GetFileName("Img" + item.Nombre + ".png")));
                                GC.Collect();
                                GC.WaitForPendingFinalizers();
                                item.Imagen = Path.Combine(@".\AlimentosImagenes\", Path.GetFileName("Img" + item.Nombre + ".png"));
                            }
                        });
                        
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

        private string inputBoxParameters(string titulo, string descripcion, string errorMensaje, ListBox list)
        {
            string text = Microsoft.VisualBasic.Interaction.InputBox(descripcion, titulo).Trim();
            foreach (string item in list.Items) if (item.Equals(text)) { MessageBox.Show(errorMensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning); return ""; }
            return text;
        }

        private void VerInformacion(object sender, MouseEventArgs e)
        {
            txt_typeAlimento.Text = LVComidas.SelectedItems[0].SubItems[0].Text;
            Alimento verAlimento = AlimentosAlmacenados.BuscarElementoExistenteNombre(txt_typeAlimento.Text);
            txt_priceAlimento.Text = "S/. " + verAlimento.Precio.ToString();
            PictureImagenAlimento.ImageLocation = verAlimento.Imagen;
        }
    }
}