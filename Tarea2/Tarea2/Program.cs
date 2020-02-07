using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Número de alumnos a calificar:");
            int tam = Convert.ToInt32(Console.ReadLine());
            Alumno[] alumnos = new Alumno[tam];
            for (int i = 0; i < tam; i++)
            {
                alumnos[i] = new Alumno(" ", " ", " ", 0, 0, 0);
                Console.WriteLine("Ingresa el nombre del alumno: ");
                alumnos[i].Nombre = Console.ReadLine();
                Console.WriteLine("Ingresa el apellido paterno del alumno: ");
                alumnos[i].Ap_pat = Console.ReadLine();
                Console.WriteLine("Ingresa el apellido materno del alumno: ");
                alumnos[i].Ap_mat = Console.ReadLine();
                Console.WriteLine("Calificación del alumno en el proyecto: ");
                alumnos[i].Cal_proy = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Número de tareas del alumno: ");
                alumnos[i].Tareas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Número de participaciones del alumno: ");
                alumnos[i].Participaciones = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < tam; i++)
            {
                Calculadora.calcular(alumnos[i].Cal_proy, alumnos[i].Tareas, alumnos[i].Participaciones);
                Console.WriteLine("Calificación total del alumno " + alumnos[i].Nombre + " " + alumnos[i].Ap_pat + " " + alumnos[i].Ap_mat + ": " + Calculadora.total);
            }
        }
    }
}
