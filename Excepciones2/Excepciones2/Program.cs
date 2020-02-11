using System;

namespace Excepciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresa un valor para calcular su raíz cuadrada: ");
                double dato = Convert.ToDouble(Console.ReadLine());
                double resultado = RaizCuadrada(dato);
                Console.WriteLine("La raíz cuadrada de {0} es {1}\n", dato, resultado);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\n" + fe.Message);
                Console.WriteLine("Debes ingresar un número");
            }
            catch (NegativeNumberException nne) {
                Console.WriteLine("\n"+nne.Message);
                Console.WriteLine("Ingresa un número no negativo");
            }
        }
        public static double RaizCuadrada(double num)
        {
            if (num<0)
            {
                throw new NegativeNumberException();
            }
            else
                return Math.Sqrt(num);
        }
    }
}
