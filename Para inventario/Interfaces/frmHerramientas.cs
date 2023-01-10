using Para_inventario.Clases;
using Para_inventario.Interfaces;
using Para_inventario.Servicios;

namespace Para_inventario
{
    public partial class frmHerramientas : Form
    {
        bool bandera = false;
        public frmHerramientas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();  
            ventana.Show();
            this.Hide();
        }

        private void frmHerramientas_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            checkCantidad.Enabled = false;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskCantidad.Text != null)
            {
                bandera = true;
            }
            while (bandera == true)
            {
                try
                {
                    if (Convert.ToInt32(maskCantidad.Text) > 0)
                    {
                        checkCantidad.Checked = true;
                        btnAgregar.Enabled = true;
                    }
                    else
                    {
                        btnAgregar.Enabled = false;
                        checkCantidad.Checked = false;
                        checkCantidad.Text = "Error, debe ingresar un numero mayor que 0";
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Herramienta herramienta = new Herramienta();
                herramienta.cantidad = Convert.ToInt32(maskCantidad.Text);
                herramienta.material = txtMaterial.Text;
                herramienta.lugar = txtLugar.Text;
                herramienta.marca = txtMarca.Text;
                herramienta.nombre = txtNombre.Text;
                herramienta.agregarHerramienta(herramienta);
                MessageBox.Show("Herramienta"+" "+herramienta.nombre+" "+herramienta.marca+" "+"agregada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}