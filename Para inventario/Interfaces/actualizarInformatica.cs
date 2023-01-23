using Microsoft.VisualBasic;
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
    public partial class actualizarInformatica : Form
    {
        Informática informatica = new Informática();
        public actualizarInformatica()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void actualizarInformatica_Load(object sender, EventArgs e)
        {
            informatica.mostrar(dataInformaticaActualizar);
            btnActualizar.Enabled = false;
        }

        private void dataInformaticaActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Informática informática = new Informática();
            int cantidad = int.Parse(dataInformaticaActualizar.CurrentRow.Cells["cantidad"].Value.ToString());
            if (cantidad > 0)
            {
                informática.nro = Convert.ToInt32(dataInformaticaActualizar.CurrentRow.Cells["nro"].Value.ToString());
                informática.cantidad = Convert.ToInt32(dataInformaticaActualizar.CurrentRow.Cells["cantidad"].Value.ToString());
                informática.lugar = dataInformaticaActualizar.CurrentRow.Cells["lugar"].Value.ToString();
                informática.actualizar(informática);
                btnActualizar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ingrese un número entero mayor a 0 en la columna cantidad");
                dataInformaticaActualizar.CurrentRow.SetValues();
                btnActualizar.Enabled =false;   
            }
            dataInformaticaActualizar.Refresh();
        }

        private void dataInformaticaActualizar_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ingrese un número entero mayor a 0 en la columna cantidad");
        }
    }
}
