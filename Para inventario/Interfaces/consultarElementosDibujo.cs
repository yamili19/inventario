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
    public partial class consultarElementosDibujo : Form
    {
        public consultarElementosDibujo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void txtNroInventario_TextChanged(object sender, EventArgs e)
        {
            ElementoDibujo elemento = new ElementoDibujo();
            elemento.consultarNroInventario(txtNroInventario, dataEDConsultar);
        }

        private void consultarElementosDibujo_Load(object sender, EventArgs e)
        {
            ElementoDibujo elemento = new ElementoDibujo();
            elemento.mostrar(dataEDConsultar);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ElementoDibujo elemento = new ElementoDibujo();
            elemento.consultarNombre(txtNombre, dataEDConsultar);
        }
    }
}
