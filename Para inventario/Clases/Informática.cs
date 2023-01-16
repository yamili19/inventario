using Para_inventario.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Clases
{
    class Informática
    {
        public int nro { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string lugar { get; set; }
        public int cantidad { get; set; }

        public Informática() { }

        public Informática(int nro, string nombre, string marca, string lugar, int cantidad)
        {
            this.nro = nro;
            this.nombre = nombre;
            this.marca = marca;
            this.lugar = lugar;
            this.cantidad = cantidad;
        }

        public void agregar(Informática informatica)
        {
            ServicioInformatica servicio = new ServicioInformatica();
            servicio.agregar(informatica);
            MessageBox.Show("Elemento de informática agregado exitósamente");
        }

        public void mostrar(DataGridView dataInformatica)
        {
            ServicioInformatica servicio = new ServicioInformatica();
            dataInformatica.DataSource = servicio.mostrar();
        }

        public void eliminar(DataGridView dataInformatica)
        {
            DialogResult resultado = MessageBox.Show("¿Desea eliminar el elemento de informática con nro de inventario "
                + dataInformatica.CurrentRow.Cells["nro"].Value.ToString() + "?", "Información", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes) 
            {
                ServicioInformatica servicio = new ServicioInformatica();
                servicio.eliminar(int.Parse(dataInformatica.CurrentRow.Cells["nro"].Value.ToString()));
                MessageBox.Show("Elemento de informática eliminado exitósamente");
                mostrar(dataInformatica);
            }
        }

        public void actualizar(DataGridView dataInformatica)
        {
            DialogResult resultado = MessageBox.Show("Confirme actualización del elemento de informática con nro de inventario "
                + dataInformatica.CurrentRow.Cells["nro"].Value.ToString(), "Información", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes) 
            {
                ServicioInformatica servicio = new ServicioInformatica();
                this.nro = int.Parse(dataInformatica.CurrentRow.Cells["nro"].Value.ToString());
                this.cantidad = int.Parse(dataInformatica.CurrentRow.Cells["nro"].Value.ToString());
                this.lugar = dataInformatica.CurrentRow.Cells["nro"].Value.ToString();
                servicio.actualizar(this);
                MessageBox.Show("Elemento de informática actualizado exitosamente");
                mostrar(dataInformatica);   
            }
        }

        public void consultarNroInventario(TextBox numero, DataGridView dataInformatica)
        {

        }

        public void consultarNombre(TextBox nombre, DataGridView dataInformatica) 
        {
            
        }
    }
}
