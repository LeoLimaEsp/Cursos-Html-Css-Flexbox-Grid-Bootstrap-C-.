using CodeFirst.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data
{
    public class SchoolContext: DbContext
    {
        //Invocación a la base para reutilizar las caracteristicas del padre.
        public SchoolContext() : base("name=SchoolDBConnectionString")
        {

        }

        //Los DbSets para hacer CRUD
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
