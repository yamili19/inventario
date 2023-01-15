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
            catch (Exception)
            {
                MessageBox.Show("Error al agregar herramienta");
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
                cn.Open();
                cmd.CommandText = "mostrarHerramientas";
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

        public void eliminar(int nro)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection= cn;
                cmd.CommandText = "UPDATE HerramientasManuales SET estado = 0  where nro = @nro";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro", nro);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                MessageBox.Show("Error al eliminar herramienta");    
            }
            finally
            {
                cn.Close();
            }
        }
        public void actualizar(Herramienta herramienta)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection= cn;
                cmd.CommandText = "UPDATE HerramientasManuales SET cantidad = @cantidad, lugar = @lugar WHERE nro = @nro";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@lugar", herramienta.lugar);
                cmd.Parameters.AddWithValue("@cantidad", herramienta.cantidad);
                cmd.Parameters.AddWithValue("@nro", herramienta.nro);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception) 
            {
                MessageBox.Show("Error al actualizar herramienta");    
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
