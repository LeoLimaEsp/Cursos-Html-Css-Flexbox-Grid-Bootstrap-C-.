using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_Entity_basics
{
    internal class Crud_Entity_Framework
    {
        //Paso 1 Estanciar el context
        static EscuelaEntities1 context = new EscuelaEntities1();

        //Método Read one student name
        static public void readOne(int idAlumno)
        {
            Alumno unAlumno = context.Alumno.FirstOrDefault(e => e.IdAlumno == idAlumno);
            if (unAlumno == null)
            {
                Console.WriteLine("No existe alumno con ese ID");
            }
            else
            {
                Console.WriteLine("Nombre: {0}  Apellido: {1}", unAlumno.Nombre, unAlumno.ApellidoPaterno);
            }

            Console.ReadLine();
        }

        //Método Read All student names
        static public void readAll()
        {
            List<Alumno> alumno = context.Alumno.ToList();

            foreach (Alumno item in alumno)
            {
                Console.WriteLine("Alumnos existentes: {0}, {1}", item.Nombre, item.ApellidoPaterno);
            }

            Console.ReadLine();
        }

        //Método Update student name
        static public void updateElement(int idAlumno)
        {
            Alumno alumnoActualizar = context.Alumno.FirstOrDefault(e => e.IdAlumno == idAlumno);
            Console.WriteLine("Ingrese nombre nuevo:");
            alumnoActualizar.Nombre = Console.ReadLine();
            context.SaveChanges();
            Console.WriteLine("Dato actualizado");
        }

        //Método Insert a new student
        static public void insertStudent()
        {
            Console.WriteLine("Ingresar los datos del alumno de la siguiente forma:" +
                "Nombre, Apellido paterno, Apellido materno, Telefono, Edad, Genero y Fecha de nacimmiento(yyyy-mm-dd)");
            Alumno nuevoAlumno = new Alumno()
            {
                Nombre = Console.ReadLine(),
                ApellidoPaterno = Console.ReadLine(),
                ApellidoMaterno = Console.ReadLine(),
                Telefono = Console.ReadLine(),
                Edad = Convert.ToInt32(Console.ReadLine()),
                Genero = Console.ReadLine(),
                FechaNacimiento = DateTime.Parse(Console.ReadLine())
            };
            context.Alumno.Add(nuevoAlumno);
            context.SaveChanges();
            Console.WriteLine("Alumno añadido con exito.");
        }

        //Método Delete a student
        static public void deleteStudent(int idAlumno)
        {
            Alumno alumnoBorrar = context.Alumno.FirstOrDefault(e => e.IdAlumno == idAlumno);
            context.Alumno.Remove(alumnoBorrar);
            context.SaveChanges();
            Console.WriteLine("Eliminación completada.");
        }

    }
}
