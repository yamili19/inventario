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
    public partial class actualizarConsumibles : Form
    {
        public actualizarConsumibles()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void actualizarConsumibles_Load(object sender, EventArgs e)
        {
            Consumible consumible = new Consumible();
            consumible.mostrar(dataConsumiblesActualizar);
        }
    }
}
