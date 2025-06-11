using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GesThor
{
    public partial class Devolucion: Form
    {
        Operacion op = new Operacion(); // Se crea una instancia de la clase Operacion, que contiene métodos para interactuar con la base de datos
        public Devolucion()
        {
            InitializeComponent();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            // Se cargan en el DataGridView todos los préstamos activos que aún no han sido devueltos
            dgvInv.DataSource = op.BuscarPrestamosActRet();
            dgvInv.Columns[0].Visible = false;


            // Se deshabilitan los campos para evitar que el usuario los edite manualmente
            txtId.Enabled = false;
            txtNombre.Enabled = false;
            txtEstado.Enabled = false;
            txtMatricula.Enabled = false;
            dtpFecha.Enabled = false;
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            // Variable para almacenar el resultado y definir el nuevo estado
            string resultado, estado = "Devuelto";
            //Preguntar antes de devolver
            var confirm = MessageBox.Show("¿Deseas registrar la devolución?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes) 
            {
                // Se llama al método que actualiza el préstamo como devuelto
                resultado = op.DevolverPres(Convert.ToInt32(txtId.Text.Trim()), dtpFecha.Value, estado);
                // Si no hay errores (resultado vacío), se notifica al usuario
                if (string.IsNullOrEmpty(resultado))
                {
                    MessageBox.Show("El registro se he agregado correctamente");
                    // Se cierra este formulario y se regresa al menú principal
                    this.Close(); 
                }
            }

            
        }

        // Evento que se ejecuta cuando se cambia la selección de filas en el DataGridView
        private void dgvInv_SelectionChanged(object sender, EventArgs e)
        {
            string temp;
            // Se asegura de que al menos una fila esté seleccionada
            if (dgvInv.SelectedRows.Count > 0)
            {
                DataGridViewRow select = dgvInv.SelectedRows[0];

                // Verifica que no esté vacía la celda clave (id del préstamo)
                if (select != null && !string.IsNullOrEmpty(select.Cells[0].Value.ToString()))
                {
                    // Llena los campos del formulario con la información seleccionada
                    txtId.Text = select.Cells[0].Value.ToString();
                    txtNombre.Text = select.Cells[4].Value.ToString();
                    txtEstado.Text = select.Cells[8].Value.ToString();
                    txtMatricula.Text = select.Cells[1].Value.ToString();
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
