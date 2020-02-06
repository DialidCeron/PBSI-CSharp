using System;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Dialid");
            Console.WriteLine(c1.Nombre);
            Console.WriteLine(c1.Edad);
            Console.WriteLine(c1.Cuenta);
            Console.WriteLine(Cliente.mensaje()); //Método static de clase y no de instancia
            Console.WriteLine(c1.Dinero);
            c1.Depositar(5000);
            Console.WriteLine(c1.Dinero);
            Console.ReadKey();
        }
    }
}
