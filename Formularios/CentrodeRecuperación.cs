using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Formulario_de_Login.Registro;

namespace Formulario_de_Login
{
    public partial class CentrodeRecuperación : Form
    {

        //Variables globales 
        private string codigoGenerado;
        private string usuario;
        string conexion = "Server=GENERALROBERT\\SQLEXPRESS;Database=BDLogin;Trusted_Connection=True;";



        public CentrodeRecuperación()
        {
            InitializeComponent();
        }

        public CentrodeRecuperación(string codigo, string usuarioNombre)
        {
            InitializeComponent();
            codigoGenerado = codigo;
            usuario = usuarioNombre;            
        }

        private void ActualizarContraseña(string email, string nuevaClave)
        {
            byte[] hashNuevaClave = Seguridad.HashPassword(nuevaClave);

            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET Contraseña = @Clave WHERE Usuario = @User", con);
                cmd.Parameters.Add("@Clave", SqlDbType.VarBinary).Value = hashNuevaClave;
                cmd.Parameters.AddWithValue("@User", email);
                cmd.ExecuteNonQuery();
            }
        }

        public static class Seguridad
        {
            public static byte[] HashPassword(string password)
            {
                using (var sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                }
            }

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


        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            {
                if (txt_CodigoVerificador.Text.Trim() == codigoGenerado)
                {
                    ActualizarContraseña(usuario, txt_NuevaContraseña.Text);
                    MessageBox.Show("Contraseña actualizada.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Código incorrecto.");
                }
            }


        }

        private void CentrodeRecuperación_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Recuperacion recuperacion = new Recuperacion();
            recuperacion.Show();
            this.Close();
        }
    }
}
