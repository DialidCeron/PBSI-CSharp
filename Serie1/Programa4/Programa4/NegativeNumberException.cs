using System;
using System.Collections.Generic;
using System.Text;

namespace Programa4
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("Operación inválida con número negativo") { }
        public NegativeNumberException(string Mensaje) : base(Mensaje) { }
    }
}
