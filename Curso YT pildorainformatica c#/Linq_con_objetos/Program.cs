using System.Collections.Generic;

namespace Linq_con_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresaEmpleado ce = new ControlEmpresaEmpleado();
            Console.WriteLine("Introduce el ID perteneciente a la empresa:");
            string entrada = Console.ReadLine();

            try
            {
                int entradaId = Convert.ToInt32(entrada);
                if(entradaId >= 1 && entradaId <= 2)
                {
                    ce.getEmpleadoConEmpresa(entradaId);
                }
                else
                {
                    Console.WriteLine(  "Por favor ingrese un ID existente.");
                    string entradaa = Console.ReadLine();
                    int entradaIdd = Convert.ToInt32(entradaa);
                    ce.getEmpleadoConEmpresa(entradaIdd);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(  "Por favor ingrese valor númerico.");
                string entradaa = Console.ReadLine();
                int entradaId = Convert.ToInt32(entradaa);
                ce.getEmpleadoConEmpresa(entradaId);

            }

            
        }
    }

    class ControlEmpresaEmpleado
    {
        public ControlEmpresaEmpleado() 
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google"});
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Volkswagen" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Miguel", Cargo = "CEO", EmpresaID = 1, Salario = 15000});
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Juan", Cargo = "Gerente", EmpresaID = 1, Salario = 19000 });
            listaEmpleados.Add(new Empleado { Id= 3, Nombre = "Miguel Angel", Cargo = "CEO", EmpresaID = 1, Salario = 12000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "David", Cargo = "Director general", EmpresaID = 2, Salario = 16000 });
        }

        public List<Empresa>listaEmpresas;
        public List<Empleado> listaEmpleados;

        public void getCEO()
        {
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;

            foreach (Empleado empleadosCEO in ceos)
            {
                empleadosCEO.getDatosEmpleado();
            }
        }

        public void getSalarioMasBajo()
        {
            IEnumerable<Empleado> masBajo = from empleado in listaEmpleados where empleado.Salario <= 15000 select empleado;

            foreach (Empleado salarioBAJO in masBajo)
            {
                salarioBAJO.getDatosEmpleado();
            }
        }

        public void getEmpleadosPorNombre()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre descending select empleado;

            foreach (Empleado empleadosCEO in empleados)
            {
                empleadosCEO.getDatosEmpleado();
            }
        }

        public void getEmpleadoConEmpresa(int Id)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join empresa in listaEmpresas
                                              on empleado.EmpresaID equals empresa.Id
                                              where empresa.Id == Id
                                              select empleado;

            foreach (Empleado empleadosConEmpresa in empleados)
            {
                empleadosConEmpresa.getDatosEmpleado();
            }
        }
        
    }


    class Empresa
    {
        public int Id { get; set; }

        public string Nombre { get; set; }  

        public void getDatosEmpresa()
        {
            Console.WriteLine(  "Empresa: {0} con ID: {1}", Nombre, Id);
        }

    }

    class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }

        public double Salario { get; set; }
        //Clave foranea

        public int EmpresaID { get; set; }

        public void getDatosEmpleado()
        {
            Console.WriteLine("Empleado: {0}, con ID: {1}, cargo: {2}, con salario: {3}, pertenece a la empresa: {4}", Nombre, Id, Cargo, Salario, EmpresaID);
        }

    }
}