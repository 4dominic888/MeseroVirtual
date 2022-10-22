using Clases;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace MeseroVirtual
{
    public partial class FMenu : Form
    {
        public ListaEnlazada listaImagenesID = new ListaEnlazada();
        public PilaAlimento AlimentosAlmacenados = new PilaAlimento();
        public bool CambiosRealizados = false;
        public FMenu() => InitializeComponent();

        private void FMenu_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
            LVComidas.Items.Clear();
            txtAlimentoImagenPath.Clear();
            DatosAlmacenados();
        }

        private void DatosAlmacenados()
        {

        } //seguir llenando
        private void ActualizarDatos()
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
            //esta es una actualización nueva
            int update = 888;
            Alimento alimento = new Alimento();

            #region Nombre
            if (txtAlimentoNombre.Text != "") alimento.Nombre = txtAlimentoNombre.Text;
            else if (AlimentosAlmacenados.ElementoExistenteNombre(txtAlimentoNombre.Text)){ MessageBox.Show("El alimento ya ha sido ingresado previamente", nombreRestaurante.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
            else { MessageBox.Show("El nombre ingresado está vacío", nombreRestaurante.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
            #endregion

            #region Categoria
            if (cbAlimentoCategoria.SelectedIndex <= 0) { MessageBox.Show("No ha elegido una categoría", nombreRestaurante.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
            else alimento.Tipo = cbAlimentoCategoria.SelectedItem.ToString();
            #endregion

            #region Precio
            try
            {
                alimento.Precio = double.Parse(txtAlimentoPrecio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("El precio establecido está vacio o no ha sido colocado correctamente", nombreRestaurante.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            #endregion

            #region Imagen
            if (txtAlimentoImagenPath.Text == "") { MessageBox.Show("No ha elegido una imagen", nombreRestaurante.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
            else
            {
                listaImagenesID.InsertToEnd("Img" + txtAlimentoNombre.Text + ".png");

                string path = Path.Combine(@".\temp\", Path.GetFileName("Img" + txtAlimentoNombre.Text + ".png"));
                alimento.Imagen = path;
                File.Copy(txtAlimentoImagenPath.Text, path, true);
            }
            #endregion

            if (EncontrarGrupo(alimento.Tipo) is null) { MessageBox.Show($"Ha ocurrido un error", nombreRestaurante.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); return; }
            else LVComidas.Items.Add(new ListViewItem(alimento.Nombre, EncontrarGrupo(alimento.Tipo)));

            #region Limpiar Casillas
            txtAlimentoNombre.Clear();
            txtAlimentoImagenPath.Clear();
            cbAlimentoCategoria.SelectedIndex = 0;
            txtAlimentoPrecio.Clear();
            #endregion
        }

        //Categoria CRUD
        private void btnCategoriaAgregar_Click(object sender, EventArgs e)
        {
            LVComidas.Groups.Add(new ListViewGroup(txtCategoriaNombre.Text, HorizontalAlignment.Center));
            ActualizarDatos();
            txtCategoriaNombre.Clear();
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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        #endregion
        private ListViewGroup EncontrarGrupo(string name)
        {
            foreach (ListViewGroup item in LVComidas.Groups) if (name.Equals(item.Header)) return item;
            return null;
        }

        private void GuardarDatos(string path)
        {

        }

        private void FMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CambiosRealizados)
            {
                DialogResult dialog = MessageBox.Show("¿Desea cerrar el programa y guardar los cambios hechos?", "Mesero Virtual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialog is DialogResult.Yes)
                {
                    GuardarDatos("");
                    //más
                }
                else
                {
                    //Borrar imagenes guardadas localmente
                }
            }

        }
    }
}