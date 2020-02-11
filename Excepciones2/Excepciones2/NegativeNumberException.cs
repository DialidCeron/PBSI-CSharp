using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones2
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException():base("Operación inválida con número negativo") { }
        public NegativeNumberException(string Mensaje):base(Mensaje) { }
    }
}
