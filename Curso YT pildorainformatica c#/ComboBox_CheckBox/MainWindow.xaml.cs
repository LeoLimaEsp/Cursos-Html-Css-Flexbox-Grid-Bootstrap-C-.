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

namespace ComboBox_CheckBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> ListaCapitales = new List<Capitales>();

            ListaCapitales.Add(new Capitales { NombreCapital = "Puebla"});
            ListaCapitales.Add(new Capitales { NombreCapital = "Sonora" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Queretaro" });
            ListaCapitales.Add(new Capitales { NombreCapital = "CD Juarez" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Tlaxcala" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Veracruz" });

            Capitales.ItemsSource = ListaCapitales;
        }

        private void TodasC_Checked(object sender, RoutedEventArgs e)
        {
            puebla.IsChecked = true;
            sonora.IsChecked = true;
            queretaro.IsChecked = true;
            cdjuarez.IsChecked = true;
            tlaxcala.IsChecked = true;
            veracruz.IsChecked = true;
        }

        private void TodasC_Unchecked(object sender, RoutedEventArgs e)
        {
            puebla.IsChecked = false;
            sonora.IsChecked = false;
            queretaro.IsChecked = false;
            cdjuarez.IsChecked = false;
            tlaxcala.IsChecked = false;
            veracruz.IsChecked = false;
        }

        private void Individualchecked(object sender, RoutedEventArgs e)
        {
            if (puebla.IsChecked == true && sonora.IsChecked == true && queretaro.IsChecked == true && cdjuarez.IsChecked == true && tlaxcala.IsChecked == true && veracruz.IsChecked == true)
            {
                TodasC.IsChecked = true;
            }
            else
            {
                TodasC.IsChecked = null;
            }
        }

        private void IndividualNochecked(object sender, RoutedEventArgs e)
        {
            if (puebla.IsChecked == false && sonora.IsChecked == false && queretaro.IsChecked == false && cdjuarez.IsChecked == false && tlaxcala.IsChecked == false && veracruz.IsChecked == false)
            {
                TodasC.IsChecked = false;
            }
            else
            {
                TodasC.IsChecked = null;
            }
        }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }

    }
}
