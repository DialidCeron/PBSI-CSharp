using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas //No se puede instanciar, puede tener métodos abstractos que son sólo la firma. 
{
    abstract class Animal
    {
        private string nombre;
        public string NombreComun
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Animal(string s)
        {
            NombreComun = s;
        }

        public abstract string Come
        {
            get;
        }
        public override string ToString()
        {
            return nombre+" "+Come;
        }
    }
}
