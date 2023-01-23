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
            DataGridView m = maquinas;
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
                        m.Refresh();
                        MessageBox.Show("No se encontró ninguna máquina con el nro de inventario ingresado");
                    }
                }
                catch (Exception)
                {
                    bandera = false;
                    m.Refresh();
                }
                finally
                {
                    bandera = false;
                }
            }
        }

        public void consultarNombre(TextBox nombre, DataGridView maquinas)
        {
            DataGridView m = maquinas;
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
                m.Refresh();
            }
        }
    }
}
