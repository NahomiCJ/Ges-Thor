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

        private void btn_Reservar_Click(object sender, EventArgs e)
        {
            SolResRec ResRec = new SolResRec("Reservar");
            ResRec.Show();   //Crear un nuevo formulario SolResRec desde el boton del MenuUsuarios
            this.Hide();
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();   //Crear un nuevo formulario SolResRec desde el boton del MenuUsuarios
            this.Hide();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            Historial frm = new Historial();
            frm.Show();   //Crear un nuevo formulario SolResRec desde el boton del MenuUsuarios
            this.Hide();
        }
    }
}
