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
    public partial class prestamoHerramientas : Form
    {
        Herramienta herramientaaaa = new Herramienta();
        Prestamo prestamo = new Prestamo();
        public prestamoHerramientas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Close();    
        }

        private void prestamoHerramientas_Load(object sender, EventArgs e)
        {
            lblUser.Text = "Usuario: " + ValoresPublicos.nombreUsuario;
            herramientaaaa.mostrarNombreHerramienta(comboHerramienta);
            herramientaaaa.mostrar(dataHerramientasBaja);
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado = estaHerramienta(Convert.ToInt32(comboHerramienta.SelectedValue));
            if (comboHerramienta.SelectedIndex == -1 || maskCantidad.Text == null || txtNombre.Text == "" || resultado || 
                maskCantidad.Text == 0.ToString()) 
            {
                MessageBox.Show("Primero seleccione una herramienta e ingrese una cantidad y nombre del encargado del prestamo y " +
                    "por favor no repita herramienta");
            }
            else
            {
                herramientaaaa.verificarCantidadHerramienta(Convert.ToInt32(comboHerramienta.SelectedValue), dataHerramientasBaja, dataPrestamos,
                       int.Parse(maskCantidad.Text), txtNombre.Text);
                comboHerramienta.SelectedIndex = -1;
                txtNombre.Text = "";
                maskCantidad.Text = null;
                btnEliminar.Enabled = false;
            }
        }

        private void btnRegistrarPrestamos_Click(object sender, EventArgs e)
        {
            if (dataPrestamos.Rows.Count == 0)
            {
                MessageBox.Show("No hay prestamos a registrar");
            }
            else
            {
                prestamo.registrarPrestamosHerramienntas(dataPrestamos);
                comboHerramienta.SelectedIndex = -1;
                txtNombre.Text = "";
                maskCantidad.Text = null;
                dataPrestamos.Rows.Clear();
                btnEliminar.Enabled = false;
                herramientaaaa.mostrar(dataHerramientasBaja);
            }
        }

        private void btnMostrarPrestamos_Click(object sender, EventArgs e)
        {
            mostrarPrestamoHerramienta ventana = new mostrarPrestamoHerramienta();
            ventana.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataPrestamos.Rows.Remove(dataPrestamos.CurrentRow);
            btnEliminar.Enabled = false;
        }

        private void dataPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private bool estaHerramienta(int herramienta)
        {
            bool bandera = false;
            for (int i = 0; i < dataPrestamos.Rows.Count; i++) 
            {
                if (dataPrestamos.CurrentRow.Cells["inventarioHerramienta"].Value.ToString() == herramienta.ToString())
                {
                    bandera = true;
                    break;
                }
            }
            return bandera;
        }
    }
}
