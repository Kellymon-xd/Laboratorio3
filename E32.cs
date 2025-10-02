using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3
{
    public partial class Dialogo : Form
    {
        public string ValorIngresado { get; private set; }

        public Dialogo()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ValorIngresado = txtInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public string Titulo
        {
            get { return lblTitle.Text; }   // Getter
            set { lblTitle.Text = value; }  // Setter
        }
    }
}
