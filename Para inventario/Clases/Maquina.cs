using Para_inventario.Interfaces;
using Para_inventario.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Clases
{
    class Maquina
    {
        public int nro { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string lugar { get; set; }
        public int cantidad { get; set; }
        public Maquina() { }
        public Maquina(int nro, string nombre, string marca, string lugar, int cantidad)
        {
            this.nro = nro;
            this.nombre = nombre;
            this.marca = marca;
            this.lugar = lugar;
            this.cantidad = cantidad;
        }

        public void agregar(Maquina maquina)
        {
            ServicioMaquina servicio = new ServicioMaquina();
            servicio.agregar(maquina);
        }

        public void mostrar(DataGridView maquinas)
        {

        }

        public void eliminar(DataGridView maquinas) 
        {
            
        }

        public void actualizar(Maquina maquina)
        {

        }
    }
}
