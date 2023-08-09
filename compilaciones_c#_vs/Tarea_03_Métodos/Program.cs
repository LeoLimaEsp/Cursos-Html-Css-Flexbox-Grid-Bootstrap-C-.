using System;

namespace Tarea03
{
    class Program
    {

        //Método que reciba como parámetro una cadena, como resultado retornar un número indicando la cantidad de vocales en la cadena.
        static int Cadena(string cadena)
        {
            int contador = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == 'a' || cadena[i] == 'e'|| cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u')
                    contador = contador + 1;                 
            }
            return contador;
        }

        //Método que reciba como parámetros un arreglo cadenas y una cadena. Cómo resultado retornar un número entero, indicando cuántas veces aparece la cadena en el arreglo.
        static int PalabraEnArray(string[] array ,string cadena)
        {
            int contador = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == cadena)
                    contador = contador + 1;
            }
            return contador;
        }



        static void Main(string[] args)
        {
            int vocales = Cadena("los elefantes son inteligentes");
            Console.WriteLine("Número de vocales en la cadena: {0}", vocales);

            string[] array = { "Praga", "Roma", "Roma", "Berlin", "Bilbao", "Roma", "Milan" };
            int numeroRepetidoCadena = PalabraEnArray(array, "Roma");
            Console.WriteLine("La palabra se encuentra {0} veces en el array.", numeroRepetidoCadena);

        }
    }
}
