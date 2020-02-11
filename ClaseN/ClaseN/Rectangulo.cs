using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseN
{
    class Rectangulo : IFigura
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public double CalcularArea()
        {
            return Base * Altura;
        }
        public void DatosRectangulo()
        {
            Console.WriteLine("Base: {0}, Altura: {1} ", Base, Altura);
        }
    }
}
