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
    public partial class actualizarConsumibles : Form
    {
        Consumible consumible = new Consumible();
        public actualizarConsumibles()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void actualizarConsumibles_Load(object sender, EventArgs e)
        {
            consumible.mostrar(dataConsumiblesActualizar);
            btnActualizar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (int.Parse(dataConsumiblesActualizar.CurrentRow.Cells["cantidadComprada"].Value.ToString()) >=
                int.Parse(dataConsumiblesActualizar.CurrentRow.Cells["cantidadDisponible"].Value.ToString()))
            {
                consumible.actualizar(dataConsumiblesActualizar);
                limpiarCampos();   
            }
            else
            {
                MessageBox.Show("La cantidad comprada del consumible tiene que ser mayor o igual a la cantidad disponible");
                dataConsumiblesActualizar.CurrentRow.SetValues();
                limpiarCampos();
            }
            consumible.mostrar(dataConsumiblesActualizar);
        }

        private void limpiarCampos()
        {
            btnActualizar.Enabled = false;
        }

        private void dataConsumiblesActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
        }

        private void dataConsumiblesActualizar_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("La cantidad comprada del consumible tiene que ser mayor o igual a la cantidad disponible");
        }
    }
}
