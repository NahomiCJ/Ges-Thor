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
    public partial class MenuUsuarios : Form
    {
        public MenuUsuarios()
        {
            InitializeComponent();
        }

        private void btn_FormSolicitar_Click(object sender, EventArgs e)
        {
            SolResRec SoliRec = new SolResRec("Solicitar");
            SoliRec.Show();   //Crear un nuevo formulario SolResRec desde el boton del MenuUsuarios
            this.Hide();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {

            Application.Exit(); //Cerrar Aplicacion 
        }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
