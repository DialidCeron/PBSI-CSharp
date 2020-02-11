using System;
using System.Collections.Generic;
using System.Text;

namespace Programa13
{
    class CarroVW :Carro
    {
        string Modelo { get; set; }
        public CarroVW(string modelo, double peso, double altura) : base(peso, altura)
        {
            this.Modelo = modelo;
        }
        public override string ToString()
        {
            return String.Format("Peso:{0}, Altura:{1}, Modelo:{2}", Peso, Altura, Modelo);
        }
    }
}
