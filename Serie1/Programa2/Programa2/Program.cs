using System;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            //Pide al usuario dos números del 1 al 9
            try
            {
                Console.WriteLine("Ingresa un número del 1 al 9: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa un número del 1 al 9: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Debes ingresar números del 1 al 9");
            }
            //Verifica que los dos números sean del 1 al 9
            if ((num1 > 0 && num1 < 10) && (num2 > 0 && num2 < 10))
            {
                //De los números del 1 al 100, si alguno es múltiplo de alguno de los números
                //ingresados por el usuario o lo contiene, imprime clap
                for(int i=1; i<=100; i++)
                {
                    if (i.ToString().Contains(num1.ToString()) ||
                        i.ToString().Contains(num2.ToString()) ||
                        i % num1 == 0 || i % num2 == 0)
                    {
                        Console.WriteLine("Clap");
                    }
                    else
                        Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Debes ingresar números del 1 al 9");
        }
    }
}
