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

namespace Primera_Interfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() //Aqui se trabaja el diseño con Grid
        {
            InitializeComponent();
            /*
            Grid miGrid = new Grid(); //Instanciamos para el diseño
            this.Content = miGrid; //Indicamos que aqui en la ventana content se establecera la grid
            Button miButton = new Button(); //Instanciamos un botón
            miButton.Width = 150;//Ajuste de ancho
            miButton.Height = 75;//Ajuste de alto
            miButton.Background = Brushes.Yellow; //Se coloco un background pero con la herramienta brushes obligatoria
            WrapPanel miWrap = new WrapPanel(); //Para añadir varios bloques de una etiqueta dentro de un elemento
            TextBlock text1 = new TextBlock(); //Bloque de texto
            text1.Text = "Hola";
            text1.Background = Brushes.White; //Se hizo un cambio de color en el background de letra.
            text1.Foreground = Brushes.Navy; //Se hizo cambio de color en letra
            miWrap.Children.Add(text1); //Metimos el primer texto al bloque miWrap
            TextBlock text2 = new TextBlock(); //Bloque de texto
            text2.Text = "que tal, como ¿estas?";
            text2.Background = Brushes.Gold; //Se hizo un cambio de color en el background de letra.
            text2.Foreground = Brushes.Red; //Se hizo cambio de color en letra
            miWrap.Children.Add(text2); //Metimos el segundo texto al bloque miWrap
            TextBlock text3 = new TextBlock(); //Bloque de texto
            text3.Text = "Adios";
            text3.Background = Brushes.Turquoise; //Se hizo un cambio de color en el background de letra.
            text3.Foreground = Brushes.AntiqueWhite; //Se hizo cambio de color en letra
            miWrap.Children.Add(text3); //Metimos el tercer texto al bloque miWrap
            miButton.Content = miWrap; //miWrap se establecera en miButton
            miGrid.Children.Add(miButton); //Metemos el hijo botón al grid
            */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("CLickeaste el boton numero 2");
        }

        /*
        private void Panel1_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Le has dado al panel1s");
        }
        */

        private void Panel1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado al panel1 con preview");
        }
    }
}
