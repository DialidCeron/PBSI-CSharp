using System;
using System.Collections.Generic;
using System.Text;

namespace Programa9
{
    class Circulo
    {
        double radio { get; set; }

        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public void Area()
        {
            double area = Math.PI * (Math.Pow(radio, 2));
            Console.WriteLine("El area del circulo es: {0}", area);
        }

        public void RaizC()
        {
            double raizc = Math.Sqrt(radio);
            Console.WriteLine("La raíz cuadrada del radio es: {0}", raizc);
        }
    }
}
