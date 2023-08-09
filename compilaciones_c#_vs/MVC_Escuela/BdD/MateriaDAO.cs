using MVC_Escuela.Models;

namespace MVC_Escuela.BdD
{
    public class MateriaDAO
    {
        public static List<MateriaViewModel> Materias = new List<MateriaViewModel>();

        // Constructor estatico que se invoca automaticamente
        static MateriaDAO()
        {
            Materias.Add(new MateriaViewModel { IdMateria = 1, Nombre = "Quimica", Grado = 1, Creditos = 20, Activa = true });
            Materias.Add(new MateriaViewModel { IdMateria = 2, Nombre = "Biologia", Grado = 1, Creditos = 20, Activa = true });
            Materias.Add(new MateriaViewModel { IdMateria = 3, Nombre = "Algoritmos", Grado = 1, Creditos = 20, Activa = true });
            Materias.Add(new MateriaViewModel { IdMateria = 4, Nombre = "Fisica", Grado = 1, Creditos = 20, Activa = true });
            Materias.Add(new MateriaViewModel { IdMateria = 5, Nombre = "Geometría", Grado = 1, Creditos = 20, Activa = true });
        }

        // Retornar muchos Materias
        public static List<MateriaViewModel> GetAll()
        {
            return Materias;
        }

        public static void Save(MateriaViewModel Materia)
        {
            Materia.IdMateria = Materias.Select(a => a.IdMateria).Max() + 1;
            Materias.Add(Materia);
        }

        public static MateriaViewModel GetOne(int idMateria)
        {
            return Materias.FirstOrDefault(a => a.IdMateria == idMateria);
        }

        public static void Update(MateriaViewModel materia)
        {
            var current = Materias.FirstOrDefault(a => a.IdMateria == materia.IdMateria);
            current.Nombre = materia.Nombre;
            current.Grado = materia.Grado;
            current.Creditos = materia.Creditos;
            current.Activa = materia.Activa;
        }

        public static void Delete(int id)
        {
            var Materia = GetOne(id);
            Materias.Remove(Materia);
        }
    }
}
