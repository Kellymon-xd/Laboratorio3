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
    public partial class frmE2 : Form
    {
        private List<int> numeros = new List<int>();
        private Random random = new Random();
        public frmE2()
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
            if (numeros == null || numeros.Count == 0)
            {
                MessageBox.Show("No hay números para eliminar.");
                return;
            }

            Dialogo dlgEliminar = new Dialogo();
            dlgEliminar.Titulo = "Ingrese el número a eliminar:";

            dlgEliminar.AplicarEstiloForm(this);
            dlgEliminar.AplicarEstiloBoton(dlgEliminar, Color.LavenderBlush);

            if (dlgEliminar.ShowDialog() == DialogResult.OK)
            {
                int numeroEliminar;
                if (int.TryParse(dlgEliminar.ValorIngresado, out numeroEliminar)
                    && numeros.Contains(numeroEliminar))
                {
                    var resultado = MessageBox.Show(
                        $"¿Está seguro que desea eliminar el número {numeroEliminar}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        int eliminados = numeros.RemoveAll(x => x == numeroEliminar);

                        if (eliminados > 0)
                        {
                            MessageBox.Show($"Se eliminaron {eliminados} coincidencias del número {numeroEliminar}.");
                            txtNumero.Clear();
                            txtNumero.Focus();
                            ActualizarGrid();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el número en la lista.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Número inválido o no encontrado.");
                }
            }
        }


        private void ActualizarGrid()
        {
            dgvNumbers.Columns.Clear();
            dgvNumbers.Rows.Clear();

            dgvNumbers.ColumnHeadersVisible = false;
            dgvNumbers.RowHeadersVisible = false;

            int totalNumbers = numeros.Count;
            int filas = 7;

            int columnas = (int)Math.Ceiling(totalNumbers / (double)filas);
            if (columnas == 0) columnas = 1;

            for (int c = 0; c < columnas; c++)
                dgvNumbers.Columns.Add($"col{c}", "");

            dgvNumbers.RowCount = filas;

            for (int i = 0; i < totalNumbers; i++)
            {
                int row = i / columnas;
                int col = i % columnas; 

                if (row < filas && col < columnas)
                    dgvNumbers[col, row].Value = numeros[i];
            }

            dgvNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int altoFila = dgvNumbers.ClientSize.Height / filas;
            foreach (DataGridViewRow row in dgvNumbers.Rows)
                row.Height = altoFila;
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
            {
                if (rdbAleatorio.Checked)
                {

                    numeros.Clear();
                    for (int i = 0; i < cantidad; i++)
                    {
                        numeros.Add(random.Next(1, 101));
                    }
                    ActualizarGrid();
                    txtCantidad.Clear();
                }

                else if (rdbManual.Checked)
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        Dialogo dlgNumero = new Dialogo();
                        dlgNumero.Titulo = $"Ingrese el valor No. {i + 1}:";
                        dlgNumero.AplicarEstiloForm(this);
                        dlgNumero.AplicarEstiloBoton(dlgNumero, Color.LavenderBlush);

                        if (dlgNumero.ShowDialog() == DialogResult.OK)
                        {
                            if (int.TryParse(dlgNumero.ValorIngresado, out int valor) && valor > 0)
                            {
                                numeros.Add(valor);
                            }
                            else
                            {
                                MessageBox.Show("Número inválido, intente de nuevo.");
                                i--;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Entrada cancelada.");
                            cantidad = 0;
                            break;

                        }
                    }
                    if (cantidad != 0) {
                        txtNumero.Clear();
                        txtNumero.Focus();
                        ActualizarGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad de numeros a ser ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbAgregarNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAgregarNumero.Checked)
            {
                lblNumeroIndividual.Visible = true;
                lblNumeroIndividual.Enabled = true;
                txtNumero.Visible = true;
                txtNumero.Enabled = true;
                btnAgregar.Enabled = true;
                btnAgregar.Visible = true;
                txtNumero.ReadOnly = false;
                txtNumero.BackColor = Color.White;
                txtCantidad.ReadOnly = true;
                txtCantidad.BackColor = Color.LightGray;
                txtCantidad.ReadOnly = true;
                txtCantidad.Enabled = false;
                txtCantidad.Visible = false;
                lblCantidadAleatoria.Visible = false;
                txtCantidad.Clear();
            }
            else
            {
                lblNumeroIndividual.Visible = false;
                lblNumeroIndividual.Enabled = false;
                txtNumero.Visible = false;
                txtNumero.Enabled = false;
                btnAgregar.Enabled = false;
                btnAgregar.Visible = false;
                txtCantidad.Visible = true;
                lblCantidadAleatoria.Visible = true;

            }
        }

        private void rdbAleatorio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAleatorio.Checked)
            {
                txtNumero.ReadOnly = true;
                txtNumero.BackColor = Color.LightGray;
                txtCantidad.ReadOnly = false;
                txtCantidad.Enabled = true;
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

        private void btnAgregar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Por favor, ingrese un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbManual.Checked)
            {
                txtCantidad.ReadOnly = false;
                txtCantidad.Enabled = true;
                txtNumero.ReadOnly = true;
                txtNumero.BackColor = Color.LightGray;
                txtCantidad.BackColor = Color.White;
                txtNumero.Clear();

            }
        }
    }
}