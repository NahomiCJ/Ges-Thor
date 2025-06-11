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

namespace Formulario_de_Login
{




    public partial class Recuperacion : Form
    {

        //Establecimiento de conexión con SQL Server.
        string conexion = "Server=GENERALROBERT\\SQLEXPRESS;Database=BDLogin;Trusted_Connection=True;";



         #region Variables globales  
        private string codigoGenerado;
        private string codigoGuardado = null;
        private string correoUsuarioActual = null;

        #endregion

        public Recuperacion()
        {
            InitializeComponent();

        }



        #region ObtenerCorreoPorUsuario

        //Método para obtener el correo de manera automatica a traves de un consulta del usuario en SQL Server. 
        private void ObtenerCorreoPorUsuario()
        {

            string usuario = txt_Usuario.Text;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                //Consulta SQL
                string query = "SELECT Correo FROM Usuarios WHERE Usuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                try
                {
                    con.Open();
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        correoUsuarioActual = resultado.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                        correoUsuarioActual = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el correo: " + ex.Message);
                    correoUsuarioActual = null;
                }
            }
        }


        #endregion


        #region Generación del codigo y envio del correo

        //Método para generar el codigo random para ser enviado al correo del usuario.
        private string GenerarCodigo()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString(); 
        }

 

        //Método de para enviar un correo electronico al usuario, comprobando de que exista su correo y su contraseña de Google.
        private bool EnviarCorreo()
        {
            string correoEmisor = correoUsuarioActual;
            string claveApp = ObtenerCodigoGoogle(txt_Usuario.Text);
            string destino = correoUsuarioActual;

            MailMessage mail = new MailMessage(correoEmisor, destino);
            mail.Subject = "Ges-Thor - Método de recuperación de contraseña";
            mail.Body = $"Tu código de verificación es: {codigoGenerado}";

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new System.Net.NetworkCredential(correoEmisor, claveApp);
            client.EnableSsl = true;

            try
            {
                client.Send(mail);
                GuardarCodigoGoogle(correoEmisor, claveApp); 
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
                return false;
            }
        
       }

        #endregion




        #region Obtención, Guardado, Visualización y Generación del codigo Google

        //Método para obtener el codigo de Google, con esta funcion mostrará el codigo que esta guardado en la BD, realizar una consulta
        //y mostrarlo a traves de un label en el formulario. 
        private string ObtenerCodigoGoogle(string usuario)
        {
            using (SqlConnection con = new SqlConnection(conexion))

            {

                //Consulta SQL
                string query = "SELECT CodigoGoogle FROM Usuarios WHERE Usuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                try
                {
                    //Abrir conexión. 
                    con.Open();
                    object resultado = cmd.ExecuteScalar();

                    //Comparar si existe la contraseña de Google en la BD y este creado una conexión.
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        //Cifrar la contraseña de Google.
                        byte[] claveBytes = (byte[])resultado;

                        //Retornar el valor en bytes.
                        return Encoding.UTF8.GetString(claveBytes); 
                    }

                    //Llenar la variable codigoGoogle con el método ObtenerCodigoGoogle a través del usuario.
                    string codigoGoogle = ObtenerCodigoGoogle(txt_Usuario.Text); 

                    //Función para validar que el usuario cuente con una contraseña de Google.
                    if (!string.IsNullOrEmpty(codigoGoogle))
                    {
                        //Mostrar que el codigo esta guardado, si este existe.
                        lbl_CodigoGoogle.Text = "Código guardado: " + codigoGoogle;
                    }
                    else
                      //Mostrar que no hay codigo guardado si este no esta registrado en la BD por un error.
                    {
                        lbl_CodigoGoogle.Text = "No hay código guardado para este usuario.";
                    }
                
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener código Google: " + ex.Message);
                }
            }
            return null;
        }



        //Método para guardar el codigo de Google de manera automatizada.
        private void GuardarCodigoGoogle(string email, string claveApp)
        {
            //Cifrar la contraseña de Google en bytes.
            byte[] claveBytes = Encoding.UTF8.GetBytes(claveApp);

            //Establecer la conexion con SQl.
            using (SqlConnection con = new SqlConnection(conexion))
            {
                //Abrir conexión.
                con.Open();

                // Primero obtenemos el código actual.
                SqlCommand obtenerCmd = new SqlCommand("SELECT CodigoGoogle FROM Usuarios WHERE Correo = @Correo", con);
                obtenerCmd.Parameters.AddWithValue("@Correo", email);
                object resultado = obtenerCmd.ExecuteScalar();

                //Despúes validamos a través de un true si es distinto la contrasela se modifica, de lo contrario no se modifica.   
                bool esDistinto = true;

                //Si es igual no se modifica.
                if (resultado != DBNull.Value && resultado != null)
                {
                    byte[] codigoActual = (byte[])resultado;
                    esDistinto = !codigoActual.SequenceEqual(claveBytes);
                }

                //Si no es igual se modifica con el nueva contraseña.
                if (esDistinto)
                {
                    SqlCommand actualizarCmd = new SqlCommand("UPDATE Usuarios SET CodigoGoogle = @ClaveApp WHERE Correo = @Correo", con);
                    actualizarCmd.Parameters.Add("@ClaveApp", SqlDbType.VarBinary).Value = claveBytes;
                    actualizarCmd.Parameters.AddWithValue("@Correo", email);
                    actualizarCmd.ExecuteNonQuery();
                }
            }
        }
        



        //El evento click, Obtiene el correo del usuario con el fin de mostrar el correo //DESCARTADO 
        private void label3_Click(object sender, EventArgs e)
        {
            ObtenerCorreoPorUsuario(); 

            if (correoUsuarioActual != null)
            {
                label3.Text = "Tu correo electrónico es: " + correoUsuarioActual;
            }
            else
            {
                label3.Text = "Usuario no encontrado.";
            }
        }



        //Muestra el codigo de 16 digitos de Google a traves de una consulta directa con el nombre del usuario. 
        private void MostrarCodigoGoogle()
        {
            //A traves del textbox se guarda el usuario en la variable. 
            string usuario = txt_Usuario.Text.Trim();
            if (string.IsNullOrEmpty(usuario)) return;

            using (SqlConnection con = new SqlConnection(conexion))
            {
                //Consulta SQL
                string query = "SELECT CodigoGoogle FROM Usuarios WHERE Usuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                try
                {
                    //Abir conexion con SQL
                    con.Open();
                    object resultado = cmd.ExecuteScalar();

                    //Comparar si el codigo existe con el codigo guardado en la BD.
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        byte[] claveBytes = (byte[])resultado;
                        codigoGuardado = Encoding.UTF8.GetString(claveBytes);
                        lbl_CodigoGoogle.Text = $"Código actual: {codigoGuardado}";
                    }
                    else
                    {
                        //No hay codigo guardado en la BD.
                        codigoGuardado = null;
                        lbl_CodigoGoogle.Text = "No hay código guardado.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar el código: " + ex.Message);
                }
            }
        }
        #endregion


        #region Actualización del Codigo Google


        //Método para actualizar el codigo de google si este distinto. 
        private void ActualizarCodigoGoogleSiEsDistinto()
        {

            //Variables para guardar los datos que ingreso el usuario. 
            string nuevoCodigo = txt_NuevoCodigo.Text.Trim();
            string usuario = txt_Usuario.Text.Trim();


            //Se ingresa el usuario para modificar el contraseña de la conexión con Google.
            if (string.IsNullOrEmpty(usuario))
            {
                //Letrero donde tiene que  ingresar el usuario como requisito.
                MessageBox.Show("Debe ingresar el usuario.");
                return;
            }

            //Letrero donde tiene que ingresar el nuevo codigo como requisito.
            if (string.IsNullOrEmpty(nuevoCodigo))
            {
                MessageBox.Show("Debe ingresar un nuevo código.");
                return;
            }

            // Recuperar el código guardado desde la BD.
            string codigoGuardado = null;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                //Realización de una consulta para conocer el codigo de Google con el usuario que fue ingresado 
                string query = "SELECT CodigoGoogle FROM Usuarios WHERE Usuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                try
                {
                    con.Open();
                    object resultado = cmd.ExecuteScalar();

                    //Comparar si el nuevo codigo de Google esta vacia  
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        //Cifrar la nueva contraseña de la conexión con Google en la BD. 
                        byte[] bytesCodigo = (byte[])resultado;
                        codigoGuardado = Encoding.UTF8.GetString(bytesCodigo);
                    }
                }
                catch (Exception ex)
                {
                    //Indicar este letrero error de lectura si que el campo esta vacio,  
                    MessageBox.Show("Error al leer el código guardado: " + ex.Message);
                    return;
                }
            }

            // Comparar el codigo guardado con el nuevo codigo a modificar. 
            if (codigoGuardado == nuevoCodigo)
            {
                MessageBox.Show("El código ingresado es el mismo. No hará ningún cambio.");
                return;
            }

            // Si es distinto, actualizar.
            using (SqlConnection con = new SqlConnection(conexion))
            {

                //Crear una consulta para modificar el codigo de google en caso de cumplir con las condiciones anteriores. 
                string update = "UPDATE Usuarios SET CodigoGoogle = @NuevoCodigo WHERE Usuario = @Usuario";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.Parameters.Add("@NuevoCodigo", SqlDbType.VarBinary).Value = Encoding.UTF8.GetBytes(nuevoCodigo);
                cmd.Parameters.AddWithValue("@Usuario", usuario);

                try
                {
                    con.Open();
                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        //Letrero que el codigo fue actualizado de manera exitosa
                        MessageBox.Show("Código actualizado correctamente.");
                    }
                    else
                    {
                        //Letrero que el codigo no fue encontrado de manera exitosa
                        MessageBox.Show("No se encontró el usuario para actualizar.");
                    }
                }
                catch (Exception ex)
                {
                    //Letrero que el codigo no fue actualizado de manera exitosa
                    MessageBox.Show("Error al actualizar el código: " + ex.Message);
                }
            }
        }

        #endregion


        #region Validación del email


        //Método para verificar y validar que el correo del usuario exista en la BD, este método es clave a ser conectado hacia otros métodos.
        private bool EmailExiste(string email)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                //Consulta para conocer si existe el correo electronico del usuario.  
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Correo = @Email", con);
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void txt_EnviarCodigo_Click(object sender, EventArgs e)
        {

            //Método llamado para obtener el correo del usuario.
            ObtenerCorreoPorUsuario();

            //Condicional para verificar si existe un correo del usuario.
            if (correoUsuarioActual != null && EmailExiste(correoUsuarioActual))
            {
                codigoGenerado = GenerarCodigo();

                //En caso de que si exista, se enviará al codigo registrado en la BD.
                bool correoEnviado = EnviarCorreo();

                if (correoEnviado)
                {
                    //Letreo para indicar al usuario que el correo con el codigo de recuperación fue enviado de manera exitosa.
                    MessageBox.Show("Código enviado al correo. Verifica tu correo el codigo generado", "SISTEMA DE RECUPERACIÓN" , MessageBoxButtons.OK);
                    //Constructor para cargar los datos en el formulario CentroRecuperación.
                    CentrodeRecuperación centrodeRecuperación = new CentrodeRecuperación(codigoGenerado, txt_Usuario.Text);
                    centrodeRecuperación.Show();
                    this.Hide();
                }
                else
                {
                    //Letrero donde no se pudo validar de que exista una conexion con Google.
                    MessageBox.Show("No se pudo enviar el correo. Verifica tu código de Google o la conexión.");
                }
            }
            else
            {
                //Letrero donde no se pudo validar un correo del usuario.
                MessageBox.Show("El correo no está registrado.");
            }
        }


        //Evento para mostrar el codigo de google cuando se identifica el usuario.
        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            //Llamar el método para identificar el codigo a través del usuario.
            MostrarCodigoGoogle();  
        }


        //Evento para mostrar el codigo de google cuando se identifica el usuario. //DESCARTADO
        private void txt_ConfirmarUsuario_Click(object sender, EventArgs e)
        {
            MostrarCodigoGoogle();
        }

        //Evento para confirmar el cambio del codigo de google cuando se identifica el usuario.
        private void btn_Cambiarcodigo_Click(object sender, EventArgs e)
        {
            //Llamar el método para actualizar el codigo  de Google a través del usuario.
            ActualizarCodigoGoogleSiEsDistinto();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void Recuperacion_Load(object sender, EventArgs e)
        {

        }
    }
}

#endregion