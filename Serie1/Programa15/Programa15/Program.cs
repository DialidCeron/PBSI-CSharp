using System;

namespace Programa15
{
    class Program
    {
        //Calculadora entre dos números con manejo de excepciones
        static void Main(string[] args)
        {
            char opcion;
            double num1;
            double num2;
            double res;
            Console.WriteLine("Calculadora");
            Console.WriteLine("Selecciona una de las siguientes opciones:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            opcion = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            while (opcion != '5')
            {
                switch (opcion)
                {
                    case '1':
                        try
                        {
                            Console.WriteLine("Opción seleccionada: Sumar ");
                            Console.WriteLine("Escribe el primer número: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            if (num1 < -214483648 || num1 > 2147483647)
                                throw new OverflowException();
                            Console.WriteLine("Escribe el segundo número: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            if (num2 < -214483648 || num2 > 214483647)
                                throw new OverflowException();
                            res = num1 + num2;
                            Console.WriteLine("Resultado: {0}", res);
                        }
                        catch (FormatException formatException)
                        {
                            Console.WriteLine("\n" + formatException.Message);
                            Console.WriteLine("Debes ingresar números");
                        }
                        catch (OverflowException ov)
                        {
                            Console.WriteLine("\n" + ov.Message);
                            Console.WriteLine("El número es demasiado grande");
                        }
                        break;
                    case '2':
                        try
                        {
                            Console.WriteLine("Opción seleccionada: Restar ");
                            Console.WriteLine("Escribe el primer número: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            if (num1 < -214483648 || num1 > 2147483647)
                                throw new OverflowException();
                            Console.WriteLine("Escribe el segundo número: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            if (num2 < -214483648 || num2 > 214483647)
                                throw new OverflowException();
                            res = num1 - num2;
                            Console.WriteLine("Resultado: {0} ", res);
                        }
                        catch (FormatException formatException)
                        {
                            Console.WriteLine("\n" + formatException.Message);
                            Console.WriteLine("Debes ingresar números");
                        }
                        catch (OverflowException ov)
                        {
                            Console.WriteLine("\n" + ov.Message);
                            Console.WriteLine("El número es demasiado grande");
                        }
                        break;
                    case '3':
                        try
                        {
                            Console.WriteLine("Opción seleccionada: Multiplicar ");
                            Console.WriteLine("Escribe el primer número: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            if (num1 < -214483648 || num1 > 2147483647)
                                throw new OverflowException();
                            Console.WriteLine("Escribe el segundo número: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            if (num2 < -214483648 || num2 > 214483647)
                                throw new OverflowException();
                            res = num1 * num2;
                            Console.WriteLine("Resultado: {0}", res);
                        }
                        catch (FormatException formatException)
                        {
                            Console.WriteLine("\n" + formatException.Message);
                            Console.WriteLine("Debes ingresar números");
                        }
                        catch (OverflowException ov)
                        {
                            Console.WriteLine("\n" + ov.Message);
                            Console.WriteLine("El número es demasiado grande");
                        }
                        break;
                    case '4':
                        try
                        {
                            Console.WriteLine("Opción seleccionada: Dividir ");
                            Console.WriteLine("Escribe el primer número: ");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            if (num1 < -214483648 || num1 > 2147483647)
                                throw new OverflowException();
                            Console.WriteLine("Escribe el segundo número: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            if(num2 < -214483648 || num2 > 214483647)
                                throw new OverflowException();
                            if (num2 == 0)
                                throw new DivideByZeroException();
                            else
                                res = num1 / num2;
                            Console.WriteLine("Resultado: {0}", res);
                        }
                        catch (FormatException formatException)
                        {
                            Console.WriteLine("\n" + formatException.Message);
                            Console.WriteLine("Debes ingresar números");
                        }
                        catch(OverflowException ov)
                        {
                            Console.WriteLine("\n" + ov.Message);
                            Console.WriteLine("El número es demasiado grande");
                        }
                        catch (DivideByZeroException zero)
                        {
                            Console.WriteLine("\n" + zero.Message);
                            Console.WriteLine("No es posible la división entre cero");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
                Console.WriteLine("Calculadora");
                Console.WriteLine("Selecciona una de las siguientes opciones:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                opcion = Convert.ToChar(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }
        }
    }
}
