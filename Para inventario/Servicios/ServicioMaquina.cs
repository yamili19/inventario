using Para_inventario.Clases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Servicios
{
    class ServicioMaquina
    {
        private string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];

        public void agregar(Maquina maquina)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection= cn;
                cmd.CommandText = "INSERT INTO Maquinas (nombre, marca, lugar, cantidad, estado) VALUES (@n, @m, @l, @c, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@n", maquina.nombre);
                cmd.Parameters.AddWithValue("@m", maquina.marca);
                cmd.Parameters.AddWithValue("@l", maquina.lugar);
                cmd.Parameters.AddWithValue("@c", maquina.cantidad);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) 
            {
                MessageBox.Show("Error al agregar máquina");
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable mostrar()
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            DataTable dt = new DataTable(); 
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "mostrarMaquinas";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                cn.Open();
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

        public void eliminar(int nro)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE Maquinas SET estado = 0 WHERE nro = @n";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@n", nro);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception) 
            { 
                MessageBox.Show("Error al eliminar máquina");
            }
            finally
            {
                cn.Close();
            }
        }

        public void actualizar(Maquina maquina)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE Maquinas SET lugar = @l, cantidad = @c WHERE nro = @n";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@l", maquina.lugar);
                cmd.Parameters.AddWithValue("@c", maquina.cantidad);
                cmd.Parameters.AddWithValue("@n", maquina.nro);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar máquina");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
