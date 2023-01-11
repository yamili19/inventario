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
    public partial class elementosDibujoAgregar : Form
    {
        public elementosDibujoAgregar()
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
            try
            {
                ElementoDibujo elementoDibujo = new ElementoDibujo();
                elementoDibujo.nombre = txtNombre.Text;
                elementoDibujo.cantidadDisponible = int.Parse(maskCantidadComprada.Text);
                elementoDibujo.cantidadComprada = int.Parse(maskCantidadComprada.Text);
                elementoDibujo.agregar(elementoDibujo);
                MessageBox.Show("Elemento de dibujo " + elementoDibujo.nombre+" "+"agregado exitosamente");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            bool bandera = false;
            if (maskCantidadComprada.Text != null)
            {
                bandera = true;
            }
            while (bandera == true)
            {
                try
                {
                    if (int.Parse(maskCantidadComprada.Text) > 0)
                    {
                        btnAgregar.Enabled = true;
                        checkCantidad.Checked = true;
                    }
                    else
                    {
                        checkCantidad.Checked = false;
                        checkCantidad.Text = "Debe ingresar una cantidad mayor que 0";
                    }
                }
                catch (Exception)
                { 
                    bandera = false;
                    btnAgregar.Enabled = false;
                }
                finally
                {
                    bandera = false;
                }
            }
        }

        private void elementosDibujoAgregar_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            checkCantidad.Enabled = false;  
        }
    }
}
