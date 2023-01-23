using Para_inventario.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Clases
{
    class Mueble
    {
        public int nro { get; set; }
        public string nombre { get; set; }
        public string material { get; set; }    
        public int cantidad { get; set; }
        public string lugar { get; set; }
        public string adquirido { get; set; }
        public Mueble() { }
        public Mueble(int nro, string nombre, string material, int cantidad, string lugar, string adquirido)
        {
            this.nro = nro;
            this.nombre = nombre;
            this.material = material;
            this.cantidad = cantidad;
            this.lugar = lugar;
            this.adquirido = adquirido;
        }

        public void agregar(Mueble mueble)
        {
            ServicioMueble servicio = new ServicioMueble();
            servicio.agregar(mueble);
        }

        public void mostrar(DataGridView muebles)
        {
            ServicioMueble servicio = new ServicioMueble();
            muebles.DataSource = servicio.mostrar();
        }

        public void eliminar(DataGridView muebles)
        {
            DialogResult resultado = MessageBox.Show("¿Desea eliminar el mueble con nro de inventario "
                + muebles.CurrentRow.Cells["nro"].Value.ToString() + "?", "Información", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes) 
            {
                ServicioMueble servicio = new ServicioMueble();
                servicio.eliminar(int.Parse(muebles.CurrentRow.Cells["nro"].Value.ToString()));
                MessageBox.Show("Mueble eliminado exitósamente");
            }
        }
    }
}
