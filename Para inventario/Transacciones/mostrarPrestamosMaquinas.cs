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
    public partial class mostrarPrestamosMaquinas : Form
    {
        Prestamo prestamo = new Prestamo();
        public mostrarPrestamosMaquinas()
        {
            InitializeComponent();
        }

        private void mostrarPrestamosMaquinas_Load(object sender, EventArgs e)
        {
            prestamo.mostrarPrestamosMaquinas(dataPrestamos);
            btnRegistrarDev.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            prestamoHerramientas ventana = new prestamoHerramientas();
            ventana.Show();
            this.Hide();
        }

        private void dataPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRegistrarDev.Enabled = true; 
        }
    }
}
