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
        Operacion op = new Operacion(); //Se crea una instancia de la clase Operacion, que contiene la lógica para interactuar con la base de datos.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvInventario.DataSource = op.Cargar(); //Llama al método Cargar() de la clase Operacion para llenar el DataGridView
        }

        private void btnAg_Click(object sender, EventArgs e)
        {
            AddModEquipo frm = new AddModEquipo(btnAg.Text); //Crea una nueva instancia del formulario AddModEquipo pasando el texto del botón ("Agregar") como parámetro 
            frm.Show();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            AddModEquipo frm = new AddModEquipo(btnMod.Text); //Crea una instancia del formulario AddModEquipo, pero esta vez como modificación
            frm.Id = Convert.ToInt32(dgvInventario.CurrentRow.Cells["ID"].Value); //Extrae los valores de la fila seleccionada del DataGridView y los asigna a las propiedades del formulario frm.
            frm.Nombre = dgvInventario.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.Cantidad = Convert.ToInt32(dgvInventario.CurrentRow.Cells["Cantidad"].Value);
            frm.Estado = dgvInventario.CurrentRow.Cells["Estado"].Value.ToString();
            frm.Disponibilidad = Convert.ToBoolean(dgvInventario.CurrentRow.Cells["Disponibilidad"].Value);
            frm.Show(); //Muestra el formulario prellenado con los datos del equipo seleccionado para su modificación


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra la aplicación completamente.
        }

    }
}
