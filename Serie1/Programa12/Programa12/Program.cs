using System;
using System.Collections.Generic;

namespace Programa12
{
    class Program
    {
        static double total = 0;
        static void Main(string[] args)
        {
            List<String> productos = new List<string>();
            List<Double> precios = new List<double>();
            char letra;
            int salir = 0;
            int indice;
           
            Console.WriteLine("¡Bienvenido al BecarioMart!");
            Console.WriteLine("¿Quieres agregar un nuevo producto? (s/n)");
            letra = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            while (letra != 's' && letra != 'n')
            {
                Console.WriteLine("Opción incorrecta");
                Console.WriteLine("¿Quieres agregar un nuevo producto? (s/n)");
                letra = Convert.ToChar(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }
            while (letra == 's')
            {
                Console.WriteLine("Ingresa el nombre del producto: ");
                productos.Add(Console.ReadLine());
                try
                {
                    Console.WriteLine("Ingresa el precio del producto: ");
                    double p = Convert.ToDouble(Console.ReadLine());
                    if (p >= 0)
                        precios.Add(p);
                    else
                        Console.WriteLine("El precio debe ser mayor o igual a 0");
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("\n" + formatException.Message);
                    Console.WriteLine("El precio debe ser numérico");
                    precios.Add(0);
                }
               
                Console.WriteLine("¿Quieres agregar un nuevo producto? (s/n)");
                letra = Convert.ToChar(Console.ReadKey().KeyChar);
                Console.WriteLine();
                while(letra!='s' && letra != 'n')
                {
                    Console.WriteLine("Opción incorrecta");
                    Console.WriteLine("¿Quieres agregar un nuevo producto? (s/n)");
                    letra = Convert.ToChar(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                }
            }
            if (productos.Count > 0)
            {
                ImprimirProductos(productos, precios);
                Console.WriteLine("Elige una de las siguientes opciones:");
                Console.WriteLine("Comprar (c)");
                Console.WriteLine("Dejar productos (d)");
                letra = Convert.ToChar(Console.ReadKey().KeyChar);
                Console.WriteLine();
                while (letra != 'c' && letra != 'd')
                {
                    Console.WriteLine("Opción incorrecta");
                    Console.WriteLine("Elige una de las siguientes opciones:");
                    Console.WriteLine("Comprar (c)");
                    Console.WriteLine("Dejar productos (d)");
                    letra = Convert.ToChar(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                }
                while(letra=='c' || letra == 'd')
                {
                    if (letra == 'c')
                    {
                        if (total <= 500)
                        {
                            Console.WriteLine("¡Gracias por su compra!");
                            break;
                        }
                        else
                            Console.WriteLine("¡Tu compra supera los $500! Deja productos para que sea válida");
                    }
                    else
                    {
                        ImprimirProductos(productos, precios);
                        Console.WriteLine("Elige el índice del producto a eliminar: ");
                        indice = Convert.ToInt32(Console.ReadLine());
                        if (indice >= 0 && indice < productos.Count)
                        {
                            productos.RemoveAt(indice);
                            precios.RemoveAt(indice);
                            ImprimirProductos(productos, precios);
                            if (total <= 0)
                            {
                                Console.WriteLine("Tu carrito de compras se ha vaciado. ¡Vuelve pronto!");
                                break;
                            }
                        }
                        else
                            Console.WriteLine("Indice de producto incorrecto");
                    }
                    Console.WriteLine("Elige una de las siguientes opciones:");
                    Console.WriteLine("Comprar (c)");
                    Console.WriteLine("Dejar productos (d)");
                    letra = Convert.ToChar(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                    while (letra != 'c' && letra != 'd')
                    {
                        Console.WriteLine("Opción incorrecta");
                        Console.WriteLine("Elige una de las siguientes opciones:");
                        Console.WriteLine("Comprar (c)");
                        Console.WriteLine("Dejar productos (d)");
                        letra = Convert.ToChar(Console.ReadKey().KeyChar);
                        Console.WriteLine();
                    }
                }
            }
            else
                Console.WriteLine("No agregaste ningún producto al carrito. ¡Vuelve pronto!");
            //Console.WriteLine("{0} {1}", tecla.KeyChar, tecla.Key);
        }
        public static void ImprimirProductos(List<string> prod, List<double> prec)
        {
            total = 0;
            string[] productos = prod.ToArray();
            double[] precios = prec.ToArray();
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("Producto[{0}]: {1} Precio: ${2}",i, productos[i], precios[i]);
                total += precios[i];
            }
            Console.WriteLine("Total: ${0}", total);
        }
    }
}
