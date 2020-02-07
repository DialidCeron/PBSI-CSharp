using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Persona
    {
        //El protected solo puede ser accedido por esa clase y sus derivadas
        protected string Nombre { get; set; }
        public int Edad { get; set; }
        public Persona() {}
        public Persona(string nombre, int edad) {
            Nombre = nombre;
            Edad = edad;
        }
        //Virtual se hereda pero se puede sobreescribir
        public virtual void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es {0} ", Nombre);
        }
        public override string ToString()
        {
            return string.Format("{0}, {1} años", Nombre, Edad);
        }
    }
}
