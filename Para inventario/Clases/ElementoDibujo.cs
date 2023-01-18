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
                MessageBox.Show("Elemento de dibujo actualizado exitosamente");
            }
        }

        public void consultarNroInventario(TextBox numero, DataGridView elemento)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = elemento.DataSource;
            bool bandera = false;
            if (numero.Text != null)
            {
                bandera = true;
            }
            while (bandera)
            {
                try
                {
                    if (bs.DataSource != null)
                    {
                        int nro = int.Parse(numero.Text);
                        bs.Filter = "nro = '" + nro + "'";
                        elemento.DataSource = bs.DataSource;
                        if (elemento.RowCount == 0)
                        {
                            MessageBox.Show("No se encontró ningún elemento de dibujo con el nro de inventario ingresado");
                        }
                    }
                }
                catch (Exception)
                {
                    bandera = false;
                    mostrar(elemento);  
                }
                finally
                {
                    bandera = false;
                }
            }
        }

        public void consultarNombre(TextBox nombre, DataGridView elemento) 
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = elemento.DataSource;    
            bool bandera = false;   
            if (nombre.Text != null) 
            {
                bandera = true;
            }
            while (bandera)
            {
                try
                {
                    if (bs.DataSource != null)
                    {
                        bs.Filter = "nombre like '%"+nombre.Text+"%'";
                        elemento.DataSource = bs.DataSource;    
                        if (elemento.RowCount == 0)
                        {
                            MessageBox.Show("No se encontró ningún elemento de dibujo con el nombre ingresado");
                        }
                    }
                }
                catch
                {
                    bandera = false;
                    mostrar(elemento);
                }
                finally
                {
                    bandera = false;
                }
            }
        }
    }
}
