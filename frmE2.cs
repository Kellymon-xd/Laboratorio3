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
        private Random random = new Random();
        private GestorNumeros gestorNum = new GestorNumeros();
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
            if (gestorNum.getNumeros() == null || gestorNum.getNumeros().Count == 0)
            {
                MessageBox.Show("No hay números para eliminar.");
                return;
            }
            else if (gestorNum.eliminarNum(this))
            {
                txtNumero.Clear();
                txtNumero.Focus();
                ActualizarGrid();
            }
        }


        private void ActualizarGrid()
        {
            gestorNum.ActualizarGrids(dgvNumbers);
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
            {
                if (rdbAleatorio.Checked)
                {
                    gestorNum.agregarNumAleatorio(cantidad);
                    ActualizarGrid();
                    txtCantidad.Clear();
                }

                else if (rdbManual.Checked)
                {   
                    if (gestorNum.agregarNumManual(cantidad, this)) {
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
                gestorNum.getNumeros().Clear();
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
                gestorNum.getNumeros().Add(numero);
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