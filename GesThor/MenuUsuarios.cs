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
            // Al hacer clic en el botón "Solicitar", se abre el formulario SolResRec en modo "Solicitar"
            SolResRec SoliRec = new SolResRec("Solicitar");
            SoliRec.Show(); // Muestra el formulario de solicitud
            this.Hide();    // Oculta el menú principal para evitar múltiples ventanas abiertas
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        { 
            // Cierra toda la aplicación. Uso provisional mientras no se tenga un formulario de Login.
            Application.Exit();
        }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btn_Reservar_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón "Reservar", se abre el formulario SolResRec en modo "Reservar"
            SolResRec ResRec = new SolResRec("Reservar");
            ResRec.Show(); // Muestra el formulario de reserva
            this.Hide();   // Oculta el menú principal
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            // Abre el formulario de inventario (Form1)
            Form1 frm = new Form1();
            frm.Show(); // Muestra el formulario de inventario
            this.Hide(); // Oculta el menú principal
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el PictureBox (logo de GesThor), se abre el formulario Historial
            Historial frm = new Historial();
            frm.Show(); // Muestra el historial de préstamos o reservas
            this.Hide(); // Oculta el menú principal
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            // Abre el formulario de devoluciones desde el botón correspondiente
            Devolucion frm = new Devolucion();
            frm.Show(); // Muestra el formulario de devolución de recursos
            this.Hide(); // Oculta el menú principal
        }
    }
}
