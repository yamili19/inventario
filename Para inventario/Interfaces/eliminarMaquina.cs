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
    public partial class eliminarMaquina : Form
    {
        Maquina maquina = new Maquina();
        public eliminarMaquina()
        {
            InitializeComponent();
        }

        private void dataInformaticaEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void eliminarMaquina_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            maquina.mostrar(dataMaquinaEliminar);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                maquina.eliminar(dataMaquinaEliminar); 
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar máquina");
            }
        }
    }
}
