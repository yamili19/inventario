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

namespace Para_inventario.Transacciones
{
    public partial class mostrarPrestamoHerramienta : Form
    {
        Prestamo prestamo = new Prestamo();
        public mostrarPrestamoHerramienta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            prestamoHerramientas ventana = new prestamoHerramientas();
            ventana.Show(); 
            this.Close();
        }

        private void mostrarPrestamoHerramienta_Load(object sender, EventArgs e)
        {
            btnRegistrarDev.Enabled = false;
            prestamo.mostrarPrestamoHerramienta(dataPrestamos);
        }

        private void dataPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRegistrarDev.Enabled = true; 
        }

        private void btnRegistrarDev_Click(object sender, EventArgs e)
        {
            if (dataPrestamos.CurrentRow.Cells["fechaDevolucion"].Value.ToString() == "")
            {
                prestamo.nroInventario = int.Parse(dataPrestamos.CurrentRow.Cells["inventarioHerramienta"].Value.ToString());
                prestamo.cantidad = int.Parse(dataPrestamos.CurrentRow.Cells["cantidadDisponible"].Value.ToString());
                prestamo.fechaPrestamo = Convert.ToDateTime(dataPrestamos.CurrentRow.Cells["fechaPrestamo"].Value.ToString());
                prestamo.registrarDevHerramienta(prestamo);
                dataPrestamos.CurrentRow.Cells["fechaDevolucion"].Value = DateTime.Now.Date.ToString();
                dataPrestamos.Refresh();
            }
            else
            {
                MessageBox.Show("Ya se registró la devolución");
            }
            btnRegistrarDev.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            prestamo.buscarPorEncargado(txtEncargado.Text, dataPrestamos);
        }
    }
}
