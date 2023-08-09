using System;

namespace Tarea04
{
    class Program
    {

        //Método que reciba como parámetros dos arreglos de números, ambos arreglos tienen el mismo tamaño.
        //Debes imprimir los elementos de los arreglos de forma alternada. Este método no retorna ningún resultado.
        static void NuevoArray(int[] array01, int[] array02)
        {
            int j = 0;
            int k = 1;
            int[] array03 = new int[10];

            for(int i = 0; i < array01.Length; i++) 
            {
                array03[j] = array01[i];
                j += 2;
                
            }

            for (int i = 0; i < array02.Length; i++)
            {
                array03[k] = array02[i];
                k += 2;
            }

            foreach (int item in array03)
            {
                Console.Write(item + " ");    
            }

        }

        static void Main(string[] args)
        {
            int[] array01 = {1,3,5,7,9};
            int[] array02 = {2,4,6,8,10};
            NuevoArray(array01, array02);
        }
    }
}