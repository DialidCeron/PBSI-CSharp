using System;
using System.Collections.Generic;
using System.Text;

namespace Programa14
{
    interface InterfaceComida
    {
        string Nombre { get; set; }
        string Sabor { get; set; }
        bool Cocinado { get; set; }
        void Cocinar();
    }
}
