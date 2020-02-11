using System;
using System.Collections.Generic;
using System.Text;

namespace Programa8
{
    //Clase Auto con tres atributos, métodos get y set, 3 métodos, sobrecarga de constructor
    class Auto
    {
        string marca;
        string color;
        int anio;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Anio
        {
            get { return anio; }
            set { anio = value; }
        }
        public Auto() { }
        public Auto(string marca, string color)
        {
            this.marca = marca;
            this.color = color;
        }
        public Auto(string marca, string color, int anio)
        {
            this.marca = marca;
            this.color = color;
            this.anio = anio;
        }

        public void Avanzar()
        {
            Console.WriteLine("El auto está avanzando");
        }

        public void Frenar()
        {
            Console.WriteLine("El auto se ha detenido");
        }
        public void CambiarVelocidad()
        {
            Console.WriteLine("El auto ha cambiado de velocidad");
        }
    }
}
