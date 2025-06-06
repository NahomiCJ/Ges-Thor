using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesThor
{
    public partial class AddModEquipo: Form
    {
        Operacion op = new Operacion(); //Instancia de la clase Operacion que se encargará de ejecutar las operaciones en la base de datos
        public string modo_; //indica si el formulario se abrió en modo Agregar o Modificar.
        //Popiedades que representan los datos del equipo (utilizados en modo modificación).
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
        public bool Disponibilidad { get; set; }
        byte control;

        public AddModEquipo(string modo) //Recibe el modo de operación "Agregar" o "Modificar", y lo guarda en la variable "modo_"
        {
            InitializeComponent();
            modo_ = modo;
        }


        private void AddModEquipo_Load(object sender, EventArgs e)
        {

            if (modo_ == "Modificar")
            {
                lbl1.Text = modo_;
                txtId.Enabled = false;
                txtId.Text = Id.ToString();
                txtNombre.Text = Nombre;
                numCantidad.Value = Cantidad;
                cbEstado.Text = Estado;
                chbDisponibilidad.Checked = Disponibilidad;
            }
            else
            {
                lbl1.Text = modo_;
                txtId.Enabled = false;
                btnMod.Text = modo_;
                
            }

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            string resultado;
            
            if (ValidarCombo() && ValidarTxt())
            {
                switch (modo_) //Evaluar el modo del formulario
                {
                    case "Agregar":
                        resultado = op.AgregarEquipo(txtNombre.Text, (int)numCantidad.Value, cbEstado.Text, chbDisponibilidad.Checked);
                        if (!string.IsNullOrEmpty(resultado))
                        {
                            MessageBox.Show("El registro se he agregado correctamente");
                            this.Close();
                            Form1 frm = new Form1();
                            frm.Show();
                        }
                        break;
                    case "Modificar":
                        resultado = op.ModificarEquipo(Id, txtNombre.Text, (int)numCantidad.Value, cbEstado.Text, chbDisponibilidad.Checked);
                        if (!string.IsNullOrEmpty(resultado))
                        {
                            MessageBox.Show("El registro se he actualizado correctamente");
                            this.Close();
                            Form1 frm = new Form1();
                            frm.Show();
                        }
                        break;

                    default:
                        break;
                }
            }
            else
            {
                if (control == 1)
                {
                    MessageBox.Show("Introduzca un valor aceptable");
                    cbEstado.Text = "";
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                
            }
            
        }

        public bool ValidarCombo()
        {
            if (cbEstado.Text == "Disponible" || cbEstado.Text == "En Mantenimiento" || cbEstado.Text == "Dañado")
            {
                return true;
            }
            else
            {
                control = 1;
                return false;
            }
        }

        public bool ValidarTxt()
        {
            if (!string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                return true;
            }
            else
            {
                control = 2;
                return false;
            }
        }
    }
}
