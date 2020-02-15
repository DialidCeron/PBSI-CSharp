using System;
using System.Linq;
using System.Collections.Generic;
namespace QuerySintaxis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 2, 4, 7, 9, 0, 1, 6 };
            Console.WriteLine("Arreglo original: ");
            Imprime(numeros);
            //Query que obtiene los números mayores a 4
            var filtered =
                from n in numeros
                where n > 4
                select n;
            Console.WriteLine("Arreglo filtrado números mayores a 4: ");
            Imprime(filtered);

            //Ordenar el arreglo 
            var sorted =
                from n in numeros
                orderby n
                select n;
            Console.WriteLine("Arreglo ordenado ascendente: ");
            Imprime(sorted);

            var sortDesc =
                from n in numeros
                orderby n descending
                select n;
            Console.WriteLine("Arreglo ordenado descendente: ");
            Imprime(sortDesc);

            var sortFiltered =
                from n in filtered
                orderby n
                select n;

            Console.WriteLine("Arreglo filtrado y ordenado: ");
            Imprime(sortFiltered);
            string[] paises = { "México", "Alemania", "Rusia", "Chile", "Perú", "Austria", "Cuba", "Canadá" };

            //PAÍSES cuyo nombre contiene a, ordenados por longitud
            IEnumerable<string> query =
                from p in paises
                where p.Contains("a")
                orderby p.Length
                select p.ToUpper();
            Console.WriteLine("Países ordenados que contienen a");
            Imprime(query);

            //Países cuyo nombre sea mayor a 5 
            IEnumerable<string> query2 =
                from p in paises
                where p.Length > 5
                select p;
            Console.WriteLine("Países cuyo nombre sea mayor a 5");
            Imprime(query2);

            //Las iniciales de los países
            IEnumerable<char> query3 =
                from p in paises
                orderby p.Length
                select p[0];
            Console.WriteLine("Las iniciales de los países: ");
            Imprime(query3);
        }

        static void Imprime<T>(IEnumerable<T> arreglo)
        {
            foreach (var elemento in arreglo)
                Console.WriteLine(" {0} ", elemento);
        }
    }
}
