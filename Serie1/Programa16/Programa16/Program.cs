using System;

namespace Programa16
{
    class Program
    {
        //Programa que utiliza Polimorfismo en el método suma al ser tipo double e int
        static void Main(string[] args)
        {
            int a = 3;
            int b = 3;
            double c = 1.1;
            Console.WriteLine(suma(a,b));
            Console.WriteLine(suma(a, c));
        }
        public static int suma(int a, int b)
        {
            return a + b;
        }
        public static double suma(double a, double b)
        {
            return a + b;
        }
    }
}
