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
    public partial class prestamoED : Form
    {
        ElementoDibujo ed = new ElementoDibujo();
        Prestamo prestamo = new Prestamo();
        public prestamoED()
        {
            InitializeComponent();
        }

        private void dataPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnRegistrarPrestamos_Click(object sender, EventArgs e)
        {
            if (dataPrestamos.Rows.Count > 0) 
            {
                prestamo.registrarPrestamoED(dataPrestamos);
                dataPrestamos.Rows.Clear();
            }
            else
            {
                MessageBox.Show("No hay préstamos para registrar");
            }
        }

        private void prestamoED_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            ed.mostrarNombreED(comboED);
            ed.mostrar(dataEDEliminar);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataPrestamos.Rows.Remove(dataPrestamos.CurrentRow);
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool restulado = estaED(Convert.ToInt32(comboED.SelectedValue));
            if (restulado || comboED.SelectedIndex == -1 || maskCantidad.Text == 0.ToString() || maskCantidad.Text == null || txtNombre.Text == "") 
            {
                MessageBox.Show("Primero seleccione un elemento de dibujo e ingrese una cantidad y nombre del encargado del prestamo " +
                    "y por favor no repita elemento de dibujo");
            }
            else
            {
                ed.verificarCantidadED(Convert.ToInt32(comboED.SelectedValue), dataEDEliminar, dataPrestamos,
                    txtNombre.Text, int.Parse(maskCantidad.Text));
                comboED.SelectedIndex= -1;
                maskCantidad.Text = null;
                txtNombre.Text = "";  
            }
        }

        private bool estaED(int ED)
        {
            bool bandera = false;
            for (int i = 0; i < dataPrestamos.Rows.Count; i++)
            {
                if (dataPrestamos.CurrentRow.Cells["inventarioElementosDibujo"].Value.ToString() == ED.ToString())
                {
                    bandera = true;
                    break;
                }
            }
            return bandera;
        }

        private void btnMostrarPrestamos_Click(object sender, EventArgs e)
        {
            mostrarPrestamosED ventana = new mostrarPrestamosED();
            ventana.Show();
            this.Hide();
        }
    }
}
