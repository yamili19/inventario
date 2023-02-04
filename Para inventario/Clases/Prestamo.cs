using Para_inventario.Servicios;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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

        public void registrarPrestamoED(DataGridView prestamos)
        {
            ServicioPrestamo servicio = new ServicioPrestamo();
            for (int i = 0; i < prestamos.Rows.Count; i++) 
            {
                this.nroInventario = int.Parse(prestamos.CurrentRow.Cells["inventarioElementosDibujo"].Value.ToString());
                this.cantidad = int.Parse(prestamos.CurrentRow.Cells["cant"].Value.ToString());
                this.encargado = prestamos.CurrentRow.Cells["encargado"].Value.ToString();
                this.fechaPrestamo = Convert.ToDateTime(prestamos.CurrentRow.Cells["fechaPrestamo"].Value.ToString());
                servicio.registrarPrestamoED(this);
            }
            MessageBox.Show("Prestamos registrados exitósamente");
        }

        public void mostrarPrestmosED(DataGridView prestamos)
        {
            ServicioPrestamo servicio = new ServicioPrestamo();
            prestamos.DataSource = servicio.mostrarPrestamosED();
        }

        public void registrarDevED(Prestamo prestamo)
        {
            ServicioPrestamo servicio = new ServicioPrestamo();
            servicio.registrarDevED(prestamo);
        }

        public void registrarPrestamoMaquina(DataGridView prestamos)
        {
            ServicioPrestamo servicio = new ServicioPrestamo();
            for (int i = 0; i < prestamos.Rows.Count; i++) 
            {
                this.nroInventario = int.Parse(prestamos.CurrentRow.Cells["inventarioMaquinas"].Value.ToString());
                this.cantidad = int.Parse(prestamos.CurrentRow.Cells["cant"].Value.ToString());
                this.encargado = prestamos.CurrentRow.Cells["encargado"].Value.ToString();
                this.fechaPrestamo = Convert.ToDateTime(prestamos.CurrentRow.Cells["fechaPrestamo"].Value.ToString());
                servicio.registrarPrestamoMaquina(this);
            }
            MessageBox.Show("Prestamos registrados exitósamente");
        }

        public void mostrarPrestamosMaquinas(DataGridView prestamos)
        {
            ServicioPrestamo servicio = new ServicioPrestamo();
            prestamos.DataSource = servicio.mostrarPrestamosMaquinas();
        }

        public void registrarDevMaquina(Prestamo prestamo)
        {
            ServicioPrestamo servicio = new ServicioPrestamo();
            servicio.registrarDevMaquina(prestamo);
        }

        public void buscarPorEncargado(string nombre, DataGridView prestamos)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = prestamos.DataSource;
            try
            {
                bs.Filter = "encargado like '%" + nombre + "%'";
                prestamos.DataSource = bs;
                if (prestamos.RowCount == 0)
                {
                    MessageBox.Show("No se encontró el encargado que está buscando");
                }
            }
            catch (Exception)
            {
                prestamos.Refresh();    
            }
        }
    }
}
