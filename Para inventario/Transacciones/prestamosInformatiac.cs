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
    public partial class prestamosInformatica : Form
    {
        Prestamo prestamo = new Prestamo();
        Informática informatica = new Informática();
        public prestamosInformatica()
        {
            InitializeComponent();
        }

        private void prestamosInformatica_Load(object sender, EventArgs e)
        {
            informatica.mostrar(dataInformaticaEliminar);
            lblUser.Text = "Usuario: " + ValoresPublicos.nombreUsuario;
            informatica.mostrarNombre(comboInformatica);
            btnEliminar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool resultado = estaInformatica(Convert.ToInt32(comboInformatica.SelectedValue));
            if (txtNombre.Text == "" || comboInformatica.SelectedIndex == -1 || maskCantidad.Text == null || resultado)
            {
                MessageBox.Show("Primero seleccione un elemento de informática e ingrese una cantidad y nombre del solicitante del prestamo" +
                    " y por favor no repita el elemento de informática");
            }
            else
            {
                informatica.verificarCantidad(Convert.ToInt32(comboInformatica.SelectedValue), int.Parse(maskCantidad.Text), dataInformaticaEliminar,
                    dataPrestamos, txtNombre.Text);
                comboInformatica.SelectedIndex = -1;
                txtNombre.Text = "";
                maskCantidad.Text = null;
            }
        }
        
        private bool estaInformatica(int nro)
        {
            bool bandera = false;
            for (int i = 0; i < dataPrestamos.Rows.Count; i++)
            {
                if (dataPrestamos.CurrentRow.Cells["inventarioInformatica"].Value.ToString() == nro.ToString())
                {
                    bandera = true;
                    break;
                }
            }
            return bandera;
        }

        private void dataPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
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
                prestamo.registrarPrestInformatica(dataPrestamos);
                dataPrestamos.Rows.Clear();
                btnEliminar.Enabled = false;
                txtNombre.Text = "";
                maskCantidad.Text = null;
                comboInformatica.SelectedIndex = -1;
                informatica.mostrar(dataInformaticaEliminar);
            }
        }

        private void btnMostrarPrestamos_Click(object sender, EventArgs e)
        {
            mostrarPrestamosInformatica ventana = new mostrarPrestamosInformatica();
            ventana.Show();
            this.Close();
        }
    }
}
