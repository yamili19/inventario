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
using System.Xml.Linq;

namespace Para_inventario.Interfaces
{
    public partial class frmHerramientasActualizacion : Form
    {
        Herramienta herramienta = new Herramienta();
        public frmHerramientasActualizacion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void frmHerramientasActualizacion_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            herramienta.mostrar(dataHerramientasActualizar); 
        }

        private void dataHerramientasActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizar.Enabled = true;
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Herramienta herramienta = new Herramienta();
            if (Convert.ToInt32(dataHerramientasActualizar.CurrentRow.Cells["cantidad"].Value.ToString()) > 0)
            {
                herramienta.nro = Convert.ToInt32(dataHerramientasActualizar.CurrentRow.Cells["nro"].Value.ToString());
                herramienta.lugar = dataHerramientasActualizar.CurrentRow.Cells["lugar"].Value.ToString();
                herramienta.cantidad = Convert.ToInt32(dataHerramientasActualizar.CurrentRow.Cells["cantidad"].Value.ToString());
                herramienta.actualizar(herramienta);
                btnActualizar.Enabled = false;
            }
            else
            {
                MessageBox.Show("La cantidad de la herramienta tiene que ser mayor a 0");
                btnActualizar.Enabled = false;
                dataHerramientasActualizar.CurrentRow.SetValues();
            }
            herramienta.mostrar(dataHerramientasActualizar);
        }

        private void dataHerramientasActualizar_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ingrese un numero entero mayor a 0 en la columna Cantidad");
        }
    }
}
