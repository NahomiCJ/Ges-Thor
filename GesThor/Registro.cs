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
        Operacion op = new Operacion();

        public string Matricula { get; set; }

        public Registro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string resultado = op.AgregarUsuario(txtMatricula.Text.Trim(), cbCarrera.Text.Trim(), txtCorreo.Text.Trim(), txtTelefono.Text.Trim());
            if (string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("El registro se he agregado correctamente");
                this.Close();
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            txtMatricula.Text = Matricula;
        }
    }
}
