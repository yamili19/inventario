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

        public void actualizar(DataGridView con)
        {
            int nro = int.Parse(con.CurrentRow.Cells["nro"].Value.ToString());
           DialogResult resultado = MessageBox.Show("Confirme la actualización del Consumible con el nro de inventario "+nro.ToString(),
                "Información", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes) 
            {
                ServicioConsumible servicio = new ServicioConsumible();
                this.nro = nro;
                this.cantidadComprada = int.Parse(con.CurrentRow.Cells["cantidadComprada"].Value.ToString());
                servicio.actualizar(this);
                MessageBox.Show("Consumible actualizado exitosamente");
                mostrar(con);
            }
        }

        public void consultarNroInventario(TextBox numero, DataGridView dataConsumible)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataConsumible.DataSource;
            bool bandera = false;
            if (numero.Text != null) 
            {
                bandera = true;
            }
            if (bandera)
            {
                try
                {
                    if (bs.DataSource!= null) 
                    {
                        int nro = int.Parse(numero.Text);
                        bs.Filter = "nro = '"+nro+"'";
                        dataConsumible.DataSource = bs.DataSource;
                        if (dataConsumible.RowCount == 0)
                        {
                            MessageBox.Show("No se encontró ningún consumible con el nro de inventario ingresado");
                        }
                    }
                }
                catch (Exception)
                {
                    bandera = false;
                    mostrar(dataConsumible);
                }
                finally
                {
                    bandera = false;
                }
            }
        }

        public void consultarNombre(TextBox nombre , DataGridView dataConsumible) 
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataConsumible.DataSource;
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
                        dataConsumible.DataSource = bs.DataSource;
                        if (dataConsumible.RowCount == 0)
                        {
                            MessageBox.Show("No se encontró ningún consumible con el nombre ingresado");
                        }
                    }
                }
                catch (Exception)
                {
                    bandera = false;
                    mostrar(dataConsumible);
                }
                finally
                {
                    bandera = false;
                }
            }
        }
    }
}
