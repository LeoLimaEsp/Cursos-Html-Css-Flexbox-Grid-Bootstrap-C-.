namespace LINQExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ejemplo 1: filtramos los números pares de una lista */
            #region Ejemplo1
            var valores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var pares = from item in valores
                        where item % 2 == 0
                        select item;

            foreach (var item in pares)
            {
                Console.WriteLine(item);
            }
            #endregion

            /* Ejemplo 2: filtramos los números impares y los ordenamos */
            #region Ejemplo2
            Console.WriteLine("++++ Ejemplo 2 ++++");
            var numeros = new List<int> { 3, 1, 2, 4, 9, 5, 8, 11, 6 };

            var impares = from item in numeros
                          where item % 2 != 0
                          orderby item descending
                          select item;

            foreach (var item in impares)
            {
                Console.WriteLine(item);
            }
            #endregion

            /* Ejemplo 3 : filtrar listas de objetos */
            #region Ejemplo3
            Console.WriteLine("++++ Ejemplo 3 ++++");
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("Fernando", 21, "M", "Mexico"));
            personas.Add(new Persona("Hilda", 40, "F", "Mexico"));
            personas.Add(new Persona("Alejandro", 29, "M", "Chile"));
            personas.Add(new Persona("Roberto", 31, "M", "Colombia"));
            personas.Add(new Persona("Lucia", 25, "F", "Cuba"));
            personas.Add(new Persona("Julieta", 21, "F", "Mexico"));
            personas.Add(new Persona("Julio", 27, "M", "Italia"));

            // 1. filtro: personas de México
            var mexicanos = from p in personas
                            where p.Nacionalidad == "Mexico"
                            select p;

            foreach (var item in mexicanos)
            {
                Console.WriteLine(item.Nombre);
            }

            // 2. filtro: nombres de las mujeres
            var mujeres = from p in personas
                          where p.Genero == "F" && p.Edad > 18
                          select p.Nombre;

            foreach (var item in mujeres)
            {
                Console.WriteLine("2: " + item);
            }

            // 3. filtro: personas mayores de 25 y no sean de Mexico, ordenadas por edad
            var filtro3 = from p in personas
                          where p.Edad > 25 && p.Nacionalidad != "Mexico"
                          orderby p.Edad
                          select p;

            foreach (var item in filtro3)
            {
                Console.WriteLine("{0} - {1} - {2}", item.Nombre, item.Nacionalidad, item.Edad);
            }

            #endregion
        }
    }
}