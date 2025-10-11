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
        public E1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbrirCuenta_Click(object sender, EventArgs e)
        {
            String nombre;
            int monto;

            nombre = txtCliente.Text;
            monto = Convert.ToInt32(txtMonto.Text);
            CuentaBancaria cuenta = new CuentaBancaria(nombre, monto);

            Cuenta_de_Ahorros obj=new Cuenta_de_Ahorros(cuenta);
            obj.Show();

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
    }
}
