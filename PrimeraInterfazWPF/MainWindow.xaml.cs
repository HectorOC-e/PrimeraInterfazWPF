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

namespace PrimeraInterfazWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Grid miGrid = new Grid();

            //this.Content = miGrid;

            //Button miBoton = new Button();
            //WrapPanel miWrap = new WrapPanel();

            //TextBlock txt1 = new TextBlock();
            //TextBlock txt2 = new TextBlock();
            //TextBlock txt3 = new TextBlock();
            
            //miBoton.Width= 150;
            //miBoton.Height= 75;
            //miBoton.Background = Brushes.Black;
            //miBoton.BorderBrush = Brushes.Red;
            //miBoton.BorderThickness = new Thickness(2);

            //txt1.Text = "Click";
            //txt2.Text = "Enviar";
            //txt3.Text = "Correo";

            //txt1.Foreground = Brushes.Blue;
            //txt2.Foreground = Brushes.BlueViolet;
            //txt3.Foreground = Brushes.Yellow;

            //miWrap.Children.Add(txt1);
            //miWrap.Children.Add(txt2);
            //miWrap.Children.Add(txt3);

            //miBoton.Content = miWrap;


            //miGrid.Children.Add(miBoton);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Le has dado al boton");
            Console.WriteLine("Le has dado al boton 2");
        }

        //private void Panel_Click(object sender, RoutedEventArgs e)
        //{
        //    Console.WriteLine("Le has dado al Panel burbuja");
        //}

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Le has dado al Panel tunneling");
        }
    }
}
