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
    public partial class Form1: Form
    {
        Operacion op = new Operacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvInventario.DataSource = op.Cargar();
        }

        private void btnAg_Click(object sender, EventArgs e)
        {
            AddModEquipo frm = new AddModEquipo(btnAg.Text);
            frm.Show();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            AddModEquipo frm = new AddModEquipo(btnMod.Text);
            frm.Id = Convert.ToInt32(dgvInventario.CurrentRow.Cells["ID"].Value);
            frm.Nombre = dgvInventario.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.Cantidad = Convert.ToInt32(dgvInventario.CurrentRow.Cells["Cantidad"].Value);
            frm.Estado = dgvInventario.CurrentRow.Cells["Estado"].Value.ToString();
            frm.Disponibilidad = Convert.ToBoolean(dgvInventario.CurrentRow.Cells["Disponibilidad"].Value);
            frm.Show();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolResRec frm = new SolResRec("Solicitar");
            frm.Show();
            this.Hide ();

        }
    }
}
