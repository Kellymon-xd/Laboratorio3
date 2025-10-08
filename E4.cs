using Laboratorio3;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio3
{
    public partial class E4 : Form
    {
        ValidarCampos validadorCampos = new ValidarCampos();

        public E4()
        {
            InitializeComponent();
            pnlReq.Visible = false;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Debe llenar todos los campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ValidarCorreo validadorCorreo = new ValidarCorreo();
            ValidarContraseña validadorContraseña = new ValidarContraseña();

            bool correoValido = validadorCorreo.EsValido(txtCorreo.Text);
            bool contraseñaValida = validadorContraseña.EsValido(txtContraseña.Text);

            if (!correoValido)
            {
                MessageBox.Show("El correo no cumple con los requisitos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!contraseñaValida)
            {
                MessageBox.Show("La contraseña no cumple con los requisitos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (correoValido && contraseñaValida)
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                MessageBox.Show($"Bienvenido/a, {nombre} {apellido}.");
            }
        }

        // EVENTOS ENTER -------------------------------------------------------------------
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            pnlReq.Visible = false;
            grpCor.Visible = false;
            grpPass.Visible = false;
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            pnlReq.Visible = false;
            grpCor.Visible = false;
            grpPass.Visible = false;
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            pnlReq.Visible = true;
            grpCor.Visible = true;
            grpPass.Visible = false;
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            pnlReq.Visible = true;
            grpCor.Visible = false;
            grpPass.Visible = true;
        }

        // EVENTO VALIDATING ----------------------------------------------------------------
        private void ValidarCampoObligatorio(TextBox campo, CancelEventArgs e)
        {
            if (!validadorCampos.EsValido(campo.Text))
            {
                e.Cancel = true;
                erpError.SetError(campo, "No puede dejar el campo en blanco.");
            }
            else
            {
                erpError.SetError(campo, "");
            }
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampoObligatorio((TextBox)sender, e);
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            ValidarCampoObligatorio((TextBox)sender, e);
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            ValidarCorreo validador = new ValidarCorreo();

            if (!validador.EsValido(txtCorreo.Text))
            {
                e.Cancel = true;
                erpError.SetError(txtCorreo, "El correo no cumple con los requisitos.");
            }
            else
            {
                erpError.SetError(txtCorreo, "");
            }
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            ValidarContraseña validador = new ValidarContraseña();

            if (!validador.EsValido(txtContraseña.Text))
            {
                e.Cancel = true;
                erpError.SetError(txtContraseña, "La contraseña no cumple con los requisitos.");
            }
            else
            {
                erpError.SetError(txtContraseña, "");
            }
        }

        // EVENTOS KEYPRESS, KEYDOWN, KEYUP ------------------------------------------------
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                MessageBox.Show("Aquí no está tu contraseña. (✿◡‿◡)");
            }
        }

        private void txtCorreo_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateGrpReqCorreo(txtCorreo.Text);
        }

        private void txtContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateGrpReqPass(txtContraseña.Text);
        }

        //----------------------------------------------------------------------------------
        private void UpdateGrpReqCorreo(string correo)
        {
            int arrobas = correo.Count(c => c == '@');
            int posicionArroba = correo.IndexOf('@');
            string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@utp.ac.pa", "GMAIL.COM", "HOTMAIL.COM", "UTP.AC.PA" };

            lblReqCor1.Text = arrobas == 1
                ? "✔️ Solo un '@'."
                : "❌ Solo un '@'.";
            lblReqCor1.ForeColor = arrobas == 1
                ? Color.Green
                : Color.Red;

            lblReqCor2.Text = posicionArroba > 0
                ? "✔️ Al menos un carácter antes del '@'."
                : "❌ Al menos un carácter antes del '@'.";
            lblReqCor2.ForeColor = posicionArroba > 0
                ? Color.Green
                : Color.Red;

            lblReqCor3.Text = dominiosPermitidos.Any(d => correo.EndsWith(d, StringComparison.OrdinalIgnoreCase))
                ? "✔️ Terminar en: @gmail.com, @hotmail.com, @utp.ac.pa"
                : "❌ Terminar en: @gmail.com, @hotmail.com, @utp.ac.pa";
            lblReqCor3.ForeColor = dominiosPermitidos.Any(d => correo.EndsWith(d, StringComparison.OrdinalIgnoreCase))
                ? Color.Green
                : Color.Red;
        }

        private void UpdateGrpReqPass(string pass)
        {
            lblReqPass1.Text = pass.Length >= 12
                ? "✔️ Mínimo 12 caracteres."
                : "❌ Mínimo 12 caracteres.";
            lblReqPass1.ForeColor = pass.Length >= 12
                ? Color.Green
                : Color.Red;

            lblReqPass2.Text = pass.Any(char.IsUpper)
                ? "✔️ 1 mayúscula."
                : "❌ 1 mayúscula.";
            lblReqPass2.ForeColor = pass.Any(char.IsUpper)
                ? Color.Green
                : Color.Red;

            lblReqPass3.Text = pass.Any(char.IsDigit)
                ? "✔️ Mínimo 1 dígito."
                : "❌ Mínimo 1 dígito.";
            lblReqPass3.ForeColor = pass.Any(char.IsDigit)
                ? Color.Green
                : Color.Red;

            lblReqPass4.Text = pass.Any(c => "!@#$%^&*".Contains(c))
                ? "✔️ Mínimo 1 carácter especial (!@#$%^&*)."
                : "❌ Mínimo 1 carácter especial (!@#$%^&*).";
            lblReqPass4.ForeColor = pass.Any(c => "!@#$%^&*".Contains(c))
                ? Color.Green
                : Color.Red;
        }
    }
}
