using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeseroVirtual
{
    public partial class vCRUD : Form
    {
        public vCRUD() => InitializeComponent();

        private void vCRUD_Load(object sender, EventArgs e)
        {

        }
        private void cMOpciones_Opening(object sender, CancelEventArgs e)
        {
            if (LB_Categorias.SelectedIndex is -1)
            {
                cMOpciones.Items[0].Enabled = true;
                cMOpciones.Items[1].Enabled = false;
                cMOpciones.Items[2].Enabled = false;
            }
            else
            {
                cMOpciones.Items[0].Enabled = false;
                cMOpciones.Items[1].Enabled = true;
                cMOpciones.Items[2].Enabled = true;
            }
        }

        private void LB_Categorias_DoubleClick(object sender, EventArgs e) => LB_Categorias.SelectedItem = null;
    }
}
