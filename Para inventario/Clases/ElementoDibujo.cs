using Para_inventario.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public void mostrar(DataGridView elementosDibujo)
        {
            ServicioElementoDibujo elementoDibujo = new ServicioElementoDibujo();
            elementosDibujo.DataSource = elementoDibujo.mostrar();
        }

        public void eliminar(DataGridView elemento)
        {
            int nro = int.Parse(elemento.CurrentRow.Cells["nro"].Value.ToString());
            DialogResult dialogo = MessageBox.Show("¿Desea eliminar el elemento de dibujo con nro de inventario " + nro.ToString() + "?",
                "Información", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes) 
            {
                ServicioElementoDibujo ele = new ServicioElementoDibujo();
                ele.eliminar(nro);
                MessageBox.Show("Elemento de dibujo eliminado exitosamente");
                mostrar(elemento);
            }
        }

        public void actualizar(DataGridView elementosDibujo)
        {
            int nro = int.Parse(elementosDibujo.CurrentRow.Cells["nro"].Value.ToString());
            DialogResult dialogo = MessageBox.Show("Confirme actualización del elemento de dibujo con nro de inventario "+nro.ToString(), "Información",
                MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes) 
            {
                ServicioElementoDibujo servicio = new ServicioElementoDibujo();
                this.nro = nro;
                this.cantidadComprada = int.Parse(elementosDibujo.CurrentRow.Cells["cantidadComprada"].Value.ToString());
                servicio.actualizar(this);
                mostrar(elementosDibujo);
                MessageBox.Show("Elemento de dibujo actualizado exitosamente");
            }
        }
    }
}
