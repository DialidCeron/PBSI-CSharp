using System;
using System.Collections.Generic;
using System.Text;

namespace Programa9
{
    class Cuadrado
    {
        double lado;
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        public void Area()
        {
            double area = Math.Pow(lado, 2);
            Console.WriteLine("El area del cuadrado es: {0}", area);
        }
        public void Log()
        {
            double log = Math.Log(lado);
            Console.WriteLine("El logaritmo del lado es: {0}", log);
        }
    }
}
