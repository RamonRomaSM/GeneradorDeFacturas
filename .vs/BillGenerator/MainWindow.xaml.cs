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

namespace BillGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Generar_Pantalla(object sender, RoutedEventArgs e)
        {
           
        }
        private void Datos_Pantalla(object sender, RoutedEventArgs e)
        {
            
        }
        private void Ajustes_Pantalla(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
