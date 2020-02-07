using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Ap_pat { get; set; }
        public string Ap_mat { get; set; }
        public double Cal_proy { get; set; }
        public int Tareas { get; set; }
        public int Participaciones{ get; set; }

        public Alumno(string nombre, string ap_pat, string ap_mat, double cal_proy, int tareas, int part)
        {
            Nombre = nombre;
            Ap_pat = ap_pat;
            Ap_mat = ap_mat;
            Cal_proy = cal_proy;
            Tareas = tareas;
            Participaciones = part;
        }
    }
}
