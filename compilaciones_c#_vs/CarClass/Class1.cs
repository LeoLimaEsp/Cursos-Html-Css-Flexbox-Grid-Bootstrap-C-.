using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Carro
    {
        //Atributos
        public string marca;
        public int modelo;
        public double precio;

        //Métodos
        public void Avanzar()
        {
            Console.WriteLine("Carro de marca {0} avanza", marca);
        }

        public void Frenar()
        {
            Console.WriteLine("Carro de marca {0} se detiene", marca);
        }

        public void InforCar()
        {
            Console.WriteLine("Información del carro: Modelo {0}, Marca {1}, Precio de la unidad ${2} MXN", modelo, marca, precio);
        }
    }
}
