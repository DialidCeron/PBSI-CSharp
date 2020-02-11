using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Convert.Toint32 genera FormatException
                Console.WriteLine("Ingresa el numerador:" );
                int numerador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa el denominador: ");
                int denominador = Convert.ToInt32(Console.ReadLine());
                
                //LA división entre 0 genera DivideByZeroException
                double resultado = numerador / denominador;

                Console.WriteLine("\nResultado: {0}/{1} = {2}", numerador, denominador, resultado);

            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" +formatException.Message);
                Console.WriteLine("Debes ingresar números");
            }
            catch (DivideByZeroException zero)
            {
                Console.WriteLine("\n" + zero.Message);
                Console.WriteLine("No es posible la división entre cero");
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }
        }
    }
}
