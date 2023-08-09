using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Ado.NET
{
    public class AlumnoCRUD
    {
        //CONEXIÓN
        static string stringConnection = "Data Source= PC-Leo-Lima; Initial Catalog=Escuela; User ID=sa; Password=carrorojo98;";
        static SqlConnection connection = new SqlConnection(stringConnection);

        //READ
        public static void Select()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Alumno";
            connection.Open();

            SqlDataReader reader = command.ExecuteReader(); //Ejecución de la consulta       

            while (reader.Read() == true)
            {
                Console.WriteLine( " {0} {1} {2} {3} {4} {5} {6} {7} ", reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7));
            } 

            reader.Close();
            connection.Close();
        }

        //CREATE
        public static void Insert()
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = " INSERT INTO Alumno(Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, Edad, Genero, FechaNacimiento)  VALUES(@nombre, @apellidoP, @apellidoM, @telefono, @edad, @genero, @fechaNacimiento)";
            
            command.Parameters.AddWithValue("@nombre", "Juan Pablo");
            command.Parameters.AddWithValue("@apellidoP", "Garcia");
            command.Parameters.AddWithValue("@apellidoM", "Hérnandez");
            command.Parameters.AddWithValue("@telefono", "2212517635");
            command.Parameters.AddWithValue("@edad", 25);
            command.Parameters.AddWithValue("@genero", "M");
            command.Parameters.AddWithValue("@fechaNacimiento", DateTime.Now);

            int registros = command.ExecuteNonQuery();
            Console.WriteLine(  "Registros afectados: " + registros);
            connection.Close();
        }

        //DELETE
        public static void Delete(int id)
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = " DELETE FROM Alumno WHERE IdAlumno = @id ";

            command.Parameters.AddWithValue("@id", id);

            int registros = command.ExecuteNonQuery();
            Console.WriteLine("Registros afectados: " + registros);
            connection.Close();
        }

        //UPDATE
        public static void Update()
        {
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = " UPDATE Alumno SET Nombre = @nom, ApellidoPaterno = @AP, Edad = @edad, FechaNacimiento = @FechaN  WHERE IdAlumno = @Id ";

            command.Parameters.AddWithValue("@Id", 6);
            command.Parameters.AddWithValue("@nom", "German");
            command.Parameters.AddWithValue("@AP", "Flores");
            command.Parameters.AddWithValue("@edad", 22);           
            command.Parameters.AddWithValue("@fechaN", DateTime.Parse("1998-08-24"));

            int registros = command.ExecuteNonQuery();
            Console.WriteLine("Registros afectados: " + registros);
            connection.Close();
        }
    }
}
