using Para_inventario.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Clases
{
    class Prestamo
    {
        public int nroInventario { get; set; } 
        public DateTime fechaPrestamo { get; set; }
        public DateTime fechaDevolucion { get; set; }
        public int cantidad { get; set; }
        public string encargado { get; set; }

        public Prestamo() { }
        public Prestamo(int nroInventario, DateTime fechaPrestamo, DateTime fechaDevolucion, int cantidad, string encargado)
        {
            this.nroInventario = nroInventario;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaDevolucion = fechaDevolucion;
            this.cantidad = cantidad;
            this.encargado = encargado;
        }

        public void mostrarPrestamoHerramienta(DataGridView prestamos)
        {
            ServicioPrestamo servicio = new ServicioPrestamo();
            prestamos.DataSource = servicio.mostrarPrestamoHerramientas();
        }

        public void registrarPrestamosHerramienntas(DataGridView prestamos)
        {
            ServicioPrestamo servicio = new ServicioPrestamo();
            for (int i = 0; i < prestamos.Rows.Count; i++) 
            {
                this.nroInventario = int.Parse(prestamos.CurrentRow.Cells["inventarioHerramienta"].Value.ToString());
                this.cantidad = int.Parse(prestamos.CurrentRow.Cells["cantidadDisponible"].Value.ToString());
                this.fechaPrestamo = Convert.ToDateTime(prestamos.CurrentRow.Cells["fechaPrestamo"].Value.ToString());
                this.encargado = prestamos.CurrentRow.Cells["encargado"].Value.ToString();
                servicio.registrarPrestamoHerramienta(this);
            }
            MessageBox.Show("Prestamos registrados exitósamente");
        }

        public void registrarDevHerramienta(Prestamo prestamo)
        {
            ServicioPrestamo servicio = new ServicioPrestamo();
            servicio.registrarDevolucionHerramienta(prestamo);
        }
    }
}
