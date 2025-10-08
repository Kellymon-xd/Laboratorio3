using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio3
{
    public class ValidarCampos
    {
        public bool EsValido(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto);
        }
    }
    public class ValidarCorreo
    {
        public bool EsValido(string correo)
        {
            string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@utp.ac.pa" };
            int arrobas = correo.Count(c => c == '@');
            int posicionArroba = correo.IndexOf('@');

            if (arrobas != 1 || posicionArroba < 1)
                return false;

            string dominioCorreo = correo.Substring(posicionArroba);
            return dominiosPermitidos.Any(d => dominioCorreo.Equals(d, StringComparison.OrdinalIgnoreCase));
        }
    }

    public class ValidarContraseña
    {
        private const string caracteresEspeciales = "!@#$%^&*";

        public bool EsValido(string contraseña)
        {
            return contraseña.Length >= 12 &&
                   contraseña.Any(char.IsUpper) &&
                   contraseña.Any(char.IsDigit) &&
                   contraseña.Any(c => caracteresEspeciales.Contains(c));
        }
    }
}
