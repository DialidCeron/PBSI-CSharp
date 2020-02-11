using System;

namespace Programa4
{
    class Program
    {
        //Imprime la serie de fibonacci hasta el elemento n que especifique el usuario.
        static void Main(string[] args)
        {
            int n = 0;

            try
            {
                Console.WriteLine("Dime cuántos números de la serie de fibonacci quieres: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Debes ingresar un número entero");
            }
            catch (NegativeNumberException nne)
            {
                Console.WriteLine("\n" + nne.Message);
                Console.WriteLine("Ingresa un número no negativo");
            }
            Console.WriteLine("Números de la serie de fibonacci: ");
            for(int i=0; i<=n; i++)
            {
                Console.WriteLine("{0}, {1}", i, fibonacci(i));
            }
        }

        static int fibonacci(int x)
        {
            if (x < 0)
            {
                throw new NegativeNumberException();
            }
            else 
            {
                int fibo1 = 0;
                int fibo2 = 1;
                int i;
                for (i = 1; i < x; i++)
                {
                    fibo2 = fibo1 + fibo2;
                    fibo1 = fibo2 - fibo1;
                }
                return fibo2;
            }
            
        }
    }
}
