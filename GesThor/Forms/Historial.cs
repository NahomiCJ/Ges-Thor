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
        Operacion op = new Operacion(); // Instancia de la clase que contiene operaciones con la base de datos
        public Historial()
        {
            InitializeComponent();
            // Al cargar el formulario, se llenan los datos del DataGridView con todos los préstamos registrados
            //dgv_Historial.DataSource = op.BuscarPrestamos();

            //dgv_Historial.Columns[0].Visible = false;
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

        // Evento que se ejecuta cuando cambia el texto del campo de matrícula
        // Filtra el historial por la matrícula ingresada
        private void txt_clave_TextChanged(object sender, EventArgs e)
        {
            dgv_Historial.DataSource = op.BuscarPrestamosPorMatricula(txt_clave.Text);
        }

        private void Historial_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MenuUsuarios frm = new MenuUsuarios();
            //frm.Show(); // Regresa al menú principal al cerrar el historial
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Historial_Load(object sender, EventArgs e)
        {
            dgv_Historial.DataSource = op.BuscarPrestamos();

            dgv_Historial.Columns[0].Visible = false;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
