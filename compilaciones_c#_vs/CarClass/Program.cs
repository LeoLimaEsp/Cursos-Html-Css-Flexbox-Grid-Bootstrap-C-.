using System;

namespace CarClass
{

    class Program
    {
        static void Main(string[] args)
        {

            // Instanciar un objeto de la clase Carro
            Carro carro = new Carro();
            carro.marca = "Volvo";
            carro.modelo = 2020;
            carro.precio = 324000.00;
            carro.Avanzar();
            carro.Frenar();
            carro.InforCar();

            /*
                Instanciar un nuevo objeto, de marca Honda e invocar a sus métodos
             */

            //instanciar un nuevo objeto de la clase Carro
            Carro carro_02 = new Carro();
            carro_02.marca = "Honda";
            carro_02.modelo = 2023;
            carro_02.precio = 420000.00;
            carro_02.Avanzar();
            carro_02.Frenar();
            carro_02.InforCar();



            Console.WriteLine(carro); // NO se puede imprimir todo el objeto

            // Para crear una variable SIN objeto. Denemos null
            Carro car = null;       // nada o vacio
            Console.WriteLine("null:" + car);


        }
    }
}