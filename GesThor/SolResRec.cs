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
        Operacion op = new Operacion();
        public string modo_;
        public SolResRec(string modo)
        {
            InitializeComponent();
            modo_ = modo;
        }

        private void SolResRec_Load(object sender, EventArgs e)
        {
            dgvInv.DataSource = op.Cargar();
            this.Text = modo_;
            lbl1.Text = modo_;
            btnSol.Text = modo_;
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            cbEstado.Enabled = false;
            cbMinutos.Enabled = false;
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
            }
 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuUsuarios frm1 = new MenuUsuarios();
            frm1.Show();
            this.Hide();
        }

        private void dgvInv_SelectionChanged(object sender, EventArgs e)
        {
            string temp;
            if (dgvInv.SelectedRows.Count > 0)
            {
                DataGridViewRow select = dgvInv.SelectedRows[0];

                if (select != null && !string.IsNullOrEmpty(select.Cells[0].Value.ToString()))
                {

                    temp = select.Cells[4].Value.ToString();

                    if (Convert.ToBoolean(temp))
                    {
                        txtId.Text = select.Cells[0].Value.ToString();
                        txtNombre.Text = select.Cells[1].Value.ToString();
                        cbEstado.Text = select.Cells[3].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El recurso no esta disponible en este momento");
                    }

                }

            }
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            string mat = txtMatricula.Text;
            if (op.BuscarUsuario(mat))
            {
                string idusu = op.ConsultaUsuario(mat);
                string resultado, status = "Activo";
                DateTime prestamo = dtpFecha.Value;
                int minutos = 50 * (Convert.ToInt32(numHoras.Value));
                //int minutos = 50 * (Convert.ToInt32(numHoras.Value));
                //DateTime dev = dtpFecha.Value.AddMinutes(minutos);
                //resultado = op.AgregarPrestamo(Convert.ToInt32(idusu), Convert.ToInt32(txtId.Text), dev, status);
                //if (string.IsNullOrEmpty(resultado))
                //{
                //    MessageBox.Show("El registro se he agregado correctamente");
                //    this.Close();
                //    MenuUsuarios frm = new MenuUsuarios();
                //    frm.Show();
                //}
                switch (modo_)
                {
                    case "Solicitar":
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
            {
                MessageBox.Show("Usuario no registrado");
                Registro frm = new Registro();
                frm.Matricula = txtMatricula.Text;
                frm.Show();
            }
            
        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbHora.Text)
            {
                case "07":
                    cbMinutos.Text = "";
                    cbMinutos.Enabled = true;
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
                    cbMinutos.Enabled = true;
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
