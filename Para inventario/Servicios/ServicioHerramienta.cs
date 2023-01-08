using Para_inventario.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_inventario.Servicios
{
    class ServicioHerramienta
    {
        private string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];

        public void agregar(Herramienta herramienta)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO HerramientasManuales (nombre, marca, material, lugar, cantidad, estado) " +
                    "VALUES (@nombre, @marca, @material, @lugar, @cantidad, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", herramienta.nombre);
                cmd.Parameters.AddWithValue("@marca", herramienta.marca);
                cmd.Parameters.AddWithValue("@material", herramienta.material);
                cmd.Parameters.AddWithValue("@lugar", herramienta.lugar);
                cmd.Parameters.AddWithValue("@cantidad", herramienta.cantidad);
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
