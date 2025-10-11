using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Laboratorio3
{
    public partial class E2 : Form
    {
        private List<int> numeros = new List<int>();
        private Random random = new Random();
        public E2()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvNumbers.AllowUserToAddRows = false;
            dgvNumbers.AllowUserToDeleteRows = false;
            dgvNumbers.AllowUserToResizeRows = false;
            dgvNumbers.ReadOnly = true;
            dgvNumbers.RowHeadersVisible = false;
            dgvNumbers.ScrollBars = ScrollBars.Both;
            dgvNumbers.RowHeadersVisible=false;
            dgvNumbers.ColumnHeadersVisible = false;    
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numeroAEliminar))
            {
                int eliminados = numeros.RemoveAll(x => x == numeroAEliminar);

                if (eliminados > 0)
                {
                    MessageBox.Show($"Se eliminaron {eliminados} coincidencias del número {numeroAEliminar}.");
                    txtNumero.Clear();
                    txtNumero.Focus();
                    ActualizarGrid();
                }
                else
                {
                    MessageBox.Show("No se encontró el número en la lista.");
                }

            }
            else
            {
                MessageBox.Show("Ingrese un número válido para eliminar.");
            }
        }

        private void ActualizarGrid()
        {
            dgvNumbers.Columns.Clear();
            dgvNumbers.Rows.Clear();

            dgvNumbers.RowCount = 7;

            int totalNumbers = numeros.Count;
            int columnsNeeded = (int)Math.Ceiling(totalNumbers / 7.0);

            for (int col = 0; col < columnsNeeded; col++)
            {
                dgvNumbers.Columns.Add($"Column{col}", $"Col {col + 1}");
                dgvNumbers.Columns[col].Width = 80;
            }

            for (int i = 0; i < totalNumbers; i++)
            {
                int row = i % 7;
                int col = i / 7;

                if (col < dgvNumbers.ColumnCount && row < dgvNumbers.RowCount)
                {
                    dgvNumbers[col, row].Value = numeros[i];
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rdbAleatorio.Checked)
            {
                if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
                {
                    numeros.Clear();
                    for (int i = 0; i < cantidad; i++)
                    {
                        numeros.Add(random.Next(1, 101));
                    }
                    ActualizarGrid();
                    txtCantidad.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una cantidad de numeros aleatorios a ser ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (int.TryParse(txtNumero.Text, out int numero))
                {
                    numeros.Add(numero);
                    txtNumero.Clear();
                    txtNumero.Focus();
                    ActualizarGrid();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un numero valido", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rdbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbManual.Checked)
            {
                txtNumero.ReadOnly = false;
                txtNumero.BackColor = Color.White;
                txtCantidad.ReadOnly = true;
                txtCantidad.BackColor = Color.LightGray;
                txtCantidad.Clear();

            }
        }

        private void rdbAleatorio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAleatorio.Checked)
            {
                txtNumero.ReadOnly = true;
                txtNumero.BackColor = Color.LightGray;
                txtCantidad.ReadOnly = false;
                txtCantidad.BackColor = Color.White;
                txtNumero.Clear();

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            {
                numeros.Clear();
                ActualizarGrid();
                MessageBox.Show("Borrar lista de numeros!!",
                    "Hermano! Has borrado la lista de numeros!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}