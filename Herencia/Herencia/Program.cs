using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Dialid", 22);
            p.Saludar();
            Console.WriteLine(p.ToString());

            Empleado e = new Empleado("Lezly", 21, "Jefe", 200000);
            e.Saludar();
            e.Trabajar();
            Console.WriteLine(e.ToString());

            Persona p1 = new Persona("Xotla", 24);
            Persona p2 = new Persona("Zuleika", 18);

            Persona[] gente = new Persona[4];
            gente[0] = p;
            gente[1] = p1;
            gente[2] = p2;
            gente[3] = e;
            Console.WriteLine();
            Console.WriteLine("Lista de personas que son empleados: ");
            foreach(var per in gente)
            {
                if(per is Empleado)
                {
                    Console.WriteLine(per.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
