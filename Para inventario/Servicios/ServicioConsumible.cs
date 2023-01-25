using Para_inventario.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Servicios
{
    class ServicioConsumible
    {
        private string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];

        public void agregar(Consumible consumible)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection= cn;
                cmd.CommandText = "INSERT INTO Consumibles (nombre, cantidadComprada, cantidadDisponible) " +
                    "VALUES (@nombre, @cantidadComprada, @cantidadDisponible)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", consumible.nombre);
                cmd.Parameters.AddWithValue("@cantidadComprada", consumible.cantidadComprada);
                cmd.Parameters.AddWithValue("@cantidadDisponible", consumible.cantidadDisponible);
                cn.Open();  
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar el consumible");
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable mostrar()
        {
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "mostrarConsumibles";
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);    
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                cn.Close();
            }
            return dt;
        }

        public void actualizar(Consumible consumible)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE Consumibles SET cantidadComprada = @cantidadComprada WHERE nro = @nro";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro", consumible.nro);
                cmd.Parameters.AddWithValue("@cantidadComprada", consumible.cantidadComprada);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) 
            {
                MessageBox.Show("Error en la actualización del consumible");
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable mostrarNombreConsumible()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaBD);
            cmd.Connection = cn;
            cmd.CommandText = "SELECT nro, nombre FROM Consumibles";
            cn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            cn.Close();
            return dt;
        }

        public void agregarConsumos(DataGridView consumos)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            SqlCommand cmd = new SqlCommand();
            cn.Open();
            cmd.Connection = cn;
            cmd.Transaction = cn.BeginTransaction();
            try
            {
                for (int i = 0; i<consumos.Rows.Count; i++) 
                {
                    cmd.CommandText = "INSERT INTO Consumos VALUES (@n, @c, @f)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@n", int.Parse(consumos.Rows[i].Cells["nro_inventario"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@c", int.Parse(consumos.Rows[i].Cells["cantidad"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@f", Convert.ToDateTime(consumos.Rows[i].Cells["fecha"].Value.ToString()));
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "UPDATE Consumibles set cantidadDisponible = cantidadDisponible - @c where nro = @n";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@c", int.Parse(consumos.Rows[i].Cells["cantidad"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@n", int.Parse(consumos.Rows[i].Cells["nro_inventario"].Value.ToString()));
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();
                MessageBox.Show("Consumo registrado exitósamente");
            }
            catch (Exception ex)
            {
                cmd.Transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable mostrarConsumos()
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            DataTable dt = new DataTable();
            cmd.CommandText = "mostrarConsumos";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            cn.Open();  
            ad.Fill(dt);
            cn.Close();
            return dt;
        }
    }
}
