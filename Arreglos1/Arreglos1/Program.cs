using System;

namespace Arreglos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tamaño del arreglo:");
            int tam = Convert.ToInt32(Console.ReadLine());
            //Definir arreglo
            int[] numeros = new int[tam];
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("Indice {0}:", i);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Los datos que ingresaste son: ");

            MostrarArreglo(numeros);
            Console.ReadKey();
        }
        static void MostrarArreglo(int[] arreglo) { //STatic para usarlo sin instanciar
            foreach(int num in arreglo)
            {
                Console.WriteLine("{0}", num);
            }
            Console.WriteLine();
        }
    }
}
