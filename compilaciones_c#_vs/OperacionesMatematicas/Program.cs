using System;

namespace OperacionesMatematicas
{
    class Program
    {
        /*
         *Crear métodos para las operaciones de suma✔, resta✔, multiplicación✔, División✔, Modulo✔ y Potencia ✔.
         * Los metodos deben recibir 2 operandos (numeros) como parametros de ENTRADA y retornar el resultado.
        */

        static double Suma(double a, double b)
        {
            double suma = a + b;
            return suma;
        }

        static int Potencia(int b, int e)
        {
            int potencia = 1;
            for(int i =1; i <= e; i++) 
            {
                potencia = potencia * b;
            }

            return potencia;
        }

        static double Resta(double a, double b)
        {
            double resta = a - b;
            return resta;
        }

        static double Multiplicacion(double a, double b) 
        {
            double multiplicacion = a * b;
            return multiplicacion;
        }

        static double Division(double a, double b)
        {
            double division = a / b;
            return division;
        }

        static double Modulo(double a, double b)
        {
            double modulo = a % b;
            return modulo;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Resultado de la Suma: {0}", Suma(3, 3.5));
            Console.WriteLine("Resultado del Exponente: {0}", Potencia(2,2));
            Console.WriteLine("Resultado de la resta: {0}", Resta(10,7.5));
            Console.WriteLine("Resultado de la Multiplicación: {0}", Multiplicacion(2,5));
            Console.WriteLine("Resultado de la división: {0}", Division(10,2));
            Console.WriteLine("Resultado del modulo: {0}",Modulo(12,2));
        }
    }
}

