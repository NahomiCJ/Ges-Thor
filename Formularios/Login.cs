using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Formulario_de_Login.Registro;

namespace Formulario_de_Login
{
    public partial class Login : Form
    {
        public Login()
        {
          
            InitializeComponent();
           
        }


        #region Valicación de registro de nuevos usuarios
        //Acceder para comprobar y validar la información que se ingreso en el login, validando que exista el usario en la base de datos 
        private void btn_Acceder_Click(object sender, EventArgs e)
        {
            //Conexión a la base de datos local 
            string conexion = "Server=GENERALROBERT\\SQLEXPRESS;Database=BDLogin;Trusted_Connection=True;";
            string usuario = txt_Nombre.Text;
            string clave = txt_Contraseña.Text;

            //Lectura de la contraseña cifrada en la base de datos
            byte[] hashIngresado = Seguridad.HashPassword(clave);

            //Selección del usuario a través de una consulta por medio de los datos ingreados 
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = "SELECT Contraseña FROM Usuarios WHERE Usuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

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
                            MessageBox.Show("Login correcto.");
                        }
                        else
                        {
                            //Letrero de que el usuario ingreso la contraseña de manera incorrecta 
                            MessageBox.Show("Contraseña incorrecta.");
                        }
                    }
                    else
                    {
                        //Valida indicando que el usuario principalmente no exista 
                        MessageBox.Show("Usuario no encontrado.");
                    }
                }

            }

        }


        #endregion


        #region Eventos

        //Evento para dirigirse al formulario de Recuperación y esconder el formulario actual
        private void label2_Click(object sender, EventArgs e)
        {
            //LLamado del formulario recuperacion
            Recuperacion recuperacion = new Recuperacion();
            recuperacion.Show();
            //Esconder formulario actual
            this.Hide();
        }



        //Evento para abrir el formulario Registro para registrar un usuario nuevo
        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            //LLamado del formulario recuperacion
            Registro registro = new Registro();
            registro.Show();
            //Esconder formulario actual
            this.Hide();
        }


        //Evento para cerrar la aplicación y matar proceso de toda la aplicación
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


    #endregion
}
