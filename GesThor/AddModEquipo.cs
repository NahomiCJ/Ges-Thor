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
        Operacion op = new Operacion();
        public string modo_;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
        public bool Disponibilidad { get; set; }

        public AddModEquipo(string modo)
        {
            InitializeComponent();
            modo_ = modo;
        }


        private void AddModEquipo_Load(object sender, EventArgs e)
        {
            txtId.Text = Id.ToString();
            txtNombre.Text = Nombre;
            numCantidad.Value = Cantidad;
            cbEstado.Text = Estado;
            chbDisponibilidad.Checked = Disponibilidad;

            if (modo_ == "Modificar")
            {
                lbl1.Text = modo_;
                txtId.Enabled = false;
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
            switch (modo_)
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
    }
}
