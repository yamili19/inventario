using Para_inventario.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Clases
{
    class Herramienta
    {
        public int nro { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string material { get; set; }
        public string lugar { get; set; }
        public int cantidad { get; set; }

        public Herramienta() { }

        public Herramienta (int nro, string nombre, string marca, string material, string lugar, int cantidad)
        {
            this.nro = nro;
            this.nombre = nombre;
            this.marca = marca;
            this.material = material;
            this.lugar = lugar;
            this.cantidad = cantidad;
        }

        public void agregarHerramienta(Herramienta herramienta) 
        {
            ServicioHerramienta h = new ServicioHerramienta();
            h.agregar(herramienta);
        }

        public void mostrar(DataGridView herramienta)
        {
            ServicioHerramienta h = new ServicioHerramienta();
            herramienta.DataSource = h.mostrar();   
        }

        public void eliminar(DataGridView herramienta)
        {
            int nro = Convert.ToInt32(herramienta.CurrentRow.Cells["nro"].Value.ToString());
            ServicioHerramienta h = new ServicioHerramienta();
            DialogResult resultado = MessageBox.Show("¿Desea eliminar la herramienta con el nro de inventario " + nro.ToString()+"?", "Información",
                MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                h.eliminar(nro);
                MessageBox.Show("Herramienta eliminada correctamente");
                mostrar(herramienta);
            }
        }

        

        public void actualizar(Herramienta herramienta) 
        {
            ServicioHerramienta h = new ServicioHerramienta();
            DialogResult resultado = MessageBox.Show("Confirme actualizacion de la herramienta con nro de inventario " + herramienta.nro + "?", "Información",
                MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                h.actualizar(herramienta);
                MessageBox.Show("Herramienta actualizada correctamente");
            }
        }

        public void buscarNroInventario(TextBox numero, DataGridView herramienta)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = herramienta.DataSource;
            bool bandera = false;
            if (numero.Text != null)
            {
                bandera= true;
            }
            while (bandera == true)
            {
                try
                {
                    if (bs.DataSource != null)
                    {
                        int nro = int.Parse(numero.Text);
                        bs.Filter = "nro = '" + nro + "'";
                        herramienta.DataSource = bs.DataSource;
                        if (herramienta.RowCount == 0)
                        {
                            MessageBox.Show("No se encontró ninguna herramienta con el numero de inventario ingresado");
                        }
                    }
                }
                catch (Exception)
                {
                    mostrar(herramienta);
                    bandera = false;
                }
                finally
                {
                    bandera = false;
                }
            }
        }

        public void buscarNombreHerramienta(string nombre, DataGridView herramienta)
        {
            BindingSource bindingSource= new BindingSource();
            bindingSource.DataSource = herramienta.DataSource;
            try
            {
                bindingSource.Filter = "nombre like '%" + nombre + "%'";
                herramienta.DataSource = bindingSource.DataSource;  
                if (herramienta.RowCount == 0)
                {
                    MessageBox.Show("No se encontró ninguna herramienta con el nombre ingresado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
