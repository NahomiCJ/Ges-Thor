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
        //SolResRec ResRec = new SolResRec("Reservar");
        Form1 Inv = new Form1();
        Historial His = new Historial();
        Devolucion Dev = new Devolucion();
        string modo_;
        public MenuUsuarios(string modo)
        {
            InitializeComponent();
            modo_ = modo;
        }

        private void btn_FormSolicitar_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón "Solicitar", se abre el formulario SolResRec en modo "Solicitar"
            this.Hide();// Oculta el menú principal para evitar múltiples ventanas abiertas
            SolResRec SoliRec = new SolResRec("Solicitar");
            SoliRec.ShowDialog(); // Muestra el formulario de solicitud
            this.Show();    // Mostrar menú principal 
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        { 
            // Cierra toda la aplicación. Uso provisional mientras no se tenga un formulario de Login.
            Application.Exit();
        }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {
            if (modo_ == "Usuario")
            {
                textBox1.Visible = false;
                btn_Inventario.Enabled = false;
                btn_Inventario.Visible = false;
                pictureBox4.Visible = false;
            }
        }

        private void btn_Reservar_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón "Reservar", se abre el formulario SolResRec en modo "Reservar"
            this.Hide();   // Oculta el menú principal
            SolResRec ResRec = new SolResRec("Reservar");
            ResRec.ShowDialog(); // Muestra el formulario de reserva
            this.Show();    // Mostrar menú principal
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el botón "Inventario", Abre el formulario de inventario (Form1)
            this.Hide(); // Oculta el menú principal
            Inv.ShowDialog(); // Muestra el formulario de inventario
            this.Show();    // Mostrar menú principal
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el PictureBox (logo de GesThor), se abre el formulario Historial
            this.Hide(); // Oculta el menú principal
            His.ShowDialog(); // Muestra el historial de préstamos o reservas
            this.Show();    // Mostrar menú principal
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            // Abre el formulario de devoluciones desde el botón correspondiente
            this.Hide();// Oculta el menú principal
            Dev.ShowDialog(); // Muestra el formulario de devolución de recursos
            this.Show();  // Mostrar menú principal
        }
    }
}
