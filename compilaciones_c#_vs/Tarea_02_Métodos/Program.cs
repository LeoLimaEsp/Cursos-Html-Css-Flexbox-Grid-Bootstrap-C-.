using System;

namespace Tarea02
{
    class Program
    {

        //Método para calcular el área de un rectángulo, recibiendo como parámetros la base y altura (double), como salida retornar el área.
        static double AreaRectangulo(double baase, double altura)
        {
            double areaa = (baase * altura);
            return areaa;
        }

        //Método para calcular el área de un círculo, recibiendo como parámetro el radio (double), como salida retornar el área.
        static double AreaCirculo(double radio)
        {
            double pi = 3.1415926;
            double radio2 = radio * radio;
            double resultado = pi * radio2;

            return resultado;
        }

        static void Main(string[] args)
        {
            double areaaa = AreaRectangulo(8, 3);
            Console.WriteLine("El area del rectangulo es: {0}", areaaa);

            double area = AreaCirculo(4.8);
            Console.WriteLine("El area del circulo es: {0}", area);
        }
    }
}