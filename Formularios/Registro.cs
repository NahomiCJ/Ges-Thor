using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_de_Login
{
    
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        string conexion = "Server=GENERALROBERT\\SQLEXPRESS;Database=BDLogin;Trusted_Connection=True;";



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


        #region Validación de datos 

        //Validar que todos los campos esten llenados por el usuario 
        private void button1_Click(object sender, EventArgs e)
        {

            string usuarioNuevo = textBox1.Text.Trim();
            string contraseña = textBox2.Text.Trim();
            string correoEletronico = txt_CorreoEletronico.Text.Trim();
            string codigoApp = txt_ContraseñaGoogle.Text.Trim();

            //Comparación de que cada campo este lleno de lo contrario indicara la usuario una aviso
            if (string.IsNullOrEmpty(usuarioNuevo) ||
                string.IsNullOrEmpty(contraseña) ||
                string.IsNullOrEmpty(correoEletronico) ||
                string.IsNullOrEmpty(codigoApp))
            {
                MessageBox.Show("Todos los campos son obligatorios para poder registrarse.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir sin hacer nada si algún campo está vacío
            
            
            
            }


            #endregion

            #region Conversión de datos a cifrado

            // Convertimos contraseña y código a binario
            byte[] hash = Seguridad.HashPassword(contraseña);
            byte[] codigoBytes = Encoding.UTF8.GetBytes(codigoApp);

            //Abrimos conexion a la base de datos con una consulta para el registro del usuario con todos los campos llenos 
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = "INSERT INTO Usuarios (Usuario, Contraseña, Correo, CodigoGoogle) VALUES (@u, @h, @c, @cogoogle)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", usuarioNuevo);
                cmd.Parameters.AddWithValue("@h", hash);
                cmd.Parameters.AddWithValue("@c", correoEletronico);
                cmd.Parameters.Add("@cogoogle", SqlDbType.VarBinary).Value = codigoBytes;

                //Le indica que le usuario que hay sido de manera exitosa 
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar usuario: " + ex.Message);
                }
            }
        }
        #endregion


        #region Eventos 

        //Evento para abrir el login y esconder el actual formulario
        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        //Evento para cerrar este formulario  y abrir el login 
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();             
            login.Show();   
        }

        #endregion
    }
}