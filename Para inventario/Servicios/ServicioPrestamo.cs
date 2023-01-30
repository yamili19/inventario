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
    class ServicioPrestamo
    {
        private string cadenaBD = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];

        public DataTable mostrarPrestamoHerramientas()
        {
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(cadenaBD);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "mostrarPrestamoHerramienta";
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);    
            return dt;
        }

        public void registrarPrestamoHerramienta(Prestamo prestamo)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;    
            cn.Open();
            cmd.Transaction = cn.BeginTransaction();
            try
            {
                cmd.CommandText = "INSERT INTO PrestamosHerramientas (inventarioHerramienta, fechaPrestamo, cantidad, encargado)" +
                             "VALUES (@nro, @f, @c, @e)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro", prestamo.nroInventario);
                cmd.Parameters.AddWithValue("@f", prestamo.fechaPrestamo);
                cmd.Parameters.AddWithValue("@c", prestamo.cantidad);
                cmd.Parameters.AddWithValue("@e", prestamo.encargado);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE HerramientasManuales SET cantidad = cantidad - @c WHERE nro = @n";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@c", prestamo.cantidad);
                cmd.Parameters.AddWithValue("@n", prestamo.nroInventario);
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar préstamos");
                cmd.Transaction.Rollback();
            }
            finally
            {
                cn.Close();
            }
        }

        public void registrarDevolucionHerramienta(Prestamo prestamo)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cn.Open();
            cmd.Transaction = cn.BeginTransaction();
            try
            {
                cmd.CommandText = "UPDATE PrestamosHerramientas SET fechaDevolucion = GETDATE() WHERE inventarioHerramienta = @n AND fechaPrestamo = @fe";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@n", prestamo.nroInventario);
                cmd.Parameters.AddWithValue("@fe", prestamo.fechaPrestamo);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE HerramientasManuales SET cantidad = cantidad + @c WHERE nro = @n";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@c", prestamo.cantidad);
                cmd.Parameters.AddWithValue("@n", prestamo.nroInventario);
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                MessageBox.Show("Devolución registrada exitósamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cmd.Transaction.Rollback(); 
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
