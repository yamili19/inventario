using Para_inventario.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Servicios
{
    class ServicioElementoDibujo
    {
        private string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];

        public void agregar(ElementoDibujo elementoDibujo)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO ElementosDibujo (nombre, cantidadDisponible, cantidadComprada, estado) " +
                    "VALUES (@nombre, @cantidadDisponible, @cantidadComprada, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", elementoDibujo.nombre);
                cmd.Parameters.AddWithValue("@cantidadDisponible", elementoDibujo.cantidadDisponible);
                cmd.Parameters.AddWithValue("@cantidadComprada", elementoDibujo.cantidadComprada);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);    
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable mostrar()
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "mostrarElementosDibujo";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);   
                cn.Open();
                ad.Fill(dataTable);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return dataTable;
        }

        public void eliminar(int nro)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE ElementosDibujo SET estado = 0 where nro = @nro";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro", nro);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void actualizar(ElementoDibujo elemento)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE ElementosDibujo SET cantidadComprada = @cant WHERE nro = @nro";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cant", elemento.cantidadComprada);
                cmd.Parameters.AddWithValue("@nro", elemento.nro);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
