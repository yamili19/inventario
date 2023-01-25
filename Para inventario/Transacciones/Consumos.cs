using Para_inventario.Clases;
using Para_inventario.Interfaces;
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
    public partial class Consumos : Form
    {
        Consumible consumible = new Consumible();
        public Consumos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();  
            ventana.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (comboConsumible.SelectedIndex == -1 || maskedCantidad.Text == null)
            {
                MessageBox.Show("Primero seleccione un consumible e ingrese una cantidad");
            }
            else
            {
                consumible.verificarCantidad(dataConsumibles, Convert.ToInt32(comboConsumible.SelectedValue), int.Parse(maskedCantidad.Text),
                       dataConsumos, dtFecha.Value);
                comboConsumible.SelectedIndex = -1;
                maskedCantidad.Text = null;
            }
        }

        private void Consumos_Load(object sender, EventArgs e)
        {
            consumible.mostrarNombreConsumible(comboConsumible);
        }

        private void btnRegistrarConsumos_Click(object sender, EventArgs e)
        {
            consumible.aregarConsumo(dataConsumos);
            comboConsumible.SelectedIndex = -1;
            maskedCantidad.Text = null;
            dataConsumos.Rows.Clear();
        }

        private void btnMostrarConsumos_Click(object sender, EventArgs e)
        {
            mostrarConsumos ventana = new mostrarConsumos();
            ventana.Show();
            this.Hide();
        }
    }
}
