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
using System.Drawing;

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

        public string AgregarPrestamo(int Id_U, int Id_E, DateTime Pres, DateTime Dev, string Status)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("spiAgPrestamo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_U", Id_U);
                cmd.Parameters.AddWithValue("@Id_E", Id_E);
                cmd.Parameters.AddWithValue("@Fecha_Prestamo", Pres);
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

        public bool BuscarUsuario(string mat)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sprConsultarUsuarioExist", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Matricula", mat);
                    object res = cmd.ExecuteScalar();
                    int valor = Convert.ToInt32(res);
                    if (valor == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public string AgregarUsuario(string matricula, string carrera, string correo, string telefono)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("spiAgUsuario", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Matri", matricula);
                    cmd.Parameters.AddWithValue("@Carrera", carrera);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Tel", telefono);

                    cmd.ExecuteNonQuery();
                }

                return null; // Éxito
            }
            catch (SqlException ex)
            {
                // Retornar el mensaje de error generado por el procedimiento almacenado
                return "Error SQL: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Error general: " + ex.Message;
            }
        }

        public DataTable BuscarPrestamosActRet()
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sprVerPrestamosActORet", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

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

        public string DevolverPres(int idPrestamo, DateTime fechaDevReal, string nuevoStatus)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("spuUpPrestamo", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id_Prestamo", idPrestamo);
                    cmd.Parameters.AddWithValue("@NuevaFechaDevReal", fechaDevReal);
                    cmd.Parameters.AddWithValue("@NuevoStatus", nuevoStatus);

                    cmd.ExecuteNonQuery();
                }

                return null; // Éxito
            }
            catch (SqlException ex)
            {
                return "Error SQL: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Error general: " + ex.Message;
            }
        }

    }
}
