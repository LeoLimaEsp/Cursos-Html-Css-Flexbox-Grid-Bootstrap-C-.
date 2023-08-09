using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Intro_polimorfismo
{
    internal class Shape
    {
        public string Color { get; set; }
    }

    class TwoDimensionalShape : Shape
    {
        public virtual void Area()
        {
            Console.WriteLine("Area");
        }

        public virtual void Perimetro()
        {
            Console.WriteLine("Perimetro");
        }

    }

    class ThreeDimensionalShape : Shape
    {
        public virtual void Volumen()
        {
            Console.WriteLine("Volumen");
        }
    }

    class Square : TwoDimensionalShape
    {
        public double Lado { get; set; }

        public override void Area()
        {
            Console.WriteLine("Area cuadrado es: {0}", Lado * Lado);
        }
        public override void Perimetro()
        {
            Console.WriteLine("Perimetro cuadrado es: {0}", Lado * 4);
        }

    }

    class Circle : TwoDimensionalShape
    {
        double pi = 3.1416;
        public double Radio { get; set; }

        public override void Area()
        {
            Console.WriteLine("Area circulo es: {0}", pi * (Radio * Radio));
        }

        public override void Perimetro()
        {
            Console.WriteLine("Perimetro circulo es: {0}", (2 * pi) * Radio);
        }
    }

    class Triangle : TwoDimensionalShape
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public double basee { get; set; }
        public double altura { get; set; }

        public override void Perimetro()
        {
            Console.WriteLine("El perimetro del triangulo es: {0}", Lado1 + Lado2 + Lado3);
        }

        public override void Area()
        {
            Console.WriteLine("El area del triangulo es: {0}", (basee * altura) / 2);
        }

    }

    class Sphere : ThreeDimensionalShape
    {
        public double Radio { get; set; }

        double pi = 3.1416;

        public override void Volumen()
        {
            Console.WriteLine("El volumen de la esfera es: {0} cm3", (4 * pi * (Radio * Radio * Radio)) / 3);
        }
    }

    class Cube : ThreeDimensionalShape
    {
        public double Lado { get; set; }

        public override void Volumen()
        {
            Console.WriteLine("El volumen del cubo es: {0} cm3", Lado * Lado * Lado);
        }
    }

    class Tetrahedron : ThreeDimensionalShape
    {
        public double Lado { get; set; }


        public override void Volumen()
        {
            Console.WriteLine("Volumen de tetraedro: {0}", (Math.Sqrt(2) / 12) * Math.Pow(Lado,3));
        }

    }

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Grr!!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Dog : Animal, IMotor
    {
        public void Apagar()
        {
            throw new NotImplementedException();
        }

        public void Encender()
        {
            throw new NotImplementedException();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Goof");
        }
    }


    public abstract class TwoDimensional
    {
        public abstract double Area();

        public void Mensaje()
        {
            Console.WriteLine("Hola soy abstract");
        }
    }



    public class Cuadrado : TwoDimensional
    {
        public double Lado { get; set; }

        public override double Area()
        {
            return Lado * Lado;
        }
    }

    public class Cuadrado2 : TwoDimensional, IMotor

    {
        public double Lado { get; set; }

        public void Apagar()
        {
            throw new NotImplementedException();
        }

        public override double Area()
        {
            return Lado * Lado;
        }

        public void Encender()
        {
            throw new NotImplementedException();
        }
    }

    public interface ITerrestre
    {
        public void Acelerar();
        public void Frenar();
    }

    public interface IMotor
    {
        void Encender();
        void Apagar();
    }
}
