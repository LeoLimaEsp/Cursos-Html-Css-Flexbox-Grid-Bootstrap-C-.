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

namespace ListBoxPractica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            List<Poblaciones> listaPob = new List<Poblaciones> ();

            listaPob.Add(new Poblaciones() { Poblacion1 = "Puebla", Poblacion2 = "Tlaltenango", Temperatura1 = 23, Temperatura2 = 21, Diferencia=2 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "CDMX", Poblacion2 = "Tijuana", Temperatura1 = 26, Temperatura2 = 31, Diferencia=5 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Tlaxcala", Poblacion2 = "Chiapas", Temperatura1 = 15, Temperatura2 = 32, Diferencia=17 });
            listaPob.Add(new Poblaciones() { Poblacion1 = "Cholula", Poblacion2 = "Queretaro", Temperatura1 = 28, Temperatura2 = 25, Diferencia=3 });


            listaPoblaciones.ItemsSource = listaPob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(listaPoblaciones.SelectedItem != null){


                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("Selecciona un elemento");
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {

                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "°C " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "°C");
            }
            else
            {
                MessageBox.Show("Selecciona un elemento");
            }
        }
    }

    public class Poblaciones
    {
        public string Poblacion1 { get; set; }
        public int Temperatura1 { get; set; }
        public string Poblacion2 { get; set; }
        public int Temperatura2 { get; set; }

        public int Diferencia { get; set; }


    } 
}
