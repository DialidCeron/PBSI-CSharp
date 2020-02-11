using System;
using System.Collections.Generic;
using System.Text;

namespace Programa17
{
    public class Circulo : InterfaceFiguras
    {
        public double Radio { get; set; }
        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
        public void DatosCirculo()
        {
            Console.WriteLine("Radio: {0}", Radio);
        }

    }
}
