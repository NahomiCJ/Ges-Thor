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
    public partial class SolResRec: Form
    {
        Operacion op = new Operacion();
        public string modo_;
        public SolResRec(string modo)
        {
            InitializeComponent();
        }

        private void SolResRec_Load(object sender, EventArgs e)
        {
            dgvInv.DataSource = op.Cargar();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
