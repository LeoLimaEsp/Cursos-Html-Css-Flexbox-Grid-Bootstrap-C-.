using CodeFirst.Data;
using CodeFirst.Dominio;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                Student stud = new Student() { StudentName = "Bill"};

                context.Students.Add(stud);
                context.SaveChanges();
            }

            Console.WriteLine("Conexión con exito");
        }
    }
}