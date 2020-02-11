using System;

namespace Programa9
{
    class Program
    {
        /*MÉTODOS DE LA CLASE MATH
         * Abs() Retorna el valor absoluto de un número
         * Acos() Retorna el angulo cuyo coseno es el número especificado
         * Cbrt() Retorna la raíz cubica de un valor especificado
         * Exp() Retorna e elevado a la potencia especificada
         * Log() Retorna el logaritmo de un número especificado
         * Max() Retorna el más grande entre dos números
         * Min() Retorna el más pequeño entre dos números
         * Pow() Retorna el número elevado a la potencia especificada
         * Sqrt() Retorna la raíz cuadrada de un número especificado
         * Truncate() Calcula la parte entera de un número
         * */
        static void Main(string[] args)
        {
            Cuadrado c1 = new Cuadrado(15);
            Circulo c2 = new Circulo(6);
            c1.Area();
            c2.Area();
            c1.Log();
            c2.RaizC();
        }
    }
}
