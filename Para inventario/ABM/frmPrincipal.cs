using Para_inventario.Transacciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Para_inventario.ABM;
using Para_inventario.Clases;

namespace Para_inventario.Interfaces
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //private void agregarHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHerramientas ventana = new frmHerramientas();
            ventana.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHerramientaBaja ventana = new frmHerramientaBaja();
            ventana.Show();
            this.Hide();    
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHerramientasActualizacion ventana = new frmHerramientasActualizacion();
            ventana.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHerramientasConsultar ventana = new frmHerramientasConsultar();
            ventana.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            elementosDibujoAgregar ventana = new elementosDibujoAgregar();
            ventana.Show(); 
            this.Hide();    
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultarElementosDibujo ventana = new consultarElementosDibujo();
            ventana.Show(); 
            this.Hide();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            eliminarElementosDibujo ventana = new eliminarElementosDibujo();
            ventana.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            agregarConsumible ventana = new agregarConsumible();
            ventana.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            consultarConsumibles ventana = new consultarConsumibles();
            ventana.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            agregarInformatica ventana = new agregarInformatica();
            ventana.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            consultarInformatica ventana = new consultarInformatica();
            ventana.Show();
            this.Hide();
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            actualizarInformatica ventana = new actualizarInformatica();
            ventana.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            eliminarInformatica ventana = new eliminarInformatica();
            ventana.Show();
            this.Hide();    
        }

        private void agregarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            agregarMaquinas ventana = new agregarMaquinas();
            ventana.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            eliminarMaquina ventana = new eliminarMaquina();
            ventana.Show();
            this.Hide();
        }

        private void actualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            actualizarMaquina ventana = new actualizarMaquina();
            ventana.Show(); 
            this.Hide();
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            consultarMaquina ventana = new consultarMaquina();
            ventana.Show();
            this.Hide();    
        }

        private void agregarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            agregarMueble ventana = new agregarMueble();
            ventana.Show();
            this.Hide();
        }

        private void eliminarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            eliminarMueble ventana = new eliminarMueble();
            ventana.Show();
            this.Hide();
        }

        private void actualizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            actualizarMueble ventana = new actualizarMueble();
            ventana.Show();
            this.Hide();    
        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            consultarMueble ventana = new consultarMueble();
            ventana.Show();
            this.Hide();
        }

        private void registrarConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consumos ventana = new Consumos();
            ventana.Show();
            this.Hide();
        }


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Consumible consumible = new Consumible();
            consumible.mostrar(dataConsumiblesConsultar);
            mostrarPorcentajeStock();
        }

        private void registrarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prestamoHerramientas ventana = new prestamoHerramientas();
            ventana.Show();
            this.Hide();
        }

        private void registrarPrestamoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            prestamoED ventana = new prestamoED();
            ventana.Show();
            this.Hide();
        }

        private void registrarPrestamoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            prestamoMaquina ventana = new prestamoMaquina();
            ventana.Show();
            this.Hide();
        }

        private void reponerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reponerConsumibles ventana = new reponerConsumibles();
            ventana.Show(); 
            this.Hide();
        }

        private void mostrarPorcentajeStock()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < dataConsumiblesConsultar.Rows.Count; i++)
            {
                string nombre = dataConsumiblesConsultar.Rows[i].Cells["nombre"].Value.ToString();
                int stock = int.Parse(dataConsumiblesConsultar.Rows[i].Cells["cantidadDisponible"].Value.ToString());
                int cantidad = int.Parse(dataConsumiblesConsultar.Rows[i].Cells["cantidadComprada"].Value.ToString());
                if (stock >= cantidad)
                {
                    list.Add("Consumible: " + nombre + " Porcentaje de Stock: " + "100%\n");
                }
                else
                {
                    double porcentaje = stock * 100 / cantidad;
                    list.Add("Consumible: " + nombre + " Porcentaje de Stock: " + porcentaje.ToString() + "%\n");
                }
            }
            Label lab = new Label();
            string textoAnterior = "";
            for (int i = 0; i < list.Count; i++)
            {
                lab.Text = textoAnterior + list[i].ToString();
                textoAnterior = lab.Text;
            }
            MessageBox.Show(lab.Text, "Información sobre el stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
