using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Para_inventario.Interfaces
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //private void agregarHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHerramientas ventana = new frmHerramientas();
            ventana.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
