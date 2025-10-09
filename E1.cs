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
            CuentaBancaria cuenta=new CuentaBancaria();
            nombre =txtCliente.Text;
            monto=Convert.ToInt32(txtMonto.Text);
            cuenta.asignar(nombre, monto); 
            
            Transacciones transacciones = new Transacciones();
            transacciones.Show();


        }
    }
}
