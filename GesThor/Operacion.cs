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

namespace GesThor
{
    class Operacion
    {
        string conexion = "Data Source = DESKTOP-TE3EHHL\\SQLEXPRESS; Initial Catalog = GesThor; integrated security = true;";

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

        public string AgregarPrestamo(int Id_U, int Id_E, DateTime Dev, string Status, DateTime DevR)
        {
            try
            {
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("spi_AgPrestamo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_U", Id_U);
                cmd.Parameters.AddWithValue("@Id_E", Id_E);
                cmd.Parameters.AddWithValue("@Fecha_Dev", Dev);
                cmd.Parameters.AddWithValue("@Status_Prestamo", Status);
                cmd.Parameters.AddWithValue("@Fecha_DevReal", DevR);

                cmd.ExecuteNonQuery();

                con.Close();

                return "Agregado";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public int ConsultaUsuario(string Mat)
        {
            try
            {
                int Id = 0;
                SqlConnection con = new SqlConnection(conexion);
                con.Open();
                SqlCommand cmd = new SqlCommand("sprConsultarIdUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Matricula", Mat);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Id_Usuario"]); // Asegúrate de que este sea el nombre correcto de la columna
                    }
                }

                return Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
