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
        private List<int> depositos = new List<int>();

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

        private void ltbDepositos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbDepositos.SelectedItem != null)
            {
             

            }
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           Application.Restart();

        }

        private void ltbRetiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbRetiros.SelectedItem != null)
            {
                int retiro = (int)ltbRetiros.SelectedItem;
                MessageBox.Show(cuenta.retirar(retiro));
                txtSaldo.Text = cuenta.getSaldoInicial().ToString();
                txtSaldoActual.Text = cuenta.getMonto().ToString();

            }
        }

        private void txtSaldoActual_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void ltbDepositos_DoubleClick(object sender, EventArgs e)
        {
            if (ltbDepositos.Items.Count>0)
            {
                int ultimoDeposito = depositos[depositos.Count - 1];
                cuenta.retirar(ultimoDeposito);
                depositos.RemoveAt(depositos.Count - 1);    
                txtSaldo.Text = cuenta.getSaldoInicial().ToString();
                txtSaldoActual.Text = cuenta.getMonto().ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int deposito = (int)ltbDepositos.SelectedItem;
            MessageBox.Show(cuenta.depositar(deposito));
            depositos.Add(deposito);
            txtSaldo.Text = cuenta.getSaldoInicial().ToString();
            txtSaldoActual.Text = cuenta.getMonto().ToString();
        }
    }
}
