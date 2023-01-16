using Microsoft.VisualBasic;
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
    class ServicioInformatica
    {
        private string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];

        public void agregar(Informática informatica)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Informatica (nombre, marca, lugar, cantidad, estado) VALUES " +
                    "(@nombre, @marca, @lugar, @cantidad, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", informatica.nombre);
                cmd.Parameters.AddWithValue("@marca", informatica.marca);
                cmd.Parameters.AddWithValue("@lugar", informatica.lugar);
                cmd.Parameters.AddWithValue("@cantidad", informatica.cantidad);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception) 
            {
                MessageBox.Show("Error al agregar elemento de informática");
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
                cmd.CommandText = "mostrarInformatica";
                cmd.CommandType = CommandType.StoredProcedure;
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

        public void actualizar(Informática informatica)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE Informatica SET cantidad = @c, lugar = @l WHERE nro = @n";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@c", informatica.cantidad);
                cmd.Parameters.AddWithValue("@l", informatica.lugar);
                cmd.Parameters.AddWithValue("@n", informatica.nro);
                cn.Open();
                cmd.ExecuteNonQuery();  
            }
            catch(Exception) 
            {
                MessageBox.Show("Error al actualizar el elemento de informática");
            }
            finally
            {
                cn.Close(); 
            }
        }

        public void eliminar(int nro) 
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();  
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE Informatica SET estado = 0 WHERE nro = @n";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@n", nro);
                cn.Open();
                cmd.ExecuteNonQuery();  
            }
            catch(Exception) 
            { 
                MessageBox.Show("Error al eliminar el elemento de informática seleccionado");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
