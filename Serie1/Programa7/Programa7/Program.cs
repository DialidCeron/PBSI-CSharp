using System;

namespace Programa7
{
    class Program
    {
        //Se crean dos NumerosComplejos y se prueban sus metodos
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de Números Complejos:");
            NumeroComplejo n1 = new NumeroComplejo(5, -5);
            NumeroComplejo n2 = new NumeroComplejo(-3, 10);
            NumeroComplejo res = new NumeroComplejo(0, 0);
            n1.Imprimir();
            n2.Imprimir();
            res = NumeroComplejo.sumar(n1, n2);
            Console.WriteLine("La suma de los números complejos anteriores es: ");
            res.Imprimir();
        }
    }
}
