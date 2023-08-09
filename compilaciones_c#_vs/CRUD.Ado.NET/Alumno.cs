using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Ado.NET
{
    internal class Alumno
    {
        //Manejo de patrón de diseño: POCO (Plain Old C# Object)
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
