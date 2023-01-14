using Para_inventario.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Clases
{
    class Consumible
    {
        public int nro { get; set; }    
        public string nombre { get; set; }
        public int cantidadDisponible { get; set; } 
        public int cantidadComprada { get; set; }

        public Consumible() { } 

        public Consumible(int nro, string nombre, int cantidadDisponible, int cantidadComprada)
        {
            this.nro = nro;
            this.nombre = nombre;
            this.cantidadDisponible = cantidadDisponible;
            this.cantidadComprada = cantidadComprada;
        }

        public void agregar(Consumible consumible)
        {
            ServicioConsumible servicio = new ServicioConsumible();
            servicio.agregar(consumible);
            MessageBox.Show("Consumible agregado exitosamente");
        }

        public void mostrar(DataGridView con)
        {
            ServicioConsumible consumible = new ServicioConsumible();
            con.DataSource = consumible.mostrar();
        }
    }
}
