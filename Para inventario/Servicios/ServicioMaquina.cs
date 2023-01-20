using Para_inventario.Clases;
using System;
using System.Collections.Generic;
using System.Configuration;
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


    }
}
