using System;

namespace Programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objetos Clase Auto");
            Auto a1 = new Auto();
            Auto a2 = new Auto("VMW", "morado");
            Auto a3 = new Auto("Nissan", "gris", 2017);
            ImprimirDatos(a1);
            ImprimirDatos(a2);
            ImprimirDatos(a3);
            a1.Avanzar();
            a2.CambiarVelocidad();
            a3.Frenar();
            a3.Marca = "Honda";
            ImprimirDatos(a3);
        }
        public static void ImprimirDatos(Auto a1)
        {
            Console.WriteLine("Marca: {0}, Color: {1}, Año: {2}", a1.Marca, a1.Color, a1.Anio);
        }
    }
}
