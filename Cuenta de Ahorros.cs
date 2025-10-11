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


            ltbDepositos.Items.Add(50);
            ltbDepositos.Items.Add(100);
            ltbDepositos.Items.Add(200);
            ltbRetiros.Items.Add(50);
            ltbRetiros.Items.Add(100);
            ltbRetiros.Items.Add(150);

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
                int depositoSeleccionado = (int)ltbDepositos.SelectedItem;

             
                if (depositosRealizados.Count > 0 && depositosRealizados.Last() == depositoSeleccionado)
                {
                    cuenta.retirar(depositoSeleccionado); 
                    depositosRealizados.RemoveAt(depositosRealizados.Count - 1); 
                    txtSaldoActual.Text = cuenta.getMonto().ToString();
                    MessageBox.Show($"Depósito de {depositoSeleccionado} anulado.");
                }
                else
                {
                    MessageBox.Show("Solo se puede anular el último depósito realizado y que coincida con el monto seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("No hay depósitos seleccionados.");
            }
        }


        private void ltbRetiros_DoubleClick(object sender, EventArgs e)
        {
            if (ltbRetiros.SelectedItem != null)
            {
                int retiroSeleccionado = (int)ltbRetiros.SelectedItem;

                
                if (retirosRealizados.Count > 0 && retirosRealizados.Last() == retiroSeleccionado)
                {
                    cuenta.depositar(retiroSeleccionado); 
                    retirosRealizados.RemoveAt(retirosRealizados.Count - 1); 
                    txtSaldoActual.Text = cuenta.getMonto().ToString();
                    MessageBox.Show($"Retiro de {retiroSeleccionado} anulado.");
                }
                else
                {
                    MessageBox.Show("Solo se puede anular el último retiro realizado y que coincida con el monto seleccionado.");
                }
            }
        }


        private void rbDepositos_Click(object sender, EventArgs e)
        {
            if (ltbDepositos.SelectedItem != null)
            {
                int deposito = (int)ltbDepositos.SelectedItem;
                MessageBox.Show(cuenta.depositar(deposito));
                depositosRealizados.Add(deposito);
                txtSaldoActual.Text = cuenta.getMonto().ToString();
            }
        }

        private void rbRetiros_Click(object sender, EventArgs e)
        {
            if (ltbRetiros.SelectedItem != null)
            {
                int retiro = (int)ltbRetiros.SelectedItem;
                MessageBox.Show(cuenta.retirar(retiro));
                retirosRealizados.Add(retiro);
                txtSaldoActual.Text = cuenta.getMonto().ToString();
            }
        }
    }
}
