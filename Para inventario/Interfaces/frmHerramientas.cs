using Para_inventario.Interfaces;

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
                catch (Exception ex)
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
    }
}