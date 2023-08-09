using MethodsArrayString;
using System;

namespace OperacionesMatematicas
{
    class Program
    {

        //Imprimir en pantalla todos los elementos de un arreglo de enteros.
        static void PrintArray(int[] array)
        {
            Console.WriteLine("PrintArray");
            foreach (int item in array) { 
                Console.Write(item + " ");}
            Console.WriteLine();
        }

        //Recibir un arreglo de enteros, a cada número PAR encontrado, lo debe convertir en -1 y retornar el mismi arreglo.
        static int[] FindEvents(int[] array)
        {
            Console.WriteLine("FindArray");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] = -1;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
           int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
           PrintArray(array);

           int[] modified = FindEvents(array);
           PrintArray(modified);

            //Mandar a llamar método de otra clase
            int prueba = StringUtility.CountSpaces("Hola amigos de programacion");
            Console.WriteLine(prueba);

            //Mandar a llamar método de otra clase
            bool exist = StringUtility.FindChar("casa casa casa", 'c');
            Console.WriteLine(exist);
        }
    }
}