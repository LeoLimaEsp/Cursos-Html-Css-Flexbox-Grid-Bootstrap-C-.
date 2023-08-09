using System.ComponentModel.DataAnnotations;

namespace MVC_Escuela.Models
{
    public class AlumnoViewModel
    {
        [Display(Name = "Id")]
        public int IdAlumno { get; set; }

        [Required(ErrorMessage ="Campo requerido")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        public string? ApellidoPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        public string ApellidoMaterno { get; set; }

        [Range(0, 130, ErrorMessage = "Valor no válido")]
        public int Edad { get; set; }

        [RegularExpression("M|F|NA", ErrorMessage = "Los valores validos son: M, F, NA")]
        public string? Genero { get; set; }

        [EmailAddress(ErrorMessage = "Correo no válido")]
        public string Email { get; set; }

        //Cada alumno puede tomar hasta 3 materias
        [Display(Name = "Materia 1")]
        public int iDMateria1 { get; set; }

        [Display(Name = "Materia 1")]
        public int iDMateria2 { get; set; }

        [Display(Name = "Materia 1")]
        public int iDMateria3 { get; set; }

        // Esta lista sirve para pasar las Materias de: Controller -> View
        public IEnumerable<MateriaViewModel> Materias { get; set; }

        //Crear un constructor, donde instanciemos la lista de Materias
        public AlumnoViewModel() 
        {
            Materias = new List<MateriaViewModel>();
        }
    }
}
