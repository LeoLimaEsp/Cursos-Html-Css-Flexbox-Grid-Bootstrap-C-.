using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Estudiante
    {
        double promedio;
        string grupo;

        public double GetPromedio()
        {
            return promedio;
        }

        public void SetPromedio( double promedio)
        {
            this.promedio = promedio;
        }
        
    }
}
