using System;
using System.Collections.Generic;
using System.Text;

namespace Programa13
{
    class Carro
    {
        bool encendido = false;
        double peso=0;
        double altura=0;
        public Carro(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }
        public double Peso
        {
            get { return peso; }
            set { if(value>0) peso = value; }
        }
        public double Altura
        {
            get { return altura; }
            set { if(value>0) altura = value; }
        }
        public void Encender()
        {
            encendido = true;
            Console.WriteLine("El carro se encendió");
        }
        public void Apagar()
        {
            encendido = false;
            Console.WriteLine("El carro se apagó");
        }
        public void Estado()
        {
            if (encendido == true)
                Console.WriteLine("El carro está encendido");
            else
                Console.WriteLine("El carro está apagado");
        }
        public override string ToString()
        {
            return String.Format("Peso:{0}, Altura:{1}", peso, altura);
        }
    }
}
