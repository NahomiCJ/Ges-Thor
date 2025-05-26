using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GesThor
{
    class Operacion
    {
        private string conexion = "Data Source = localhost\\SQLEXPRESS;Initial Catalog = GesThor;Integrated Security=True;";

        #region Visualizar

        public DataTable Cargar()
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from vwInventario with(nolock)", con);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                dt.Load(reader);
            }
            con.Close();
            return dt;
        }
        #endregion Visualizar

        public string AgregarEquipo(string Nombre, int Cantidad, string Estado, bool Disponibilidad)
        {
            int dis = Disponibilidad == true ? 1 : 0;
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("spi_AgEquipo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@Disponibilidad", dis);

                cmd.ExecuteNonQuery();

                con.Close();

                return "Agregado";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string ModificarEquipo(int Id, string Nombre, int Cantidad, string Estado, bool Disponibilidad)
        {
            int dis = Disponibilidad == true ? 1 : 0;
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("spu_ModEquipo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@Disponibilidad", dis);

                cmd.ExecuteNonQuery();

                con.Close();

                return "Modificado";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string AgregarPrestamo(int Id_U, int Id_E, DateTime Dev, string Status)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("spiAgPrestamo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_U", Id_U);
                cmd.Parameters.AddWithValue("@Id_E", Id_E);
                cmd.Parameters.AddWithValue("@Fecha_Dev", Dev);
                cmd.Parameters.AddWithValue("@Status_Prestamo", Status);

                cmd.ExecuteNonQuery();

                con.Close();

                return null;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string ConsultaUsuario(string Mat)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sprConsultarIdUsuario", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Matricula", Mat);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader["Id_Usuario"].ToString(); // Retorna el ID como string
                            }
                        }
                    }
                }

                return null; // Si no se encuentra el usuario
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable BuscarPrestamosPorMatricula(string mat)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("ObtenerPrestamosPorMatricula", conn);
                    cmd.CommandType = CommandType.StoredProcedure;  //Llamado del StoredProcedure 


                    cmd.Parameters.AddWithValue("@Matricula", mat); //Parametro de Matricula o Clave

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();  //Adaptacion de la tabla en el DataGridView
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception)
                {
                    return null;
                    //MessageBox.Show("Error al cargar los préstamos: " + ex.Message);
                }
            }
        }

        public DataTable BuscarPrestamos()
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("select * from Prestamo;", conn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable(); 
                    da.Fill(dt);

                    return dt;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
