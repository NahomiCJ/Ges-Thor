using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesThor
{
    public partial class Form1: Form
    {
        AddModEquipo frm; //Crea una nueva instancia del formulario AddModEquipo
        Operacion op = new Operacion(); //Se crea una instancia de la clase Operacion, que contiene la lógica para interactuar con la base de datos.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvInventario.DataSource = op.Cargar(); //Llama al método Cargar() de la clase Operacion para llenar el DataGridView
            dgvInventario.Columns[0].Visible = false;
        }

        private void btnAg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm = new AddModEquipo(btnAg.Text); // Pasa el texto del botón ("Agregar") como parámetro 
            frm.ShowDialog();
            this.Show();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dgvInventario.CurrentCell.ToString()))
            {
                this.Hide();
                frm = new AddModEquipo(btnMod.Text); //Pasa el texto del botón ("Modificar") como parámetro 
                frm.Id = Convert.ToInt32(dgvInventario.CurrentRow.Cells["ID"].Value); //Extrae los valores de la fila seleccionada del DataGridView y los asigna a las propiedades del formulario frm.
                frm.Nombre = dgvInventario.CurrentRow.Cells["Nombre"].Value.ToString();
                frm.Cantidad = Convert.ToInt32(dgvInventario.CurrentRow.Cells["Cantidad"].Value);
                frm.Estado = dgvInventario.CurrentRow.Cells["Estado"].Value.ToString();
                frm.Disponibilidad = Convert.ToBoolean(dgvInventario.CurrentRow.Cells["Disponibilidad"].Value);
                frm.Show(); //Muestra el formulario prellenado con los datos del equipo seleccionado para su modificación
                this.Show();
            }
            else {

            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierra el formulario
        }

    }
}
