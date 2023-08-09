using System.Data.SqlClient;

namespace Conexion_con_BDD_calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
             * 1.- Crear una conexión a mi base de datos 
            */


            // String connection: Servidor fisico\instancia(Cuando hay mas de un motor de busqueda), Nombre de bd, Usuario, Contraseña
            string stringConnection = "Data Source= PC-Leo-Lima; Initial Catalog=Escuela; User ID=sa; Password=carrorojo98;";

            //string stringConnection = "Data Source= localhost; Initial Catalog=Escuela; User ID=sa; Password=carrorojo98;";

            // Un objeto de la clase SqlClient de tipo Connection, quien establece la conexión
            SqlConnection connection = new SqlConnection(stringConnection);

            // Prueba de conexión
            try
            {
                connection.Open();
                Console.WriteLine("Conexión exitosa");
                connection.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Conexión fallida \n" + ex);
            }

            /*2.- Crear y ejecutar un SELECT, usando SqlCommand: un objeto para ejecutar sentencias SQL
            */
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Alumno";

            // Ejecutar la instruccion o comando
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(); // EJECUCIÓN DE LA CONSULTA

            while (reader.Read() == true)
            {
                Console.WriteLine(reader.GetValue(1) + " " + reader.GetValue(2));
            }

            reader.Close();
            connection.Close();

        }
    }
}