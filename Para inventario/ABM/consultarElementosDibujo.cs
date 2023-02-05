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
        ElementoDibujo elemento = new ElementoDibujo();
        public consultarElementosDibujo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Close();
        }

        private void txtNroInventario_TextChanged(object sender, EventArgs e)
        {
            elemento.consultarNroInventario(txtNroInventario, dataEDConsultar);
        }

        private void consultarElementosDibujo_Load(object sender, EventArgs e)
        {
            elemento.mostrar(dataEDConsultar);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            elemento.consultarNombre(txtNombre, dataEDConsultar);
        }
    }
}
