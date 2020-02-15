using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = "C:\\Users\\" + Environment.UserName + "\\Documents";
            string cadena;
            string[] cadenas;
            string origen;
            string destino;
            Metodos m = new Metodos();
           
            List<string> historial = new List<string>();
            try
            { 
                Directory.SetCurrentDirectory(ruta);
                Console.Write("{0}> ", Directory.GetCurrentDirectory());
                cadena = Console.ReadLine();

                cadenas = cadena.Split(" ");
                while (cadenas[0] != "exit")
                {
                    switch ((cadenas[0])
    )
                    {
                        case "dir":
                            historial.Add("dir");
                            if (cadenas.Length == 2)
                                if (cadenas[1].Contains("\\"))
                                    m.ListarArchivos(cadenas[1]);
                                else
                                    Console.WriteLine("El comando necesita la ruta completa del directorio a listar");
                            else
                                if (cadenas.Length == 1)
                                m.ListarArchivos(Directory.GetCurrentDirectory());
                            else
                                Console.WriteLine("El comando se corre sólo o con un argumento");
                            break;
                        case "cd":
                            historial.Add("cd");
                            if (cadenas.Length == 2)
                                if (cadenas[1].Equals(".."))
                                    m.CambiarDirectorio(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString());
                                else
                                {
                                    if (cadenas[1].Contains("\\"))
                                        m.CambiarDirectorio(cadenas[1]);
                                    else
                                        Console.WriteLine("Debes proporcionar la ruta completa del directorio al que deseas moverte");
                                }
                            else
                                Console.WriteLine("El comando necesita sólo un directorio a cambiar");
                            break;
                        case "touch":
                            historial.Add("touch");
                            if (cadenas.Length == 2)
                                if (cadenas[1].Contains("\\"))
                                    m.CrearArchivo(cadenas[1]);
                                else
                                    m.CrearArchivo(Directory.GetCurrentDirectory().ToString() + "\\" + cadenas[1]);
                            else
                                Console.WriteLine("El comando touch necesita el nombre o ruta del archivo a crear");
                            break;
                        case "move":
                            historial.Add("move");
                            if (cadenas.Length == 3)
                            {
                                if (!cadenas[1].Contains("\\"))
                                    origen = Directory.GetCurrentDirectory() + "\\" + cadenas[1];
                                else
                                    origen = cadenas[1];
                                if (!cadenas[2].Contains("\\"))
                                    destino = Directory.GetCurrentDirectory() + "\\" + cadenas[2];
                                else
                                    destino = cadenas[2];
                                m.MoverArchivo(origen, destino);
                            }
                            else
                                Console.WriteLine("El comando necesita una ruta o nombre origen y una ruta o nombre destino");
                            break;
                        case "history":
                            historial.Add("history");
                            m.ImprimeHistorial(historial);
                            break;
                        case "cls":
                            historial.Add("cls");
                            m.LimpiarPantalla();
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            Console.WriteLine("Los comandos posibles son: dir<directorio>, cd(directorio || ..), touch(archivo), move(archivo_origen archivo_destino), history, cls, exit");
                            break;
                    }
                    Console.Write("{0}> ", Directory.GetCurrentDirectory());
                    cadena = Console.ReadLine();
                    cadenas = cadena.Split();
                }
            }
                       
         catch (DirectoryNotFoundException)
            {
                Console.WriteLine("El directorio especificado no existe");
            }
         catch (NullReferenceException)
            {
                Console.WriteLine("No hay otro directorio");
            }
        catch (FileNotFoundException)
            {
                Console.WriteLine("No existe el archivo especificado");
            }
        catch (FormatException)
            {
                Console.WriteLine("Formato de datos incorrecto");
            }
        catch (IOException)
            {
                Console.WriteLine("La etiqueta del volumen es incorrecta");
            }

        }
    }
}