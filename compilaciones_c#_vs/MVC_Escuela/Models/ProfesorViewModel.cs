namespace MVC_Escuela.Models
{
    public class ProfesorViewModel
    {
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad { get; set; }
        public string? Genero { get; set; }
        public string Email { get; set; }

        public List<MateriaViewModel> Materias { get; set; }
    }
}
