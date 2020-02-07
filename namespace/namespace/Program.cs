using System;

namespace MiNamespace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("Dentro de MiNamespace");
        }
    }
}

class uno
{
    public void metodo(){
        Console.WriteLine("Hola como estas?");
    }
}

namespace Namespace {
    class Program{
        static void Main()
        {
            MiNamespace.Clase1 obj1 = new MiNamespace.Clase1();
            uno obj2 = new uno();
            obj1.Metodo();
            obj2.metodo();

            Console.ReadKey();
        }
    }

}
