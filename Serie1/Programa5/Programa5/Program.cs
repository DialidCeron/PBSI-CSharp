using System;
using System.Collections.Generic;

namespace Programa5
{   
    //Agenda Telefónica
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contactos = new Dictionary<string, string>();
            char opcion;
            string nombre;
            long num;
            Console.WriteLine("Bienvenido a la Agenda Telefónica");
            Console.WriteLine("Elige una de las siguientes opciones: ");
            Console.WriteLine("1. Agregar Contacto");
            Console.WriteLine("2. Eliminar Contacto");
            Console.WriteLine("3. Mostrar Contactos");
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
                            Console.WriteLine("Opción seleccionada: Agregar Contacto ");
                            Console.WriteLine("Ingresa el nombre del contacto:");
                            nombre = Console.ReadLine();
                            if (contactos.ContainsKey(nombre))
                                Console.WriteLine("Un contacto con ese nombre ya existe");
                            else
                            {
                                Console.WriteLine("Ingresa el número telefónico a 10 dígitos");
                                num = Convert.ToInt64(Console.ReadLine());
                                string numero = num.ToString();
                                if ((numero).Length > 10 || (numero.Length)<10)
                                {
                                    Console.WriteLine("El número ingresado no es a 10 dígitos");
                                }
                                else
                                {
                                    if (contactos.ContainsValue(numero))
                                        Console.WriteLine("Ya existe un contacto con ese número de teléfono");
                                    else
                                        contactos.Add(nombre, numero);
                                }
                            }
                            
                        }
                        catch (FormatException formatException)
                        {
                            Console.WriteLine("\n" + formatException.Message);
                            Console.WriteLine("Debes ingresar número telefónico a 10 dígitos");
                        }
                        break;
                    case '2':
                        Console.WriteLine("Opción seleccionada: Eliminar contacto ");
                        Console.WriteLine("Escribe el nombre del contacto a eliminar");
                        nombre = Console.ReadLine();
                        contactos.Remove(nombre);
                        break;
                    case '3':
                        Console.WriteLine("Opción seleccionada: Mostrar contactos");
                        foreach(KeyValuePair<string, string> cont in contactos)
                        {
                            Console.WriteLine("Nombre: {0}, Teléfono:{1} ", cont.Key, cont.Value);
                        }
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
                Console.WriteLine("Elige una de las siguientes opciones: ");
                Console.WriteLine("1. Agregar Contacto");
                Console.WriteLine("2. Eliminar Contacto");
                Console.WriteLine("3. Mostrar Contactos");
                Console.WriteLine("4. Salir");
                opcion = Convert.ToChar(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }
        
        }
    }
}
