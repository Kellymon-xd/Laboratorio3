using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class CuentaBancaria
    {
        private string nombre;
        private float monto;
        private float saldoInicial;
        private List<float> depositosRealizados;
        private List<float> retirosRealizados;


        public CuentaBancaria(string nombre, float monto)
        {
            this.nombre = nombre;
            this.monto = monto;
            this.saldoInicial = monto;
            depositosRealizados = new List<float>();
            retirosRealizados = new List<float>();
        }

        public float getMonto()
        {
            return monto;
        }

        public float getSaldoInicial()
        {
            return saldoInicial;
        }

        public List<float> getRetirosRealizados() { 
            return retirosRealizados;
        }

        public List<float> getDepositosRealizados()
        {
            return depositosRealizados;
        }

        public String depositar(float deposito)
        {
            if (deposito <= 0)
            {
                return "El monto a depositar debe ser mayor a 0";
            }
            else {
                monto+= deposito;
                depositosRealizados.Add(deposito);
                return $"Deposito exitoso, su nuevo saldo es: {monto}";
            }
            
        }

        public String retirar(float retiro)
        {
            if(retiro>monto && retiro>0)
            {
                return "Fondos insuficientes";
            }
            else
            {
                monto -= retiro;
                retirosRealizados.Add(retiro);
                return $"Retiro exitoso, su nuevo saldo es: {monto}";
            }
        }
    }
}
