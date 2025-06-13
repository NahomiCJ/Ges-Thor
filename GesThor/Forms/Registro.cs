using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace GesThor
{
    public partial class Registro : Form
    {
        Operacion op = new Operacion(); // Instancia de la clase que maneja operaciones con la base de datos
        byte control; // Variable de control de validaciones
        public string Matricula { get; set; } // Propiedad pública para pasar la matrícula desde otro formulario

        public Registro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarTxt() && ValidarEmail() && ValidarCombo()) //Validar los datos antes de hacer un registro
            {
                // Llama al método que registra al usuario en la base de datos
                string resultado = op.AgregarUsuario(
                    txtMatricula.Text.Trim(),
                    cbCarrera.Text.Trim(),
                    txtCorreo.Text.Trim(),
                    txtTelefono.Text.Trim()
                );
                // Si no hay errores, muestra mensaje y cierra el formulario
                if (string.IsNullOrEmpty(resultado))
                {
                    MessageBox.Show("El usuario se ha agregado correctamente");
                    this.Close();

                }
            }
            else
            {
                switch (control) // Imprime un mensaje dependiendo del caso de error que encuentre
                {
                    case 1: // Algun textBox esta vacio
                        MessageBox.Show("Debe llenar todos los campos"); 

                        break;
                    case 2: // La carrera no corresponde a las opciones proporcionadas o esta vacia
                        MessageBox.Show("Ingrese una cerrera válida");
                        cbCarrera.Text = "";
                        break;
                    case 3: // El correo electronico no es válido
                        MessageBox.Show("El correo electrónico no es válido");
                        txtCorreo.Text = "";
                        break;
                    default:
                        break;
                }
            }
        }

        // Evento que se ejecuta al presionar el botón de regreso
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Simplemente cierra el formulario
        }

        // Evento que se ejecuta al cargar el formulario
        private void Registro_Load(object sender, EventArgs e)
        {
            txtMatricula.Text = Matricula; // Prellena el campo de matrícula si fue pasada desde el formulario de solocitar o reservar
        }

        public bool ValidarTxt() // metodo para validar que los textbox no se encuentren vacios
        {
            if (!string.IsNullOrEmpty(txtMatricula.Text.Trim()) && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtTelefono.Text))
            {
                return true;
            }
            else
            {
                control = 1; //Control de errores
                return false;
            }
        }

        public bool ValidarCombo() // Metodo para validar las entradas del combobox
        {
            if (cbCarrera.Text == "ISIC" || cbCarrera.Text == "ILOG" ||
                cbCarrera.Text == "IGEM" || cbCarrera.Text == "IIND")
            {
                return true;
            }
            else
            {
                control = 2; //Control de errores
                return false;
            }
        }

        // Declaración de la función de validación de correo
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email)) return false; // Verifica si la cadena es nula o vacía

            // Utiliza la expresión regular para validar el correo electrónico
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Match match = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return match.Success; // Retorna true si la expresión regular coincide
        }

        public bool ValidarEmail() //Metodo para validar las entradas del textbox correo
        {
            if (IsValidEmail(txtCorreo.Text.Trim()))
            {
                return true;
            }
            else
            {
                control = 3; //Control de errores
                return false;
            }
        }

        private void txtCorreo_Validating_1(object sender, CancelEventArgs e)
        {
            //if (!IsValidEmail(txtCorreo.Text))
            //{
            //    // Si la validación falla, muestra un error (ejemplo con un Label)
            //    MessageBox.Show("El correo electrónico no es válido.");
            //    //errorLabel.Text = "El correo electrónico no es válido.";
            //    //errorLabel.Visible = true;
            //    e.Cancel = true; // Anula la validación
            //    txtCorreo.Focus(); // Enfoca el TextBox para que el usuario lo pueda corregir
            //}
            //else
            //{
            //    // Si la validación es exitosa, oculta el mensaje de error
            //    //errorLabel.Visible = false;
            //}
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e) //Restringir textbox telefono
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear la tecla
            }
        }
    }
}
