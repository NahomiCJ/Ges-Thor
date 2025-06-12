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
using System.Configuration;

namespace GesThor
{
    class Operacion
    {
        //private string conexion = File.ReadAllText("conexion.txt");
        //private string conexion = "Data Source = localhost\\SQLEXPRESS;Initial Catalog = GesThor;Integrated Security=True;";// Cadena de conexión a la base de datos SQL Server llamada "GesThor"
        private string conexion = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;


        #region Visualizar

        public DataTable Cargar()// Obtiene todos los registros de la vista vwInventario usando WITH(NOLOCK)
                                 // y los devuelve en un DataTable
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from vwInventario WITH(NOLOCK)", con); //Llamado de la Vista

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                dt.Load(reader);
            }
            con.Close();
            return dt;
        }
        #endregion Visualizar

        public string AgregarEquipo(string Nombre, int Cantidad, string Estado, 
            bool Disponibilidad) // Agrega un nuevo equipo a través del procedimiento almacenado `spi_AgEquipo`
        {
            int dis = Disponibilidad == true ? 1 : 0; // Convierte el booleano de disponibilidad en 1 (true) o 0 (false)
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("spi_AgEquipo", con); //Llamado del StoredProcedure
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

        public string ModificarEquipo(int Id, string Nombre, int Cantidad, 
            string Estado, bool Disponibilidad)  // Modifica un equipo existente con base en su Id usando el procedimiento `spu_ModEquipo`
        {
            int dis = Disponibilidad == true ? 1 : 0; // Convierte el booleano de disponibilidad en 1 (true) o 0 (false)
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("spu_ModEquipo", con); //Llamado del StoredProcedure
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

        public string AgregarPrestamo(int Id_U, int Id_E, DateTime Pres, 
            DateTime Dev, string Status) // Inserta un nuevo préstamo mediante el procedimiento `spiAgPrestamo`
        {
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("spiAgPrestamo", con); //Llamado del StoredProcedure
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

        public string ConsultaUsuario(string Mat) // Consulta el ID de un usuario a partir de su matrícula usando el procedimiento `sprConsultarIdUsuario`
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("sprConsultarIdUsuario", con)) //Llamado del StoredProcedure
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

        public DataTable BuscarPrestamosPorMatricula(string mat) // Busca todos los préstamos realizados por un usuario con determinada matrícula
                                                                 // usando el procedimiento almacenado `ObtenerPrestamosPorMatricula`
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

        public DataTable BuscarPrestamos() // Devuelve todos los registros de la tabla `Prestamo` usando una consulta SQL directa
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("ObtenerPrestamos", conn);
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

        public bool BuscarUsuario(string mat) // Verifica si un usuario existe en la base de datos a partir de su matrícula
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
                        return true; // Devuelve `true` si el usuario existe (1), `false` si no (0)
                    }
                    else
                    {
                        return false; // Devuelve `false` si no (0)
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        public string AgregarUsuario(string matricula, string carrera, string correo, 
            string telefono) // Agrega un nuevo usuario a través del procedimiento almacenado `spiAgUsuario`
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

        public DataTable BuscarPrestamosActRet() // Devuelve una lista de préstamos activos o retrasados
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

        public string DevolverPres(int idPrestamo, DateTime fechaDevReal, string nuevoStatus)  // Actualiza un préstamo cuando un equipo es devuelto
        { // Se actualiza la fecha real de devolución y el estado del préstamo
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

        public string Login(string usuario, string clave)
        {
            ////string control;
            //Lectura de la contraseña cifrada en la base de datos
            byte[] hashIngresado = Seguridad.HashPassword(clave);

            //Selección del usuario a través de una consulta por medio de los datos ingreados 
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = "SELECT Contraseña FROM Administrador WHERE Nombre_Administrador = @Nombre";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", usuario);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //Contraseña convertida en bytes para comprobar la contraseña
                        byte[] hashAlmacenado = (byte[])reader["Contraseña"];

                        if (Seguridad.CompararHashes(hashAlmacenado, hashIngresado))
                        {
                            //Indicación del login del correcto en caso de que el usuario exista en la BD 
                            //MessageBox.Show("Login correcto.");
                            return "Login correcto.";
                        }
                        else
                        {
                            //Letrero de que el usuario ingreso la contraseña de manera incorrecta 
                            //MessageBox.Show("Contraseña incorrecta.");
                            return "Contraseña incorrecta.";
                        }
                    }
                    else
                    {
                        //Valida indicando que el usuario principalmente no exista 
                        //MessageBox.Show("Usuario no encontrado.");
                        return "Usuario no encontrado.";
                    }
                }
            }
        }

        #region Clase Seguridad 
        //Clase Seguridad para heahear la contraseña que le usuario ingrese 
        public static class Seguridad
        {
            public static byte[] HashPassword(string password)
            {
                using (var sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(password);
                    return sha256.ComputeHash(bytes);
                }
            }

            #endregion



            #region Comparación de hasheo

            //Clase para comparar el hasheo

            public static bool CompararHashes(byte[] hash1, byte[] hash2)
            {
                if (hash1.Length != hash2.Length) return false;
                for (int i = 0; i < hash1.Length; i++)
                {
                    if (hash1[i] != hash2[i]) return false;
                }
                return true;
            }
        }

        #endregion
    }
}
