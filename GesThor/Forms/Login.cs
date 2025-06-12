using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesThor.Forms
{
    public partial class Login: Form
    {
        Operacion op = new Operacion(); //Instancia de la clase Operacion que se encargará de ejecutar las operaciones en la base de datos
        string error;
        MenuUsuarios frm;
        public Login()
        {
            InitializeComponent();
            this.Text = "Bienvenido";
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            error = op.Login(txtNombre.Text, txtClave.Text);
            switch (error)
            {
                case "Login correcto.":
                    var result = MessageBox.Show("¿Desea abrir el Menú como administrador?", "Modo", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        frm = new MenuUsuarios("Admin");
                        frm.ShowDialog();
                        this.Show();
                        txtClave.Clear();
                        txtNombre.Clear();
                    }
                    else
                    {
                        this.Hide();
                        frm = new MenuUsuarios("Usuario");
                        frm.ShowDialog();
                        this.Show();
                        txtClave.Clear();
                        txtNombre.Clear();
                    }
                    break;
                case "Contraseña incorrecta.":
                    MessageBox.Show(error);
                    break;
                case "Usuario no encontrado.":
                    MessageBox.Show(error);
                    break;
                default:
                    break;
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
        }
    }
}
