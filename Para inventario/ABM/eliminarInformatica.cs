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
    public partial class eliminarInformatica : Form
    {
        Informática informatica = new Informática();
        public eliminarInformatica()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();    
        }

        private void eliminarInformatica_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            informatica.mostrar(dataInformaticaEliminar);
        }

        private void dataInformaticaEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                informatica.eliminar(dataInformaticaEliminar);
                btnEliminar.Enabled = false;
            }
            catch(Exception) 
            {
                btnEliminar.Enabled = false;
                MessageBox.Show("Error al eliminar elemento de informática");
            }
        }
    }
}
