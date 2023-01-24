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
                dataInformatica.Rows.Remove(dataInformatica.CurrentRow);
                dataInformatica.Refresh();
            }
        }

        public void actualizar(Informática informatica)
        {
            ServicioInformatica servicio = new ServicioInformatica();
            DialogResult resultado = MessageBox.Show("Confirme actualizacion el elemento de informática con nro de inventario " + informatica.nro,
                "Información", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes) 
            {
                servicio.actualizar(informatica);
                MessageBox.Show("Elemento de informática actualizado exitósamente");
            }
        }

        public void consultarNroInventario(TextBox numero, DataGridView dataInformatica)
        {
            BindingSource bs = new BindingSource(); 
            bs.DataSource = dataInformatica.DataSource;
            bool bandera = false;
            if (numero.Text != null)
            {
                bandera = true; 
            }
            if (bandera)
            {
                try
                {
                    if (bs.DataSource != null)
                    {
                        bs.Filter = "nro = '" + int.Parse(numero.Text) + "'";
                        dataInformatica.DataSource = bs.DataSource;
                        if (dataInformatica.RowCount == 0)
                        {
                            MessageBox.Show("No se encontró ningún elemento de informática con el nro de inventario ingresado");
                        }
                    }
                }
                catch (Exception) 
                {
                    bandera = false;
                    dataInformatica.Refresh();
                }
                finally
                {
                    bandera = false;
                }
            }
        }

        public void consultarNombre(TextBox nombre, DataGridView dataInformatica) 
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataInformatica.DataSource;
            bool bandera = false;
            if (nombre.Text != null) 
            {
                bandera = true;
            }
            if (bandera)
            {
                try
                {
                    if (bs.DataSource != null)
                    {
                        bs.Filter = "nombre like '%"+nombre.Text+"%'";
                        dataInformatica.DataSource = bs.DataSource;
                        if (dataInformatica.RowCount == 0)
                        {
                            MessageBox.Show("No se encontró ningún elemento de informática con el nombre ingresado");
                        }
                    }
                }
                catch (Exception)
                {
                    bandera = false;
                    dataInformatica.Refresh();
                }
                finally
                {
                    bandera = false;
                }
            }
        }
    }
}
