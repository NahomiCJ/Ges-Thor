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
    public partial class Devolucion: Form
    {
        Operacion op = new Operacion();
        public Devolucion()
        {
            InitializeComponent();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            dgvInv.DataSource = op.BuscarPrestamosActRet();
           
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            cbEstado.Enabled = false;
            
           
        }
    }
}
