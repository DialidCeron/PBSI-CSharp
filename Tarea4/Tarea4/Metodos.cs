using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tarea4
{
    class Metodos
    { 
        public Metodos() {
        }
        public void ListarArchivos(string dir)
        {
            foreach (var elemento in Directory.GetFiles(dir))
               Console.WriteLine(elemento);
        }
        public void CambiarDirectorio(string dir)
        {
            Directory.SetCurrentDirectory(dir);
        }
        public void ImprimeHistorial(List<string> historial)
        {
            foreach (var elemento in historial)
                Console.WriteLine("{0}", elemento);
        }
        public void LimpiarPantalla()
        {
            Console.Clear();
        }
        public void CrearArchivo(string ruta)
        {
            File.Create(ruta);
        }
        public void MoverArchivo(string origen, string destino)
        {
            File.Move(origen, destino);
        }
    }
}
