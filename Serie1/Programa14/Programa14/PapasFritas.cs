using System;
using System.Collections.Generic;
using System.Text;

namespace Programa14
{
    class PapasFritas
    {
        public string Nombre { get; set; }
        public string Sabor { get; set; }
        public bool Cocinado { get; set; }
        public PapasFritas(string nombre, string sabor)
        {
            this.Nombre = nombre;
            this.Sabor = sabor;
            this.Cocinado = false;
        }
        public void Cocinar()
        {
            Console.WriteLine("Friendo las Papas Fritas");
        }
    }
}
