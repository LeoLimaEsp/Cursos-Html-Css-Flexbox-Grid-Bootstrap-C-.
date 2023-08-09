namespace Intro_polimorfismo
{
    internal class Program
    {

        static void AnimalAction(Animal animal)
        {
            animal.MakeSound();
        }


        static void Main(string[] args)
        {
            Square cua = new Square();
            cua.Lado = 2;
            cua.Area();
            cua.Perimetro();

            Circle cir = new Circle();
            cir.Radio = 3;
            cir.Perimetro();
            cir.Area();

            Triangle tria = new Triangle();
            tria.altura = 4;
            tria.basee = 5;
            tria.Lado1 = 4;
            tria.Lado2 = 5;
            tria.Lado3 = 3.5;
            tria.Perimetro();
            tria.Area();
            
            Sphere esfera = new Sphere();
            esfera.Radio = 5;
            esfera.Volumen();

            Cube cubo = new Cube(); 
            cubo.Lado = 3;
            cubo.Volumen();


            Tetrahedron tetra = new Tetrahedron();
            tetra.Lado = 24;
            tetra.Volumen();

            Animal any = new Dog();
            any.MakeSound();
            any = new Cat();
            any.MakeSound();
            any = new Dog();

            AnimalAction(any);

            Cuadrado prueba = new Cuadrado();
            prueba.Lado = 9;
            Console.WriteLine(prueba.Area());
            prueba.Mensaje();
            
            
        }


    }

    
}