using System;
using System.Collections.Generic;
using System.Text;

namespace Programa13
{
    class CarroBMW:Carro
    {
        string Modelo { get; set; }
        public CarroBMW(string modelo, double peso, double altura) : base(peso, altura)
        {
            this.Modelo = modelo;
        }
        public override string ToString()
        {
            return String.Format("Peso:{0}, Altura:{1}, Modelo:{2}", Peso, Altura, Modelo);
        }
    }
}
