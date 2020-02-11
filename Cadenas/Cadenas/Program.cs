using System;

namespace Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenación de cadenas
            Console.WriteLine(string.Concat("Hola", "mundo"));
            string cadena = "Esta es una cadena de prueba";
            Console.WriteLine(cadena);
            Console.WriteLine("Tamaño: " + cadena.Length);
            Console.WriteLine("Mayúsculas: " + cadena.ToUpper());
            Console.WriteLine("Minúsculas: " + cadena.ToLower());
            Console.WriteLine("Replace: " + cadena.Replace(" ", ""));
            Console.WriteLine("Caracter: en indice 0:" + cadena[0]);
            Console.WriteLine("Substrings: " + cadena.Substring(1, 8));
            Console.WriteLine("Cadena contiene \"es\"?" + cadena.Contains("es"));

            //Formatos de cadenas
            int naranjas = 8;
            int platanos = 2;
            int manzanas = 6;

            string ejemplo = string.Format("Hay {0} plátanos, {1} naranjas y {2} manzanas", platanos, naranjas, manzanas);
            Console.WriteLine(ejemplo);

            //Ajuste de decimales
            Console.WriteLine("PI: {0:0.00}", Math.PI);

            //Distintos formatos
            Console.WriteLine("Números: {0:N}",126);
            Console.WriteLine("Científica: {0:E}",126);
            Console.WriteLine("Moneda: {0:C}", 126);
            Console.WriteLine("Porcentaje: {0:P}", 126);
            Console.WriteLine("Hexadecimal: {0:X}", 126);
        }
    }
}
