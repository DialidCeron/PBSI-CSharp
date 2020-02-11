using System;

namespace Programa13
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroBMW c1 = new CarroBMW("BMW", 100, 2.4);
            CarroVW c2 = new CarroVW("VW", 200, 1.5);
            c1.Apagar();
            c1.Encender();
            c1.Estado();
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
        }
    }
}
