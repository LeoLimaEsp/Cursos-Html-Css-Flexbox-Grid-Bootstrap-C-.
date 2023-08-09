using MVC_Escuela.Models;

namespace MVC_Escuela.BdD
{
    public class ProfesorDAO
    {
        public static List<ProfesorViewModel> Profesores = new List<ProfesorViewModel>();

        // Constructor estatico que se invoca automaticamente
        static ProfesorDAO()
        {
            Profesores.Add(new ProfesorViewModel { IdProfesor = 1, Nombre = "Enrique", ApellidoPaterno = "Guzman", ApellidoMaterno = "Hernandez", Edad = 34, Genero = "M", Email = "Enrique@gmail.com"});
            Profesores.Add(new ProfesorViewModel { IdProfesor = 2, Nombre = "Miguel", ApellidoPaterno = "Sanchez", ApellidoMaterno = "Martinez", Edad = 52, Genero = "M", Email = "Miguel@gmail.com" });
            Profesores.Add(new ProfesorViewModel { IdProfesor = 3, Nombre = "Juan", ApellidoPaterno = "Flores", ApellidoMaterno = "Barragan", Edad = 36, Genero = "M", Email = "Juan@gmail.com" });
            Profesores.Add(new ProfesorViewModel { IdProfesor = 4, Nombre = "Maria", ApellidoPaterno = "Lopez", ApellidoMaterno = "Hernandez", Edad = 29, Genero = "F", Email = "Maria@gmail.com" });
            Profesores.Add(new ProfesorViewModel { IdProfesor = 5, Nombre = "Fernanda", ApellidoPaterno = "Reyes", ApellidoMaterno = "Barrientos", Edad = 27, Genero = "F", Email = "Fernanda@gmail.com" });
        }

        // Retornar muchos Materias
        public static List<ProfesorViewModel> GetAll()
        {
            return Profesores;
        }

        public static void Save(ProfesorViewModel profesor)
        {
            profesor.IdProfesor = Profesores.Select(a => a.IdProfesor).Max() + 1;
            Profesores.Add(profesor);
        }

        public static ProfesorViewModel GetOne(int idP)
        {
            return Profesores.FirstOrDefault(a => a.IdProfesor == idP);
        }

        public static void Update(ProfesorViewModel profesor)
        {
            var current = Profesores.FirstOrDefault(a => a.IdProfesor == profesor.IdProfesor);
            current.Nombre = profesor.Nombre;
            current.ApellidoPaterno = profesor.ApellidoPaterno;
            current.ApellidoMaterno = profesor.ApellidoMaterno;
            current.Edad = profesor.Edad;
            current.Genero = profesor.Genero;
            current.Email = profesor.Email;
        }

        public static void Delete(int id)
        {
            var Profesor = GetOne(id);
            Profesores.Remove(Profesor);
        }
    }
}
