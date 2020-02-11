using System;
using System.IO;

namespace Programa18
{
    class Program
    {
        //Programa que crea un archivo en la ruta C://Dialid/dialid.txt y escribe en él.
        class EscribirArchivo
        {
            public void Datos()
            {
                StreamWriter ar = new StreamWriter("C://Dialid/dialid.txt");
                Console.WriteLine("Ingresa el texto que quieres escribir en el archivo ");
                string str = Console.ReadLine();
                ar.WriteLine(str);
                ar.Flush();
                ar.Close();
            }
        }

        static void Main(string[] args)
        {
            EscribirArchivo es = new EscribirArchivo();
            es.Datos();
        }
    }
}
