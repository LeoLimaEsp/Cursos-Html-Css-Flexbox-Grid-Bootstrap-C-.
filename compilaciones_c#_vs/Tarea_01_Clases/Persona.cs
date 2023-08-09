using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Persona
    {
        int edad;
        string nombre;

        public void ImprimeNombre(string nombre)
        {
            this.nombre = nombre;
            Console.WriteLine("El nombre de la persona es: {0}", nombre);
        }
    }
}
