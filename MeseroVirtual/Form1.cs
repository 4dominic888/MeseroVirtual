using Clases;
using System.IO;
using System.Security.Cryptography.X509Certificates;

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

        //Categoria CRUD
        private void btnCategoriaAgregar_Click(object sender, EventArgs e)
        {
            if (EncontrarGrupo(txtCategoriaNombre.Text) is null)
            { 
                LVComidas.Groups.Add(new ListViewGroup(txtCategoriaNombre.Text, HorizontalAlignment.Center));
                ListaCategorias.InsertToEnd(txtCategoriaNombre.Text);
            }
            else { MessageBox.Show("La categoría ya existe", nombreRestaurante.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            ActualizarComboBox();
            txtCategoriaNombre.Clear();
            CambiosRealizados = true;
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
    }
}