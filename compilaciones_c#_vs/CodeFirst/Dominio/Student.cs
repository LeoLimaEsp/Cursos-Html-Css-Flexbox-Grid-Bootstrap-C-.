using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Dominio
{
    public class Student
    {
        //Convenciones para igualas resultados de tabla con base de datos y propiedades "Data Annotations "
        [Key]
        [Column("StudentID")]
        public int IdEstudent { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        
        //Propiedad de navegación
        public Grade Grade { get; set; }
    }
}
