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
    public partial class actualizarMaquina : Form
    {
        Maquina maquina = new Maquina();
        public actualizarMaquina()
        {
            InitializeComponent();
        }

        private void actualizarMaquina_Load(object sender, EventArgs e)
        {
            maquina.mostrar(dataMaquinasActualizar);
            btnActualizar.Enabled = false;
        }

        private void dataMaquinasActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
        }

        private void dataMaquinasActualizar_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ingrese un número entero mayor a 0 en la columna cantidad");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Maquina maquina = new Maquina();
            int cantidad = int.Parse(dataMaquinasActualizar.CurrentRow.Cells["cantidad"].Value.ToString());
            if (cantidad > 0)
            {
                maquina.nro = int.Parse(dataMaquinasActualizar.CurrentRow.Cells["nro"].Value.ToString());
                maquina.lugar = dataMaquinasActualizar.CurrentRow.Cells["lugar"].Value.ToString();
                maquina.cantidad = cantidad;
                maquina.actualizar(maquina);
            }
            else
            {
                MessageBox.Show("Ingrese un número entero mayor a 0 en la columna cantidad");
                dataMaquinasActualizar.CurrentRow.SetValues();
            }
            btnActualizar.Enabled = false;
            maquina.mostrar(dataMaquinasActualizar);
        }
    }
}
