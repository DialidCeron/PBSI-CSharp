using System;
using System.Collections.Generic;
using System.Text;

namespace Programa7
{
    class NumeroComplejo
    {
        double parteReal { get; set; }
        double parteImaginaria { get; set; }

        public void Imprimir()
        {
            if(parteImaginaria>0)
                Console.WriteLine("({0}+{1}i)", parteReal, parteImaginaria);
            else
                Console.WriteLine("({0}{1}i)", parteReal, parteImaginaria);
        }
        public NumeroComplejo(double real, double img)
        {
            this.parteReal = real;
            this.parteImaginaria = img;
        }
        public static NumeroComplejo sumar(NumeroComplejo x, NumeroComplejo y)
        {
            double real = x.parteReal + y.parteReal;
            double img = x.parteImaginaria + y.parteImaginaria;
            NumeroComplejo suma = new NumeroComplejo(real, img);
            return suma;
        }
    }
}
