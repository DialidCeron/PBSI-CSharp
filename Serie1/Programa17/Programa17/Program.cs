using System;

namespace Programa17
{
    //Programa que utiliza los 4 pilares de la POO
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo();
            c1.Radio = 5;
            c1.DatosCirculo();
            Console.WriteLine(c1.CalcularArea());
            Rectangulo r1 = new Rectangulo();
            r1.Base = 3;
            r1.Altura = 10;
            r1.DatosRectangulo();
            Console.WriteLine(r1.CalcularArea());
            r1.CambiarBase(5.4, 6.7);
            Console.WriteLine(r1.CalcularArea());
        }
    }
}
