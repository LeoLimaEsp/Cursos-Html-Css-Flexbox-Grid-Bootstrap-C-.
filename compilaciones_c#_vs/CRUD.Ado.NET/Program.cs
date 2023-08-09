namespace CRUD.Ado.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicialización de métodos
            //AlumnoCRUD.Select();
            //AlumnoCRUD.Insert();
            //AlumnoCRUD.Delete(6);
            //AlumnoCRUD.Update();



            //Crear instancia de la clase alumno y dar valores: UPDATE
            Alumno alumno = new Alumno
            {
                IdAlumno = 2,
                Nombre = "Ignacio",
                ApellidoPaterno = "Ruiz",
                Edad = 31,
                FechaNacimiento = DateTime.Parse("1876-08-23")
            };
            //AlumnoDAO.Update(alumno);





            //Crear instancia de la clase alumno y dar valores: DELETE
            Alumno alumno2 = new Alumno
            {
                IdAlumno = 2,
            };
            //AlumnoDAO.Delete(alumno2);





            //Crear instancia de la clase alumno y dar valores: CREATE
            Alumno Alumno3 = new Alumno
            {
                Nombre = "Ignacio",
                ApellidoPaterno = "Martinez",
                ApellidoMaterno = "Juarez",
                Telefono = "22346578",
                Edad = 31,
                Genero = "M",
                FechaNacimiento = DateTime.Parse("1896-08-23")
            };
            //AlumnoDAO.Insert(Alumno3);







            //Crear instancia de la clase alumno y dar valores: READ
            Alumno Alumno4 = new Alumno
            {
                IdAlumno = 4,
            };
            AlumnoDAO.Select(Alumno4);


        }
    }
}