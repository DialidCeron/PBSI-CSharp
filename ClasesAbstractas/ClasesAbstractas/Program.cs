using System;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales =
            {
                new Carnivoro("León"),
                new Herviboro("Jirafa")
            };
            Console.WriteLine("Lista de animales");
            foreach(Animal anim in animales)
            {
                Console.WriteLine(anim);
            }
            Lobo lobo = new Lobo("Lobi");
            lobo.Cazar();

            (lobo as Carnivoro).Cazar();
            
            Pinguino pingu = new Pinguino("Tux");
            pingu.Cazar();
            (pingu as Carnivoro).Cazar();

            Console.ReadLine();
        }
    }
}
