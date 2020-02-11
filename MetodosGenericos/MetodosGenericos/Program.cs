using System;

namespace MetodosGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] charArray = { 'H', 'O', 'L', 'A' };

            Console.WriteLine("intArray contiene: ");
            MuestraArreglo(intArray);
            Console.WriteLine("doubleArray contiene: ");
            MuestraArreglo(doubleArray);
            Console.WriteLine("charArray contiene: ");
            MuestraArreglo(charArray);
        }

        public static void MuestraArreglo <T> (T[] inputArray)
        {
            foreach (T element in inputArray)
            {
                Console.Write(element+" ");
            }
            Console.WriteLine();
        }
    }
}
