using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }

        public Persona(string nombre, int edad, string genero, string nacionalidad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Nacionalidad = nacionalidad;
        }
    }
}
