using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace GesThor
{
    class Operacion
    {
        string conexion = "Data Source=localhost;Initial Catalog=GesThor;Integrated Security=True;";

        public DataTable Cargar()
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from vwInventario with(nolock)", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Estado", Estado);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                dt.Load(reader);
            }
            con.Close();
            return dt;
        }

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
    }
}
