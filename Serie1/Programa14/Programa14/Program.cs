using System;

namespace Programa14
{
    class Program
    {
        //Se implementa una interfaz comida que tiene ciertos atributos y el método cocinar
        //Las otras clases implementan la interfaz y modifican el método a su manera.
        static void Main(string[] args)
        {
            Chocolate c = new Chocolate("Ferrero", "dulce");
            PapasFritas f = new PapasFritas("MisPapas", "salado");
            Lechuga l = new Lechuga("lechuguita", "verdura");
            Console.WriteLine("{0}, {1}", c.Nombre, c.Sabor);
            Console.WriteLine("{0}, {1}", f.Nombre, f.Sabor);
            Console.WriteLine("{0}, {1}", l.Nombre, l.Sabor);
            c.Cocinar();
            f.Cocinar();
            l.Cocinar();
        }
    }
}
