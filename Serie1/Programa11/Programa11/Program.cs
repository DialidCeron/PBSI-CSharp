using System;

namespace Programa11
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion;
            int tam1=0;
            
            Console.WriteLine("Calculadora");
            Console.WriteLine("Selecciona una de las siguientes opciones:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Salir");
            opcion = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            while (opcion != '4')
            {
                switch (opcion)
                {
                    case '1':
                        try
                        {
                            Console.WriteLine("Opción seleccionada: Sumar ");
                            Console.WriteLine("Elige el tamaño de las matrices: ");
                            tam1 = Convert.ToInt32(Console.ReadLine());
                            
                            double[,] matrizA = new double[tam1,tam1];
                            double[,] matrizB = new double[tam1, tam1];
                            Console.WriteLine("Ingresa los datos de la primera matriz");
                            matrizA = PedirDatos(tam1);
                            Console.WriteLine("Ingresa los datos de la segunda matriz");
                            matrizB = PedirDatos(tam1);
                            double[,] res = new double[tam1, tam1];
                            for (int i = 0; i < tam1; i++){
                                for(int j=0; j < tam1; j++)
                                {
                                    res[i, j] = matrizA[i, j] + matrizB[i, j];
                                }
                            }
                            Console.WriteLine("Matriz resultado:");
                            ImprimirMatriz(res);
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
                            Console.WriteLine("Elige el tamaño de las matrices: ");
                            tam1 = Convert.ToInt32(Console.ReadLine());

                            double[,] matrizA = new double[tam1, tam1];
                            double[,] matrizB = new double[tam1, tam1];
                            Console.WriteLine("Ingresa los datos de la primera matriz");
                            matrizA = PedirDatos(tam1);
                            Console.WriteLine("Ingresa los datos de la segunda matriz");
                            matrizB = PedirDatos(tam1);
                            double[,] res = new double[tam1, tam1];
                            for (int i = 0; i < tam1; i++)
                            {
                                for (int j = 0; j < tam1; j++)
                                {
                                    res[i, j] = matrizA[i, j] - matrizB[i, j];
                                }
                            }
                            Console.WriteLine("Matriz resultado:");
                            ImprimirMatriz(res);
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
                            Console.WriteLine("Elige el tamaño de las matrices: ");
                            tam1 = Convert.ToInt32(Console.ReadLine());

                            double[,] matrizA = new double[tam1, tam1];
                            double[,] matrizB = new double[tam1, tam1];
                            Console.WriteLine("Ingresa los datos de la primera matriz");
                            matrizA = PedirDatos(tam1);
                            Console.WriteLine("Ingresa los datos de la segunda matriz");
                            matrizB = PedirDatos(tam1);
                            double[,] res = new double[tam1, tam1];
                           
                            for (int i = 0; i < tam1; i++)
                            {
                                for (int j = 0; j < tam1; j++)
                                {
                                    
                                      res[i, j] += (matrizA[i, j] * matrizB[j, i]);
                                   
                                   
                                }
                            }
                            Console.WriteLine("Matriz resultado:");
                            ImprimirMatriz(res);

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
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
                Console.WriteLine("Calculadora de matrices");
                Console.WriteLine("Selecciona una de las siguientes opciones:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Salir");
                opcion = Convert.ToChar(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }
        }
        static double[,] PedirDatos(int tam)
        {
            double[,] matrizA = new double[tam, tam];
            try
            {
                for (int i = 0; i < tam; i++)
                    for (int j = 0; j < tam; j++)
                    {
                        Console.WriteLine("Ingresa el dato de la matriz en [{0}][{1}]", i, j);
                        double num_in = Convert.ToDouble(Console.ReadLine());
                        matrizA[i, j] = num_in;
                    }
                
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("\n" + formatException.Message);
                Console.WriteLine("Debes ingresar números");
            }
            return matrizA;
        }
        static void ImprimirMatriz(double[,] matriz)
        {
            Console.WriteLine();
            for (int i = 0; i < Math.Sqrt(matriz.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(matriz.Length); j++)
                    Console.Write("{0}", matriz[i, j]);
                Console.WriteLine();
            }    
        }
    }
}
