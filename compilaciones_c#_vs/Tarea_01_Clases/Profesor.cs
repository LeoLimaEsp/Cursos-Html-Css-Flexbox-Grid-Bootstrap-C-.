using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Profesor
    {
        string materia;

        public string GetMateria()
        {
            return "El nombre de la materia es: " + materia;
        }

        public void SetMateria(string materia)
        {
            this.materia = materia;
        }
    }
}
