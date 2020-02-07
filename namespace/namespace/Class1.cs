using System;
using System.Collections.Generic;
using System.Text;

namespace TiposAnonios
{
    class Program
    {
        static void Main() {
            var anonimo = new {
                Modelo = "Bocho";
                Precio = 80000;
                Placas = "45RT65";

            };
            Console.WriteLine("Datos del objeto anonimo");
            Console.WriteLine(anonimo.Modelo);
            Console.WriteLine(anonimo.Precio);
            Console.WriteLine(anonimo.Placas);
        }
    }
}
