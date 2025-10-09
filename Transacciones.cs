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
    public partial class Transacciones : Form
    {
        public Transacciones()
        {
            InitializeComponent();
            
         
        }

  

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if(rbDepositos.Checked==true)
            {
                CuentaBancaria depositos = new CuentaBancaria();
               
                depositos.depositar();
                Cuenta_de_Ahorros cuenta = new Cuenta_de_Ahorros();
                cuenta.Show();

            }
            else if(rbRetiros.Checked==true)
            {
                CuentaBancaria retiros = new CuentaBancaria();
                retiros.retirar();
                Cuenta_de_Ahorros cuenta = new Cuenta_de_Ahorros();
                cuenta.Show();

            }
        }

        private void rbDepositos_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
