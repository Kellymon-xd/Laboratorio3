using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    internal class CuentaBancaria
    {
        private string nombre;
        private int monto;
        private int deposito;
        private int retiro; 
     

        public void asignar (string nombre,int monto)
        {
            this.nombre = nombre;
            this.monto = monto;
           
        }

        public int getMonto()
        {
            return monto;
        }

        public String depositar()
        {
            if (deposito <= 0)
            {
                return "El monto a depositar debe ser mayor a 0";
            }
            else {
                monto += deposito;
                return "Deposito exitoso, su nuevo saldo es: {monto}";
            }
            
        }

        public String retirar()
        {
            if(retiro>monto)
            {
                return "Fondos insuficientes";
            }
            else
            {
                monto -= retiro;
                return "Retiro exitoso, su nuevo saldo es: {monto}";
            }
        }
    }
}
