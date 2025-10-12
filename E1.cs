using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3
{
    public partial class E1 : Form
    {
        private CuentaBancaria cuenta;
        private List<int> depositosRealizados = new List<int>();
        private List<int> retirosRealizados = new List<int>();
        public E1()
        {
            InitializeComponent();
        }
        private void btnAbrirCuenta_Click(object sender, EventArgs e)
        {
            string nombre = txtCliente.Text.Trim();
            string textoMonto = txtMonto.Text.Trim();


            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textoMonto))
            {
                MessageBox.Show("Debe ingresar el monto inicial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

           
            if (!int.TryParse(textoMonto, out int monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus();
                return;
            }

            this.cuenta = new CuentaBancaria(nombre, monto);

            txtSaldo.Text = cuenta.getSaldoInicial().ToString();
            txtSaldoActual.Text = cuenta.getMonto().ToString();

            MessageBox.Show($"Cuenta creada para {nombre} con un saldo inicial de {monto}.",
                            "Cuenta abierta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAbrirCuenta.Enabled = false;
        }

        private void txtCliente_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCliente.Text))
            {
                e.Cancel = true;
                txtCliente.Focus();
                MessageBox.Show("El nombre del cliente es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                e.Cancel = false;

            }
        }
        private void txtMonto_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtMonto.Text, out int monto) || monto <= 0)
            {
                e.Cancel = true;
                MessageBox.Show("El monto inicial debe ser un número mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                e.Cancel = false;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            if (cuenta == null)
            {
                MessageBox.Show("Primero debe abrir una cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dialogo dlgMonto = new Dialogo();
            dlgMonto.AplicarEstiloForm(this);
            dlgMonto.AplicarEstiloBoton(dlgMonto, Color.White);
            if (rbDepositos.Checked)
            {
                dlgMonto.Titulo = $"Ingrese monto a depositar:";
            }
            else if (rbRetiros.Checked)
            {
                dlgMonto.Titulo = $"Ingrese monto a retirar:";
            }
            else {
                MessageBox.Show("Seleccione una operación (Depósito o Retiro).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dlgMonto.ShowDialog() == DialogResult.OK)
            {
                if (int.TryParse(dlgMonto.ValorIngresado, out int montoOperacion) || montoOperacion > 0)
                {
                    if (rbDepositos.Checked)
                    {
                        string resultado = cuenta.depositar(montoOperacion);
                        depositosRealizados.Add(montoOperacion);
                        ltbDepositos.Items.Add(montoOperacion);
                        txtSaldoActual.Text = cuenta.getMonto().ToString();
                        MessageBox.Show(resultado, "Depósito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (rbRetiros.Checked)
                    {
                        string resultado = cuenta.retirar(montoOperacion);
                        if (resultado.StartsWith("Retiro exitoso"))
                        {
                            retirosRealizados.Add(montoOperacion);
                            ltbRetiros.Items.Add(montoOperacion);
                            txtSaldoActual.Text = cuenta.getMonto().ToString();
                        }
                        MessageBox.Show(resultado, "Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un monto válido mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Entrada cancelada.");

            }
        }
        private void ltbDepositos_DoubleClick(object sender, EventArgs e)
        {
            if (ltbDepositos.SelectedItem != null)
            {
                int monto = (int)ltbDepositos.SelectedItem;

                DialogResult confirm = MessageBox.Show(
                    $"¿Desea anular el depósito de {monto}?",
                    "Confirmar anulación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    cuenta.retirar(monto);
                    depositosRealizados.Remove(monto);
                    ltbDepositos.Items.Remove(ltbDepositos.SelectedItem);
                    txtSaldoActual.Text = cuenta.getMonto().ToString();
                    MessageBox.Show($"Depósito de {monto} anulado correctamente.");
                }
            }
        }
        private void ltbRetiros_DoubleClick(object sender, EventArgs e)
        {
            if (ltbRetiros.SelectedItem != null)
            {
                int monto = (int)ltbRetiros.SelectedItem;

                DialogResult confirm = MessageBox.Show(
                    $"¿Desea anular el retiro de {monto}?",
                    "Confirmar anulación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    cuenta.depositar(monto);
                    retirosRealizados.Remove(monto);
                    ltbRetiros.Items.Remove(ltbRetiros.SelectedItem);
                    txtSaldoActual.Text = cuenta.getMonto().ToString();
                    MessageBox.Show($"Retiro de {monto} anulado correctamente.");
                }
            }
        }
    }
}