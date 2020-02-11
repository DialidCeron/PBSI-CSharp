using System;

namespace ClasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> stack = new Stack<double>(10);
            stack.Push(5.5);
            stack.Push(10);

            double x = stack.Pop();
            double y = stack.Pop();
            Console.WriteLine("x: {0}, y: {1}", x, y);

            Stack<Tortilla> tortilla = new Stack<Tortilla>();
            tortilla.Push(new Tortilla());
            tortilla.Push(new Tortilla());

            Console.WriteLine(tortilla.Pop().color);
            Console.WriteLine(tortilla.Pop().color);

        }
    }
}
