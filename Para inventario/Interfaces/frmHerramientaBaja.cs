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
        public frmHerramientaBaja()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal venta= new frmPrincipal();
            venta.Show();
            this.Hide();
        }

        private void frmHerramientaBaja_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled= false;
            Herramienta herramienta = new Herramienta();
            herramienta.mostrar(dataHerramientasBaja);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Herramienta herramienta = new Herramienta();    
                herramienta.eliminar(dataHerramientasBaja);
                herramienta.mostrar(dataHerramientasBaja);
                btnEliminar.Enabled = false;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataHerramientasBaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }
    }
}
