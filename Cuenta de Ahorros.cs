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
    public partial class Cuenta_de_Ahorros : Form
    {
        private CuentaBancaria cuenta;
        private List<int> depositosRealizados = new List<int>();
        private List<int> retirosRealizados = new List<int>();

        internal Cuenta_de_Ahorros(CuentaBancaria cuenta)
        {

            InitializeComponent();
            this.cuenta = cuenta;


            ltbDepositos.SelectionMode = SelectionMode.One;
            ltbRetiros.SelectionMode = SelectionMode.One;

            txtSaldo.Text = cuenta.getSaldoInicial().ToString();
            txtSaldoActual.Text = cuenta.getMonto().ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Application.Restart();

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


        private void rbDepositos_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDepositar.Text, out int montoDeposito) && montoDeposito > 0)
            {
                MessageBox.Show(cuenta.depositar(montoDeposito));
                depositosRealizados.Add(montoDeposito);
                ltbDepositos.Items.Add(montoDeposito);
                txtSaldoActual.Text = cuenta.getMonto().ToString();
                txtDepositar.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido para depositar.");
            }
        }

        private void rbRetiros_Click(object sender, EventArgs e)
        {
           if(int.TryParse(txtRetirar.Text, out int montoRetiro) && montoRetiro > 0)
            {
                string resultadoRetiro = cuenta.retirar(montoRetiro);
                if (resultadoRetiro.StartsWith("Retiro exitoso"))
                {
                    MessageBox.Show(resultadoRetiro);
                    retirosRealizados.Add(montoRetiro);
                    ltbRetiros.Items.Add(montoRetiro);
                    txtSaldoActual.Text = cuenta.getMonto().ToString();
                    txtRetirar.Clear();
                }
                else
                {
                    MessageBox.Show(resultadoRetiro); 
                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto válido para retirar.");
            }
        }

       
    }
}
