using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        private static readonly string[] colors = { "Magenta", "Rojo", "Blanco", "Azul", "Cyan" };
        private static readonly string[] removeColors = { "Rojo", "Blanco", "Azul" };
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            foreach(var color in colors)
            {
                list.Add(color);
            }
            List<string> removeList = new List<string>(removeColors);

            MostrarLista(list);
        }
        private static void MostrarLista(List<string> list)
        {
            foreach(var element in list)
            {
                Console.Write("{0} ",element);
            }
            Console.WriteLine();
        }
    }
}
