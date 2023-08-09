namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir el valor del nombre de clase persona
            Persona persona1= new Persona();
            persona1.ImprimeNombre("Carlos");

            //Imprimir el valor del promedio
            Estudiante estudiante1= new Estudiante();
            estudiante1.SetPromedio(9.7);
            Console.WriteLine("El promedio del estudiante es: " + estudiante1.GetPromedio());

            //Imprimir el nombre de la materia
            Profesor profesor1 = new Profesor();
            profesor1.SetMateria("Matematicas");
            Console.WriteLine(profesor1.GetMateria());
        }
    }
}