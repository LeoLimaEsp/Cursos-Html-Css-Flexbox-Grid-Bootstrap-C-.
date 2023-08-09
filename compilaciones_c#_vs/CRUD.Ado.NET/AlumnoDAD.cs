using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Ado.NET
{
    internal class AlumnoDAO
    {
        //DAO - Data Access Object - Proposito es operar con la BDD
        //CONEXIÓN
        static string stringConnection = "Data Source= PC-Leo-Lima; Initial Catalog=Escuela; User ID=sa; Password=carrorojo98;";
        static SqlConnection connection = new SqlConnection(stringConnection);

        //UPDATE
        public static void Update(Alumno alumno)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = " UPDATE Alumno SET Nombre = @nom, ApellidoPaterno = @AP, Edad = @edad, FechaNacimiento = @FechaN  WHERE IdAlumno = @Id ";

            command.Parameters.AddWithValue("@Id", alumno.IdAlumno);
            command.Parameters.AddWithValue("@nom", alumno.Nombre);
            command.Parameters.AddWithValue("@AP", alumno.ApellidoPaterno);
            command.Parameters.AddWithValue("@edad", alumno.Edad);
            command.Parameters.AddWithValue("@fechaN", alumno.FechaNacimiento);

            int registros = command.ExecuteNonQuery();
            Console.WriteLine("Registros afectados: " + registros);
            connection.Close();
        }

        //DELETE
        public static void Delete(Alumno alumno2)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = " DELETE FROM Alumno WHERE IdAlumno = @id ";
            
            command.Parameters.AddWithValue("@id", alumno2.IdAlumno);

            int registros = command.ExecuteNonQuery();
            Console.WriteLine("Registros afectados: " + registros);
            connection.Close();
        }

        //CREATE
        public static void Insert(Alumno Alumno3)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = " INSERT INTO Alumno(Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, Edad, Genero, FechaNacimiento)  VALUES(@nombre, @apellidoP, @apellidoM, @telefono, @edad, @genero, @fechaNacimiento)";

            command.Parameters.AddWithValue("@nombre", Alumno3.Nombre);
            command.Parameters.AddWithValue("@apellidoP", Alumno3.ApellidoPaterno);
            command.Parameters.AddWithValue("@apellidoM", Alumno3.ApellidoMaterno);
            command.Parameters.AddWithValue("@telefono", Alumno3.Telefono);
            command.Parameters.AddWithValue("@edad", Alumno3.Edad);
            command.Parameters.AddWithValue("@genero", Alumno3.Genero);
            command.Parameters.AddWithValue("@fechaNacimiento", Alumno3.FechaNacimiento);

            int registros = command.ExecuteNonQuery();
            Console.WriteLine("Registros afectados: " + registros);
            connection.Close();
        }


        //READ  
        public static void Select(Alumno Alumno4)
        {
            List<Alumno> listaAlumnos = new List<Alumno>();

            Alumno alumno5 = new Alumno();

            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Alumno WHERE IdAlumno = @IdAlumno;";

            command.Parameters.AddWithValue("@IdAlumno", Alumno4.IdAlumno);
            SqlDataReader reader = command.ExecuteReader(); //Ejecución de la consulta   


            while (reader.Read() == true)
            {
                alumno5.IdAlumno = (int)reader.GetValue(0);
                alumno5.Nombre = (string)reader.GetValue(1);
                alumno5.ApellidoPaterno = (string)reader.GetValue(2);
                alumno5.ApellidoMaterno = (string)reader.GetValue(3);
                alumno5.Telefono = (string)reader.GetValue(4);
                alumno5.Edad = (int)reader.GetValue(5);
                alumno5.Genero = (string)reader.GetValue(6);
                alumno5.FechaNacimiento = (DateTime)reader.GetValue(7);
            }

            listaAlumnos.Add(alumno5);

            int i = 0;

            foreach (var lista in listaAlumnos)
            {
                i++;
                Console.WriteLine("IdAlumno:" + lista.IdAlumno + ", Nombre:" + lista.Nombre + ", Apellido paterno:" + lista.ApellidoPaterno + ", Apellido Materno:" + lista.ApellidoMaterno + ", Telefono:" + lista.Telefono + ", Edad:" + lista.Edad + ", Genero:" + lista.Genero + ", Fecha Nacimiento:" + lista.FechaNacimiento + ".");
                Console.WriteLine();
            }

            reader.Close();
            connection.Close();
        }
    }
}
