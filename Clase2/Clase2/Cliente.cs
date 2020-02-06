using System;
using System.Collections.Generic;
using System.Text;

namespace Clase2
{
    class Cliente
    {
        //Atributos
        string nombre;
        int edad;
        int cuenta;
        double dinero;
        Random rm = new Random();
        public static int contador = 0;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Dinero
        {
            get { return dinero; }
            set { dinero = value; }
        }

        public int Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 0)
                    edad = 18;
                else
                    edad = value;
            }
        }
        //Métodos
        public void Retirar(double cantidad)
        {
            if(cantidad>dinero)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            dinero -= cantidad;
        }

        public void Depositar(double cantidad)
        {
            dinero += cantidad;
        }

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            dinero = 5000;
            cuenta = rm.Next(0, 100);

            contador = contador + 1;
        }
        public static string mensaje()
        {
            return "Bienvenidos al curso de C#";
        }
        public override string ToString()
        {
            return String.Format("Nombre:{0}, Edad:{1}", nombre, edad);
        }
    }
}
