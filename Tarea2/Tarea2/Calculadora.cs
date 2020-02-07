using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    static class Calculadora
    {
        public static double total;
        public static void calcular(double cal_proy, int tareas, int part)
        {
            if (part >= 8)
                total = (cal_proy * 0.6) + (tareas * 2 * 0.4) + 1;
            else
                total = (cal_proy * 0.6) + (tareas * 2 * 0.4);
            if (total > 10)
                total = 10;
            else if (total < 5)
                total = 5;
        }
    }
}
