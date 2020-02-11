using System;
using System.Collections.Generic;
using System.Text;

namespace Programa10
{
    class Persona
    {
        public string nombre { get; set; }
        int edad;
        double estatura;
        double peso;
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 0)
                    edad = 18;
                else
                    edad = value;
            }
        }
        public double Peso
        {
            get { return peso; }
            set
            {
                if (value < 0)
                    peso = 0.0;
                else
                    peso = value;
            }
        }
        public double Estatura
        {
            get { return estatura; }
            set
            {
                if (value < 0)
                    estatura = 0.0;
                else
                    estatura = value;
            }
        }
        public Persona() { }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}, Estatura: {2}, Peso: {3}", nombre, edad, estatura, peso);
        }
        public void Respirar()
        {
            Console.WriteLine("La persona {0} está respirando", nombre);
        }
        public void Dormir()
        {
            Console.WriteLine("La persona {0} está durmiendo Zzzz", nombre);
        }
    }
}
