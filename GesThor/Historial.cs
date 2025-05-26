using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesThor
{
    public partial class Historial : Form
    {
        Operacion op = new Operacion();
        public Historial()
        {
            InitializeComponent();
            dgv_Historial.DataSource = op.BuscarPrestamos();
            //dgv_Historial.DataSource = op.BuscarPrestamosPorMatricula(null);
            
        }

        //private void BuscarPrestamosPorMatricula()
        //{
        //    string conexion = "Data Source=localhost;Initial Catalog=GesThor;Integrated Security=True;";
        //    //Conexion a la base de datos 
        //    using (SqlConnection conn = new SqlConnection(conexion))
        //    {
        //        try
        //        {
        //            conn.Open();

        //            SqlCommand cmd = new SqlCommand("ObtenerPrestamosPorMatricula", conn); 
        //            cmd.CommandType = CommandType.StoredProcedure;  //Llamado del StoredProcedure 

                  
        //            cmd.Parameters.AddWithValue("@Matricula", txt_clave.Text.Trim()); //Parametro de Matricula o Clave

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            DataTable dt = new DataTable();  //Adaptacion de la tabla en el DataGridView
        //            da.Fill(dt);

        //            dgv_Historial.DataSource = dt;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error al cargar los préstamos: " + ex.Message);
        //        }
        //    }
        //}
        private void dgv_Historial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_clave_TextChanged(object sender, EventArgs e)
        {

        }

        private void Historial_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuUsuarios frm = new MenuUsuarios();
            frm.Show();
        }
    }
}
