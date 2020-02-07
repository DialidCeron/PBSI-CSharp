using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class Carnivoro:Animal
    {
        public Carnivoro(string nombre) : base(nombre) { }
        public override string Come
        {
            get { return "Come otros animales"; }
        }
        public virtual void Cazar()
        {
            Console.WriteLine("El animal está cazando!");
        }

    }
    class Herviboro : Animal
    {
        public Herviboro(string nombre) : base(nombre) { }
        public override string Come
        {
            get { return "Come plantas"; }
        }
        public void Recolectar()
        {
            Console.WriteLine("El animal está recolectando su comida");
        }
    }
}
