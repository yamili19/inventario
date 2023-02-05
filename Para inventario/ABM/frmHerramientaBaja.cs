using Para_inventario.Clases;
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
    public partial class frmHerramientaBaja : Form
    {
        Herramienta herramienta = new Herramienta();
        public frmHerramientaBaja()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal venta= new frmPrincipal();
            venta.Show();
            this.Close();
        }

        private void frmHerramientaBaja_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled= false;
            herramienta.mostrar(dataHerramientasBaja);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                herramienta.eliminar(dataHerramientasBaja);
                btnEliminar.Enabled = false;
            }
            catch(Exception) 
            {
                btnEliminar.Enabled = false;
                MessageBox.Show("Error al eliminar herramienta");
            }
        }

        private void dataHerramientasBaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }
    }
}
