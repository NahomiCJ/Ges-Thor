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
    public partial class SolResRec : Form
    {
        Operacion op = new Operacion(); // Instancia de la clase Operacion para acceder a los métodos de la base de datos
        public string modo_; // Variable que determina si el formulario está en modo "Solicitar" o "Reservar"
        public SolResRec(string modo)
        {
            InitializeComponent();
            modo_ = modo; // Se guarda el modo enviado al instanciar el formulario
        }

        private void SolResRec_Load(object sender, EventArgs e)
        {
            dgvInv.DataSource = op.Cargar();
            dgvInv.Columns[0].Visible = false;
            this.Text = modo_; // Cambia el título del formulario según el modo dgvInv.DataSource = op.Cargar(); // Carga el inventario en el DataGridView
            lbl1.Text = modo_; // Cambia el texto del label principal
            btnSol.Text = modo_; // Cambia el texto del botón según el modo
            // Desactiva campos que no deben ser editados por el usuario
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            cbEstado.Enabled = false;
            cbMinutos.Enabled = false;
            // Oculta campos específicos si el modo es "Solicitar"
            if (modo_ == "Solicitar")
            {
                lblHora.Enabled = false;
                lblMin.Enabled = false;
                cbHora.Enabled = false;
                cbMinutos.Enabled = false;
                lblHora.Visible = false;
                lblMin.Visible = false;
                cbHora.Visible = false;
                cbMinutos.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                dtpFecha.Enabled = false;
            }
 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {// Regresa al menú principal de usuarios
            MenuUsuarios frm1 = new MenuUsuarios();
            frm1.Show();
            this.Hide();
        }

        private void dgvInv_SelectionChanged(object sender, EventArgs e)
        {// Se ejecuta cuando el usuario selecciona una fila del inventario
            string temp;
            if (dgvInv.SelectedRows.Count > 0) // Verifica que el usuario haya seleccionado un valor
            {
                DataGridViewRow select = dgvInv.SelectedRows[0];

                if (select != null && !string.IsNullOrEmpty(select.Cells[0].Value.ToString())) // Verifica el campo no este vacío
                {

                    temp = select.Cells[4].Value.ToString(); // Verifica disponibilidad del equipo

                    if (Convert.ToBoolean(temp)) // Si el recurso está disponible, llena los campos
                    {
                        txtId.Text = select.Cells[0].Value.ToString();
                        txtNombre.Text = select.Cells[1].Value.ToString();
                        cbEstado.Text = select.Cells[3].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El recurso no esta disponible en este momento"); //Imprime un mensaje si el material no esta disponible
                    }
                }
                else
                {
                    MessageBox.Show("El recurso esta vacío"); //Imprime un mensaje si el material no esta disponible
                }

            }
            //else
            //{
            //    MessageBox.Show("Seleccione solo un recurso"); //Imprime un mensaje si el usuario selecciona mas de un registro
            //}
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            string mat = txtMatricula.Text;
            if (op.BuscarUsuario(mat)) // Verifica si el usuario está registrado
            {
                string idusu = op.ConsultaUsuario(mat);
                string resultado, status = "Activo";
                DateTime prestamo = dtpFecha.Value;
                int minutos = 50 * (Convert.ToInt32(numHoras.Value)); // Calcula duración en minutos
                
                switch (modo_) //Evaluar el modo del formulario
                {
                    case "Solicitar":
                        // Si el modo es solicitar, la fecha y hora son inmediatas
                        DateTime dev = dtpFecha.Value.AddMinutes(minutos);
                        resultado = op.AgregarPrestamo(Convert.ToInt32(idusu), Convert.ToInt32(txtId.Text), prestamo, dev, status);
                        if (string.IsNullOrEmpty(resultado))
                        {
                            MessageBox.Show("El registro se he agregado correctamente");
                            this.Close();
                            MenuUsuarios frm = new MenuUsuarios();
                            frm.Show();
                        }
                        break;

                    case "Reservar":
                        // Si el modo es reservar, se toma hora y minutos específicos
                        int hor = Convert.ToInt32(cbHora.Text);
                        int min = Convert.ToInt32(cbMinutos.Text);
                        DateTime reserva = new DateTime(prestamo.Year, prestamo.Month, prestamo.Day, hor, min, 0);
                        DateTime devRes = reserva.AddMinutes(minutos);
                        resultado = op.AgregarPrestamo(Convert.ToInt32(idusu), Convert.ToInt32(txtId.Text), reserva, devRes, status);
                        if (string.IsNullOrEmpty(resultado))
                        {
                            MessageBox.Show("El registro se he agregado correctamente");
                            this.Close();
                            MenuUsuarios frm = new MenuUsuarios();
                            frm.Show();
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {// Si el usuario no está registrado, abre formulario de registro
                MessageBox.Show("Usuario no registrado");
                Registro frm = new Registro();
                frm.Matricula = txtMatricula.Text;
                frm.Show();
            }
            
        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambia los minutos según la hora seleccionada
            switch (cbHora.Text)
            {
                case "07":
                    cbMinutos.Text = "";
                    cbMinutos.Enabled = true; //Habilita el combobox de minutos
                    break;
                case "08":
                    cbMinutos.Enabled = false;
                    cbMinutos.Text = "40";
                    break;
                case "09":
                    cbMinutos.Enabled = false;
                    cbMinutos.Text = "30";
                    break;
                case "10":
                    cbMinutos.Enabled = false;
                    cbMinutos.Text = "20";
                    break;
                case "11":
                    cbMinutos.Enabled = false;
                    cbMinutos.Text = "10";
                    break;
                case "12":
                    cbMinutos.Text = "";
                    cbMinutos.Enabled = true; //Habilita el combobox de minutos
                    break;
                case "13":
                    cbMinutos.Enabled = false;
                    cbMinutos.Text = "40";
                    break;
                case "14":
                    cbMinutos.Enabled = false;
                    cbMinutos.Text = "30";
                    break;
                case "15":
                    cbMinutos.Enabled = false;
                    cbMinutos.Text = "20";
                    break;
                default:
                    break;
            }
        }
    }

}
