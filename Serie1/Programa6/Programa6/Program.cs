using System;

namespace Programa6
{
    class Program
    {
        //Se crean dos objetos de tipo cuenta bancaria y se prueban sus métodos
        static void Main(string[] args)
        {
            CuentaBancaria b1 = new CuentaBancaria("Lezly Cerón", 1000);
            CuentaBancaria b2 = new CuentaBancaria("Gamaliel Díaz", 0);
            b1.MostrarInformación();
            b2.MostrarInformación();
            b1.Depositar(5000);
            b2.Retirar(100);
            b2.Depositar(9000);
            b2.Retirar(50);
        }
    }
}
