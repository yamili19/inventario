using Para_inventario.Clases;
using Para_inventario.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Para_inventario.Transacciones
{
    public partial class prestamoMaquina : Form
    {
        Maquina m = new Maquina();
        Prestamo prestamo = new Prestamo();
        public prestamoMaquina()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void prestamoMaquina_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            m.mostrar(dataMaquinaEliminar);
            m.mostrarNombreMaquina(comboMaquina);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado = hayMaquina(Convert.ToInt32(comboMaquina.SelectedValue));
            if (resultado || comboMaquina.SelectedIndex == -1 || maskCantidad.Text == 0.ToString() || maskCantidad.Text == null ||
                txtNombre.Text == "")
            {
                MessageBox.Show("Primero seleccione una máquina e ingrese una cantidad y nombre del encargado del prestamo y " +
                    "por favor no repita máquina");
            }
            else
            {
                m.verificarCantidadMaquina(Convert.ToInt32(comboMaquina.SelectedValue), int.Parse(maskCantidad.Text),dataMaquinaEliminar, dataPrestamos, txtNombre.Text);
                maskCantidad.Text = null;
                txtNombre.Text = "";
                comboMaquina.SelectedIndex = -1;
            }
        }

        private bool hayMaquina(int nro)
        {
            bool bandera = false;
            for (int i = 0; i < dataPrestamos.Rows.Count; i++)
            {
                if (dataPrestamos.CurrentRow.Cells["inventarioMaquinas"].Value.ToString() == nro.ToString())
                {
                    bandera = true;
                    break;
                }
            }
            return bandera;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataPrestamos.Rows.Remove(dataPrestamos.CurrentRow);
            btnEliminar.Enabled = false;
        }

        private void btnRegistrarPrestamos_Click(object sender, EventArgs e)
        {
            if (dataPrestamos.Rows.Count == 0)
            {
                MessageBox.Show("No hay préstamos para registrar");
            }
            else
            {
                prestamo.registrarPrestamoMaquina(dataPrestamos);
                dataPrestamos.Rows.Clear();
                comboMaquina.SelectedIndex = -1;
                maskCantidad.Text = null;
                txtNombre.Text = "";
                btnEliminar.Enabled = false;
                m.mostrar(dataMaquinaEliminar);
            }
        }

        private void dataPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnMostrarPrestamos_Click(object sender, EventArgs e)
        {
            mostrarPrestamosMaquinas ventana = new mostrarPrestamosMaquinas();
            ventana.Show();
            this.Hide();    
        }
    }
}
