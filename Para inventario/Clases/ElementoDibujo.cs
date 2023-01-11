using Para_inventario.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Clases
{
    class ElementoDibujo
    {
        public int nro { get; set; }
        public string nombre { get; set; }
        public int cantidadDisponible { get; set; }
        public int cantidadComprada { get; set; }

        public ElementoDibujo() { }

        public ElementoDibujo(int nro, string nombre, int cantidadDisponible, int cantidadComprada)
        {
            this.nro = nro;
            this.nombre = nombre;
            this.cantidadDisponible = cantidadDisponible;
            this.cantidadComprada = cantidadComprada;
        }

        public void agregar(ElementoDibujo elementoDibujo)
        {
            ServicioElementoDibujo e = new ServicioElementoDibujo();
            e.agregar(elementoDibujo);  
        }
    }
}
