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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHerramientaBaja ventana = new frmHerramientaBaja();
            ventana.Show();
            this.Hide();    
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHerramientasActualizacion ventana = new frmHerramientasActualizacion();
            ventana.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHerramientasConsultar ventana = new frmHerramientasConsultar();
            ventana.Show();
            this.Hide();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarElementosDibujo ventana = new actualizarElementosDibujo();
            ventana.Show(); 
            this.Hide();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            elementosDibujoAgregar ventana = new elementosDibujoAgregar();
            ventana.Show(); 
            this.Hide();    
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultarElementosDibujo ventana = new consultarElementosDibujo();
            ventana.Show(); 
            this.Hide();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            eliminarElementosDibujo ventana = new eliminarElementosDibujo();
            ventana.Show();
            this.Hide();
        }
    }
}
