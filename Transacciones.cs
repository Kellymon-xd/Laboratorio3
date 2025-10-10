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
    public partial class Transacciones : Form
    {
        private CuentaBancaria cuenta;

        internal Transacciones(CuentaBancaria cuenta)
        {
            InitializeComponent();
            this.cuenta= cuenta;


        }

  

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if(rbDepositos.Checked==true)
            {


                Cuenta_de_Ahorros ahorro = new Cuenta_de_Ahorros(cuenta);
                ahorro.Show();

            }
            else if(rbRetiros.Checked==true)
            {
                
                Cuenta_de_Ahorros ahorro = new Cuenta_de_Ahorros(cuenta);
                ahorro.Show();

            }
        }

        private void rbDepositos_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
