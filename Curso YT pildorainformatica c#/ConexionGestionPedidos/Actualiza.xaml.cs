using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para Actualiza.xaml
    /// </summary>
    public partial class Actualiza : Window
    {
        private int z;

        public Actualiza(int elId)
        {
            InitializeComponent();
            z = elId;

            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
        }

        ///Conexión para mostar información de una tabla en la interfaz grafica con la clase sqlConnection
        SqlConnection miConexionSql;


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //MessageBox.Show(todosPedidos.SelectedValue.ToString());
                string consulta = "UPDATE CLIENTE SET nombre = @nombre WHERE Id= " + z;


                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();

                miSqlCommand.Parameters.AddWithValue("@nombre", cuadroActualizar.Text); //.Text para guardar info del TextBox

                if (cuadroActualizar.Text != "")
                {
                    miSqlCommand.ExecuteNonQuery();

                    miConexionSql.Close();
                    cuadroActualizar.Text = "";

                    MessageBox.Show("El nombre del cliente se a actualizado");

                    this.Close();
                }
                else MessageBox.Show("Ingresa el nuevo nombre de un cliente");

            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString(), "Acción no permitida, Reinicie sistema.");
            }
        }
    }
}
