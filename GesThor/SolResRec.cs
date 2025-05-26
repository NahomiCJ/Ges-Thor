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
            //if (modo_ == "Solicitar")
            //{
            //    dtpFecha.Enabled = false;
            //}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuUsuarios frm1 = new MenuUsuarios();
            frm1.Show();
            this.Hide();
        }

        private void dgvInv_SelectionChanged(object sender, EventArgs e)
        {
            //string temp;
            if (dgvInv.SelectedRows.Count > 0)
            {
                DataGridViewRow select = dgvInv.SelectedRows[0];

                if (select != null && !string.IsNullOrEmpty(select.Cells[0].Value.ToString()))
                {
                    txtId.Text = select.Cells[0].Value.ToString();
                    txtNombre.Text = select.Cells[1].Value.ToString();
                    cbEstado.Text = select.Cells[3].Value.ToString();
                    //temp = select.Cells[3].Value.ToString();
                    //dtpFecha.Value = Convert.ToDateTime(temp);

                }

            }
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            string idusu = op.ConsultaUsuario(txtMatricula.Text);
            string resultado, status = "Activo";
            resultado = op.AgregarPrestamo(Convert.ToInt32(idusu), Convert.ToInt32(txtId.Text), dtpFecha.Value, status);
            if (string.IsNullOrEmpty(resultado))
            {
                MessageBox.Show("El registro se he agregado correctamente");
                this.Close();
                MenuUsuarios frm = new MenuUsuarios();
                frm.Show();
            }
            //switch (modo_)
            //{
            //    case "Solicitar":
            //        break;
            //    case "Reservar":
            //        break;
            //    default:
            //        break;
            //}
        }
    }

}
