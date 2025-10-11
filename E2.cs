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
        private const int maximoFila = 7;

        public E2()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarGrid()
        {
            int totalNumeros = numeros.Count;
            int columnasNecesarias = (int)Math.Ceiling((double)totalNumeros / maximoFila);
            for(int c = 0; c < columnasNecesarias; c++)
            {
                dgvNumbers.Columns.Add($"Columna{c}", $"Col {c + 1}");
            }
            for(int fila = 0; fila < maximoFila; fila++)
            {
                dgvNumbers.Rows.Add();
            }
            int index = 0;
            for (int col = 0; col < columnasNecesarias; col++)
            {
                for (int fila = 0; fila < maximoFila; fila++)
                {
                    if(index < totalNumeros)
                    {
                        dgvNumbers.Rows[fila].Cells[col].Value = numeros[index];
                        index++;
                    }
                    else { break; }
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rdbAleatorio.Checked)
            {
                if(int.TryParse(txtCantidad.Text,out int cantidad) && cantidad > 0)
                {
                    numeros.Clear();
                    for (int i =0; i <cantidad; i++)
                    {
                        numeros.Add(random.Next(1,101));
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
                if(int.TryParse(txtNumero.Text, out int numero))
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
            }
        }
    }
}
