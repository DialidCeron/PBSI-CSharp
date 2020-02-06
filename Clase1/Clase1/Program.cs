using System;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Dialid", 22);
            Persona p2 = new Persona("Lezly", 15);
            Persona p3 = new Persona("Armando", 21);
            Persona p4 = new Persona("Armando", 21);

            //Comparación por referencia
            Console.WriteLine("Referencias p1 y p2 son iguales?");
            Console.WriteLine(p1 == p2);

            Console.WriteLine("Referencias p2 y p3 son iguales?");
            Console.WriteLine(p2 == p3);

            Console.WriteLine("Referencias p3 y p4 son iguales?");
            Console.WriteLine(p3 == p4);

            //Comparación de objetos
            Console.WriteLine("Objetos p1 y p2 son iguales?");
            Console.WriteLine(p1.Equals(p2));

            Console.WriteLine("Objetos p2 y p3 son iguales?");
            Console.WriteLine(p2.Equals(p3));

            Console.WriteLine("Objetos p3 y p4 son iguales?");
            Console.WriteLine(p3.Equals(p4));

            Console.ReadKey();
        }
    }
}
