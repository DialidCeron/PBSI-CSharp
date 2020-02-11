using System;

namespace Programa1
{
    class Program
    {
        //Programa que calcula la suma de los n números naturales que quiera el usuario.
        static void Main(string[] args)
        {
            try
            {
                int n;
                int suma = 0;
                Console.WriteLine("Cantidad de números a sumar: ");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    suma += i;
                }
                Console.WriteLine("La suma de total de los {0} números naturales es: {1}", n, suma);
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Debes ingresar un número entero");
            }
        }
    }
}
