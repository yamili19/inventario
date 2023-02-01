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
            ServicioMaquina servicio = new ServicioMaquina();
            maquinas.DataSource = servicio.mostrar();
        }

        public void eliminar(DataGridView maquinas) 
        {
            int nro = int.Parse(maquinas.CurrentRow.Cells["nro"].Value.ToString());
            DialogResult resultado = MessageBox.Show("Desea eliminar la máquina con el nro de inventario "
                + nro.ToString() + "?", "Información", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes) 
            {
                ServicioMaquina servicio = new ServicioMaquina();
                servicio.eliminar(nro);
                maquinas.Rows.Remove(maquinas.CurrentRow);
                maquinas.Refresh();
                MessageBox.Show("Máquina eliminada exitósamente");
            }
        }

        public void actualizar(Maquina maquina)
        {
            DialogResult resultado = MessageBox.Show("Confirme actualización de máquina con nro de inventario " + maquina.nro,
                "Información", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes) 
            {
                ServicioMaquina servicio = new ServicioMaquina();
                servicio.actualizar(maquina);
                MessageBox.Show("Máquina actualizada exitósamente");
            }
        }

        public void consultarNroInventario(TextBox nro ,DataGridView maquinas)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = maquinas.DataSource;
            bool bandera = false;
            if (nro.Text != null)
            {
                bandera = true;
            }
            if (bandera)
            {
                try
                {
                    bs.Filter = "nro = '" + int.Parse(nro.Text) + "'";
                    maquinas.DataSource = bs.DataSource;
                    if (maquinas.RowCount == 0)
                    {
                        MessageBox.Show("No se encontró ninguna máquina con el nro de inventario ingresado");
                    }
                }
                catch (Exception)
                {
                    bandera = false;
                    maquinas.Refresh();
                }
                finally
                {
                    bandera = false;
                }
            }
        }

        public void consultarNombre(TextBox nombre, DataGridView maquinas)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = maquinas.DataSource;
            try
            {
                bs.Filter = "nombre like '%" + nombre.Text + "%'";
                maquinas.DataSource = bs.DataSource;
                if (maquinas.RowCount == 0)
                {
                    MessageBox.Show("No se encontró ninguna máquina con el nombre ingresado");
                }
            }
            catch (Exception)
            {
                maquinas.Refresh();
            }
        }

        public void mostrarNombreMaquina(ComboBox maquina)
        {
            ServicioMaquina  servicio = new ServicioMaquina();
            maquina.DataSource = servicio.mostrar();
            maquina.ValueMember = "nro";
            maquina.DisplayMember = "nombre";
            maquina.SelectedIndex = -1;
        }

        public void verificarCantidadMaquina(int nro, int cant, DataGridView maquinas, DataGridView prestamos, string nombre)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = maquinas.DataSource;
            try
            {
                bs.Filter = "nro = '"+nro+"'";
                maquinas.DataSource = bs.DataSource;
                int cantidad = int.Parse(maquinas.CurrentRow.Cells["cantidad"].Value.ToString());
                if (cant <= cantidad)
                {
                    prestamos.Rows.Add(nro.ToString(), maquinas.CurrentRow.Cells["nombre"].Value.ToString(),
                        cant.ToString(), DateTime.Now.ToString(), null, nombre);
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad menor o igual a la cantidad disponible de la máquina seleccionada que es: "
                        +cantidad.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
