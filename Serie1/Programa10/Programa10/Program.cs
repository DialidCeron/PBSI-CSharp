using System;

namespace Programa10
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            try
            {
                Console.WriteLine("Ingresa el nombre de la persona: ");
                p1.nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la edad de la persona: ");
                p1.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa la estatura de la persona en metros: ");
                p1.Estatura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el peso de la persona en kg: ");
                p1.Peso = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Los datos no están en el formato correcto");
            }
            p1.MostrarDatos();
            p1.Respirar();
            p1.Dormir();
        }
    }
}
