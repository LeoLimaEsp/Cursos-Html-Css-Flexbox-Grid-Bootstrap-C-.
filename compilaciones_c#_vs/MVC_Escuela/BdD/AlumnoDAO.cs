using MVC_Escuela.Models;
using System.Security.Cryptography.X509Certificates;

namespace MVC_Escuela.BdD
{
    public class AlumnoDAO
    {
        public static List<AlumnoViewModel> alumnos = new List<AlumnoViewModel>();

        //Constructor estatico que se invoca automatico.
        static AlumnoDAO () {
            alumnos.Add(new AlumnoViewModel { IdAlumno = 1, Nombre = "Leonel", ApellidoMaterno = "Lima", ApellidoPaterno = "Espinoza", Edad = 25, Email = "Leonel@hotmail.com", Genero = "M"});
            alumnos.Add(new AlumnoViewModel { IdAlumno = 2, Nombre = "Javier", ApellidoMaterno = "Hernandez", ApellidoPaterno = "Mendez", Edad = 23, Email = "Javier@hotmail.com", Genero = "M" });
            alumnos.Add(new AlumnoViewModel { IdAlumno = 3, Nombre = "Liliana", ApellidoMaterno = "Flores", ApellidoPaterno = "Enriquez", Edad = 32, Email = "Liliana@hotmail.com", Genero = "F"});
            alumnos.Add(new AlumnoViewModel { IdAlumno = 4, Nombre = "Susan", ApellidoMaterno = "Domingues", ApellidoPaterno = "Perez", Edad = 21, Email = "Susan@hotmail.com", Genero = "F" });
            alumnos.Add(new AlumnoViewModel { IdAlumno = 5, Nombre = "Ignacio", ApellidoMaterno = "Offarril", ApellidoPaterno = "Sanchez", Edad = 45, Email = "Ignacio@hotmail.com", Genero = "M"});
            alumnos.Add(new AlumnoViewModel { IdAlumno = 6, Nombre = "Juan", ApellidoMaterno = "Lopez", ApellidoPaterno = "Castillo", Edad = 18, Email = "Juan@hotmail.com", Genero = "M"});
        }

        public static List<AlumnoViewModel> GetAll()
        {
            return alumnos;
        }

        public static AlumnoViewModel GetOne(int iDAlumno)
        {

            AlumnoViewModel unAlumno = alumnos.Find(element => element.IdAlumno == iDAlumno);

            return unAlumno;
            
        }
    

        public static void Save(AlumnoViewModel alumno)
        {
            alumno.IdAlumno = alumnos.Select(a => a.IdAlumno).Max() + 1; //Para que se ponga el Id automatico.
            alumnos.Add(alumno);
        }

        public static void Update(AlumnoViewModel alumno)
        {
            var current = alumnos.FirstOrDefault(a => a.IdAlumno == alumno.IdAlumno);
            current.Nombre = alumno.Nombre;
            current.ApellidoPaterno = alumno.ApellidoPaterno;
            current.ApellidoMaterno = alumno.ApellidoMaterno;
            current.Edad = alumno.Edad;
            current.Genero = alumno.Genero;
            current.Email = alumno.Email;
        }


        public static void Delete(int id)
        {
            var alumno = GetOne(id);

            alumnos.Remove(alumno);
        }
    }
}
