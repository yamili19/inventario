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
    public partial class consultarInformatica : Form
    {
        Informática informatica = new Informática();
        public consultarInformatica()
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
            informatica.consultarNroInventario(txtNroInventario, dataInformaticaConsultar);
        }

        private void consultarInformatica_Load(object sender, EventArgs e)
        {
            informatica.mostrar(dataInformaticaConsultar);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            informatica.consultarNombre(txtNombre, dataInformaticaConsultar);
        }
    }
}
