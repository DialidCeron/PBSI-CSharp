using System;
using System.Collections.Generic;
using System.Text;

namespace Programa6
{
    class CuentaBancaria
    {
        double saldo;
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public CuentaBancaria(string nombre, double saldo)
        {
            this.nombre = nombre;
            this.saldo = saldo;
        }
        public void MostrarInformación()
        {
            Console.WriteLine("Cuenta bancaria");
            Console.WriteLine("Nombre: {0} Saldo: {1} ", nombre, saldo);
        }
        public void Retirar(double cantidad)
        {
            if (cantidad > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            saldo -= cantidad;
            MostrarInformación();
        }
        public void Depositar(double cantidad)
        {
            saldo += cantidad;
            MostrarInformación();
        }

    }
}
