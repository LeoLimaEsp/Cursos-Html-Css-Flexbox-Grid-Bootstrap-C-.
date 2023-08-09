namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();

            // Agregando elementos 
            countries.Add("UK", "London");
            countries.Add("Mexico", "Mexico City");
            countries.Add("Japan", "Tokyo");
            countries.Add("Germany", "Berlin");

            // Consultando/leyendo elementos (valores por medio de la llave/clave)
            Console.WriteLine(countries["Mexico"]);
            Console.WriteLine(countries["Japan"]);

            // Modificar un elemento (modificar un valor por medio de la llave)
            countries["Japan"] = "Nagasaki";
            Console.WriteLine(countries["Japan"]);

            // Eliminar un elemento (se elimina la pareja, usando la llave como referencia)
            countries.Remove("Japan");


            // Consultar si un elemento existe o no
            Console.WriteLine( "PARTE DE PRUEBA" );
            string value;
            bool existe = countries.TryGetValue("Germany", out value);
            Console.WriteLine("{0} {1}", existe, value);

            // Consultar/leer todos los elementos del Dictionary (todas las parejas)
            foreach (var item in countries)
                Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);


            Console.WriteLine("Ejemplo 2");

            var direcciones = new Dictionary<string, Persona>();

            // Agregar elementos
            string calle = "Av. Centanario 456 Puebla";

            Persona p1 = new Persona();
            p1.Name = "Gabriela";
            p1.CURP = "FOJG901212HML3778";
            p1.Edad = 20;

            direcciones.Add(calle, p1);

            // Modificando el nombre de la persona
            direcciones[calle].Name = "Gabriela Marquez Jimenez";

            // Leer el objeto con la llave            
            Persona resultado = direcciones[calle];
            resultado.Name = "Gilberto Marquez Jimenez";

            string nombre = direcciones[calle].Name;

            Console.WriteLine(nombre);
            Console.WriteLine(direcciones[calle].CURP);
            Console.WriteLine(direcciones[calle].Edad);
        }
    }
}