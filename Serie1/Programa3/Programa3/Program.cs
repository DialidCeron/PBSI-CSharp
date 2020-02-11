using System;

namespace Programa3
{
    class Program
    {
        //Programa que dada una cadena, agrega una f antes de cada vocal
        static void Main(string[] args)
        {
            int i;
            string cadena=" ";
            try
            {
                Console.WriteLine("Dame una cadena de texto: ");
                cadena = Console.ReadLine();
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Debes ingresar una cadena de texto");
            }
            char[] arreglo= cadena.ToCharArray();
            Console.WriteLine(" ");
            for(i=1; i<=(cadena.Length); i++)
            {
                if (arreglo[i - 1] == 'a' || arreglo[i - 1] == 'e' || arreglo[i - 1] == 'i' ||
                    arreglo[i - 1] == 'o' || arreglo[i - 1] == 'u' || arreglo[i - 1] == 'A' ||
                    arreglo[i - 1] == 'E' || arreglo[i - 1] == 'I' || arreglo[i - 1] == 'O' ||
                    arreglo[i - 1] == 'U')
                {
                    Console.Write("f" + arreglo[i-1]);
                }
                else
                    Console.Write(arreglo[i-1]);
            }
            Console.WriteLine(" ");
        }
    }
}
