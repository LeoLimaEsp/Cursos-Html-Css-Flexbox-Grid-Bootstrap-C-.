using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace CRUD_LINQ
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;


        public MainWindow()
        {
            InitializeComponent();

            //Conexion con bdd
            string miConexion = ConfigurationManager.ConnectionStrings["CRUD_LINQ.Properties.Settings.CrudLinqSql"].ConnectionString;


            //Mapeo con datos a conectar con Linq
            dataContext = new DataClasses1DataContext(miConexion);

            //Llamada de metodo para insertar las empresas (Sólo la primera vez)
            /*InsertaEmpresas();*/

            /*InsertaEmpleados();*/

            /*InsertaCargos();*/

            /*AsignaCargo();*/

            //ActualizaEmpleado();
            borraDatos();
        }

        //Método para insertar datos en tabla EMPRESAS SIN usar linq o Sql
        public void InsertaEmpresas()
        {

            //Borrar todo antes de guardar empresas
            dataContext.ExecuteCommand("delete from empresa");

            //Empresa 1
            Empresa empresaFantasma = new Empresa();

            empresaFantasma.Nombre = "Empresa fantasma 1";

            //Integramos la información a la tabla con el mapeo
            dataContext.Empresa.InsertOnSubmit(empresaFantasma);

            //Empresa 2
            Empresa empresaFantasma2 = new Empresa();

            empresaFantasma2.Nombre = "Empresa fantasma 2";

            //Integramos la información a la tabla con el mapeo
            dataContext.Empresa.InsertOnSubmit(empresaFantasma2);


            //Confirmación de datos para integrar las dos empresas.
            dataContext.SubmitChanges();

            //Para mostrarse en interfaz
            Principal.ItemsSource = dataContext.Empresa;
        }

        //Método para insertar datos en tabla EMPLEADOS SIN usar linq o Sql
        public void InsertaEmpleados()
        {
            //Indicar que se integrara a las empresas, SIN usar expresiones lambda
            /*Empresa empresaFantasma = dataContext.Empresa.First("from Empresa in dataContext.Empresa where Empresa == 'Empresa fantasma 1' select Empresa");*/

            //Usando expresión lambda
            Empresa empresaFantasma = dataContext.Empresa.First(em => em.Nombre.Equals("Empresa Fantasma 1"));
            Empresa empresaFantasma2 = dataContext.Empresa.First(em => em.Nombre.Equals("Empresa Fantasma 2"));

            //Insertar empleados con la creación de una lista
            List<Empleado> listaEmpleados = new List<Empleado>();

            //Añadir empleados a la lista empleados
            listaEmpleados.Add(new Empleado { Nombre ="Leonel", Apellido ="Lima", EmpresaID =empresaFantasma.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Miguel", Apellido = "Hernandez", EmpresaID = empresaFantasma2.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Maria", Apellido = "Chong", EmpresaID = empresaFantasma2.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Jose", Apellido = "Lopez", EmpresaID = empresaFantasma.Id });

            //Insertar registros en la tabla empleados
            dataContext.Empleado.InsertAllOnSubmit(listaEmpleados);

            //Confirmación de insertar datos
            dataContext.SubmitChanges();

            //Mostrar en interfaz
            Principal.ItemsSource = dataContext.Empleado;
        }

        //Método que inserta cargos de empleo
        public void InsertaCargos()
        {
            //Cargo 1
            Cargo cargo1 = new Cargo();
            cargo1.NombreCargo = "Director General";
            dataContext.Cargo.InsertOnSubmit(cargo1);

            //Cargo 2
            Cargo cargo2 = new Cargo();
            cargo2.NombreCargo = "Director RRHH";
            dataContext.Cargo.InsertOnSubmit(cargo2);

            //Cargo 3
            dataContext.Cargo.InsertOnSubmit(new Cargo { NombreCargo = "Supervisor" });

            //Confirmación de datos para integrar los cargos a la tabla.
            dataContext.SubmitChanges();

            //Para mostrarse en interfaz
            Principal.ItemsSource = dataContext.Cargo;

        }

        public void AsignaCargo()
        {
            //Se instancian variables de tipo EMPLEADO donde se almacena la información de los nombres de empleados existentes
            Empleado leonel = dataContext.Empleado.First(em => em.Nombre.Equals("Leonel"));
            Empleado miguel = dataContext.Empleado.First(em => em.Nombre.Equals("Miguel"));
            Empleado maria = dataContext.Empleado.First(em => em.Nombre.Equals("Maria"));
            Empleado jose = dataContext.Empleado.First(em => em.Nombre.Equals("Jose"));

            //Se instancian variables de tipo CARGO donde se almacena la información de los nombres de cargos existentes
            Cargo directorG = dataContext.Cargo.First(em => em.NombreCargo.Equals("Director General"));
            Cargo directorRH = dataContext.Cargo.First(em => em.NombreCargo.Equals("Director RRHH"));
            Cargo supervisor = dataContext.Cargo.First(em => em.NombreCargo.Equals("Supervisor"));

            //Asignar empleado con cargo
            CargoEmpleado leoCargo = new CargoEmpleado();
            CargoEmpleado miguelCargo = new CargoEmpleado();
            CargoEmpleado mariaCargo = new CargoEmpleado();
            CargoEmpleado joseCargo = new CargoEmpleado();

            leoCargo.Empleado = leonel;
            leoCargo.Cargo = directorG;

            miguelCargo.Empleado = miguel;
            miguelCargo.Cargo = directorRH;

            mariaCargo.Empleado = maria;
            mariaCargo.Cargo = supervisor;

            joseCargo.Empleado = jose;
            joseCargo.Cargo = supervisor;

            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.CargoEmpleado;
        }

        //Método para actualizar datos de empleado u otra tabla
        public void ActualizaEmpleado()
        {
            Empleado maria = dataContext.Empleado.First(em => em.Nombre.Equals("Maria"));
            maria.Nombre = "Maria Luisa";

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleado;
        }

        //Método para borrar datos
        public void borraDatos()
        {
            Empleado jose = dataContext.Empleado.First(em => em.Nombre.Equals("Jose"));
            dataContext.Empleado.DeleteOnSubmit(jose);

            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleado;
        }

    }
}
