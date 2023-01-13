using Para_inventario.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                MessageBox.Show("No se pudo agregar el consumible exitosamente");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
