using Para_inventario.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Para_inventario.Interfaces
{
    public partial class actualizarElementosDibujo : Form
    {
        ElementoDibujo elemento = new ElementoDibujo();
        public actualizarElementosDibujo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void actualizarElementosDibujo_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            elemento.mostrar(dataEDActualizar);
        }

        private void dataEDActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int cantidadComprada = int.Parse(dataEDActualizar.CurrentRow.Cells["cantidadComprada"].Value.ToString());
            int cantidadDisponible = int.Parse(dataEDActualizar.CurrentRow.Cells["cantidadDisponible"].Value.ToString());
            if (cantidadComprada >= cantidadDisponible)
            {
                elemento.actualizar(dataEDActualizar);
                btnActualizar.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = false;
                dataEDActualizar.CurrentRow.SetValues();
                MessageBox.Show("La cantidad comprada del elemento de dibujo tiene que ser mayor o igual a la cantidad disponible");
            }
            dataEDActualizar.Refresh();
        }

        private void dataEDActualizar_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ingrese un numero entero mayor o igual a la cantidad disponible en la columna Cantidad Comprada");
        }
    }
}
