using System.Collections.Generic;


namespace TareaCollectionsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Creación de lista de tipo carro
            List<Carro> listaCarros = new List<Carro>();

            //2. Instanciamos objetos
            Carro car1 = new Carro();

            Carro car2 = new Carro();

            Carro car3 = new Carro();   

            Carro car4 = new Carro();   

            Carro car5 = new Carro();

            //3. Asignar valores a los objetos
            car1.Marca = "Volvo";
            car1.Modelo = 2022;
            car1.Color = "Beige";

            car2.Marca = "Vw";
            car2.Modelo = 2021;
            car2.Color = "Azul-seda";

            car3.Marca = "Mazda";
            car3.Modelo = 2023;
            car3.Color = "Blanco-candy";

            car4.Marca = "Porsche";
            car4.Modelo = 2018;
            car4.Color = "Gris-grafito";

            //4. Metemos objetos a la lista
            listaCarros.Add(car1);
            listaCarros.Add(car2);
            listaCarros.Add(car3);
            listaCarros.Add(car4);
            listaCarros.Add(car5);

            //Asignación de valores por posición
            listaCarros[4].Modelo = 2019;
            listaCarros[4].Color = "Rojo-tornado";
            listaCarros[4].Marca = "Audi";

            //Visualizar contenido de la lista
            ImprimeLista(listaCarros);
        }

        static void ImprimeLista (List<Carro> listaCarros)
        {
            int i = 0;

            foreach (var lista in listaCarros)
            {
                i++;
                Console.WriteLine("Carro número:" + i);
                Console.WriteLine("Marca:" + lista.Marca + ", Modelo:" + lista.Modelo + ", Color:" + lista.Color + ".");
                Console.WriteLine();
            }
            
        }
    }

}