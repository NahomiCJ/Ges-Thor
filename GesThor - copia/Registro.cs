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

namespace GesThor
{
    public partial class Registro: Form
    {
        Operacion op = new Operacion(); // Instancia de la clase que maneja operaciones con la base de datos

        public string Matricula { get; set; } // Propiedad pública para pasar la matrícula desde otro formulario

        public Registro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                MessageBox.Show("El registro se he agregado correctamente");
                this.Close();
                
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
    }
}
