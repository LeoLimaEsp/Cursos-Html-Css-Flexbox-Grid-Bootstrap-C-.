using System;

namespace Tarea01
{
    class Program
    {

        //Método que reciba cómo parámetros tres números decimales, como salida debes retornar el promedio de ellos.
        static double PrintPromedio(double a, double b, double c)
        {
            double promedio = (a + b + c) / 3;
            return promedio;
        }

        //Método que reciba cómo parámetros tres números enteros, como salida retornar el menor de ellos.
        static int NumeroMenor(int primero, int segundo, int tercero)
        {
            int resultado = 0;
            if (primero <= segundo && primero <= tercero)
            {
                resultado = primero;

            }
            else if (primero == segundo && primero == tercero)
            {
                resultado = primero;

            }
            else if (segundo <= primero && segundo <= tercero)
            {
                resultado = segundo;

            }
            else if (tercero <= primero && tercero <= segundo)
            {
                resultado = tercero;

            }
            return resultado;
        }

        static void Main(string[] args)
        {
            double prom = PrintPromedio(10, 10, 5);
            Console.WriteLine("El promedio es: {0}", prom);

            int menor = NumeroMenor(1, 10, 1);
            Console.WriteLine("El número menos es: {0}", menor);
        }
    }
}