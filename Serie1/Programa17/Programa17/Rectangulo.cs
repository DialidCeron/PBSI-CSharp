using System;
using System.Collections.Generic;
using System.Text;

namespace Programa17
{
        class Rectangulo : InterfaceFiguras
        {
            public double Base { get; set; }
            public double Altura { get; set; }
            public double CalcularArea()
            {
                return Base * Altura;
            }
            public void DatosRectangulo()
            {
                Console.WriteLine("Base: {0}, Altura: {1} ", Base, Altura);
            }
            public void CambiarBase(int a, int b)
            {
                Base = a + b;
            }
            public void CambiarBase(double a, double b)
            {
                Base = a + b;
            }
        }
}
