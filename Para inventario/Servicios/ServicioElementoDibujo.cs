using Para_inventario.Clases;
using System;
using System.Collections.Generic;
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
    }
}
