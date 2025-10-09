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
        private CuentaBancaria obj;
        public Cuenta_de_Ahorros()
        {
           
            InitializeComponent();
           



            ltbDepositos.Items.Add(50); 
            ltbDepositos.Items.Add(100);
            ltbDepositos.Items.Add(200);
            ltbRetiros.Items.Add(50);
            ltbRetiros.Items.Add(100);
            ltbRetiros.Items.Add(150);

            ltbDepositos.SelectionMode = SelectionMode.One;
            ltbRetiros.SelectionMode = SelectionMode.One;

          



        }

        private void ltbDepositos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbDepositos.SelectedItem != null)
            {
                int deposito = (int)ltbDepositos.SelectedItem;
            

            
               
               
            }
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
          

        }

        private void ltbRetiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbRetiros.SelectedItem != null)
            {
                int retiro = (int)ltbRetiros.SelectedItem;
               
             
              
            }
        }
    }
}
