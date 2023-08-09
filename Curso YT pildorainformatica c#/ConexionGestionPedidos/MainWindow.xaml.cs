using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Data.SqlClient;
using System.Data;


namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();

            MuestraTodosPedidos();
        }


        ///Clase que nos permita extraer info de la tabla y mostrar clientes
        private void MuestraClientes()
        {
            try
            {
                string consulta = "SELECT * FROM CLIENTE";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable clientesTabla = new DataTable();

                    miAdaptadorSql.Fill(clientesTabla);

                    listaClientes.DisplayMemberPath = "nombre";
                    listaClientes.SelectedValuePath = "Id";
                    listaClientes.ItemsSource = clientesTabla.DefaultView;

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        //Metodo para mostrar pedidos
        private void MuestraPedidos()
        {
            try
            {
                string consulta2 = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.ID=P.cCliente  WHERE C.ID=@ClienteId"; //Consulta sql parametrica

                SqlCommand sqlComando = new SqlCommand(consulta2, miConexionSql);  //Conexion con linea sql parametrica

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

                using (miAdaptadorSql)
                {

                    sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);


                    DataTable pedidosTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTabla);

                    pedidoCliente.DisplayMemberPath = "fechaPedido";
                    pedidoCliente.SelectedValuePath = "Id";
                    pedidoCliente.ItemsSource = pedidosTabla.DefaultView;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        ///Conexión para mostar información de una tabla en la interfaz grafica con la clase sqlConnection
        SqlConnection miConexionSql;

        private void listaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Has hecho click en un cliente");

            MuestraPedidos();
        }


        //Mostrar datos en listbox
        private void MuestraTodosPedidos()
        {
            try
            {
                string consulta = "SELECT *, CONCAT(cCLiente, '       ', fechaPedido, ' ', formaPago) AS INFOCOMPLETA FROM PEDIDO";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable pedidosTabla = new DataTable();
                    miAdaptadorSql.Fill(pedidosTabla);

                    todosPedidos.DisplayMemberPath = "INFOCOMPLETA";
                    todosPedidos.SelectedValuePath = "Id";
                    todosPedidos.ItemsSource = pedidosTabla.DefaultView;

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        //Metodo para borrar registros de la tabla
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //MessageBox.Show(todosPedidos.SelectedValue.ToString());
                string consulta = "DELETE FROM PEDIDO WHERE ID=@PEDIDOID";


                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();

                miSqlCommand.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);

                miSqlCommand.ExecuteNonQuery();

                miConexionSql.Close();
                MuestraTodosPedidos();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString(), "Acción no permitida");
            }
        }


        //Método para insertar datos a tabla
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                //MessageBox.Show(todosPedidos.SelectedValue.ToString());
                string consulta = "INSERT INTO CLIENTE (nombre) VALUES (@nombre)";


                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();

                miSqlCommand.Parameters.AddWithValue("@nombre", insertaCliente.Text); //.Text para guardar info del TextBox

                if (insertaCliente.Text != "")
                {
                    miSqlCommand.ExecuteNonQuery();

                    miConexionSql.Close();
                    MuestraClientes();
                    insertaCliente.Text = "";

                }
                else MessageBox.Show("Ingresa el nombre de un cliente");

            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString(), "Acción no permitida, Reinicie sistema.");
            }


        }

        //Metodo para borrar clientes
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {                
            try
            {
                    //MessageBox.Show(todosPedidos.SelectedValue.ToString());
                    string consulta = "DELETE FROM CLIENTE WHERE ID=@CLIENTEID";


                    SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                    miConexionSql.Open();

                    miSqlCommand.Parameters.AddWithValue("@CLIENTEID", listaClientes.SelectedValue);

                    miSqlCommand.ExecuteNonQuery();

                    miConexionSql.Close();
                    MuestraClientes();
            }
            catch (Exception f)
            {
                 MessageBox.Show(f.ToString(), "Acción no permitida");
            }
            
        }

        //Boton que me manda a metodo de actualizar informacion

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Actualiza ventanaActualizar = new Actualiza((int)listaClientes.SelectedValue);

            try
            {
                string consulta = "SELECT nombre FROM CLIENTE WHERE Id=@ClId";

                SqlCommand misqlCommand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(misqlCommand);

                using (miAdaptadorSql)
                {
                    misqlCommand.Parameters.AddWithValue("@ClId", listaClientes.SelectedValue);
                    
                    DataTable dt = new DataTable();

                    miAdaptadorSql.Fill(dt);

                    ventanaActualizar.cuadroActualizar.Text = dt.Rows[0]["nombre"].ToString();

                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }

            //muestra la ventana de actualizar y es en primer lugar
            ventanaActualizar.ShowDialog();

            //Metodo para actualizar la pantalla de clientes
            MuestraClientes();

        }
    }
}
