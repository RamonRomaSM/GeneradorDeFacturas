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

namespace BillGenerator.pantallas
{
    /// <summary>
    /// Lógica de interacción para DatosPantalla.xaml
    /// </summary>
    public partial class DatosPantalla : UserControl
    {
        public DatosPantalla()
        {
            InitializeComponent();
        }
        private void CambiarOpcion(object sender, RoutedEventArgs e)
        {
            //string opcion = ((Button)sender).Name;
            //switch (opcion)
            //{
            //    case "Generar":
            //        seleccionado.Background = null;
            //        seleccionado = (Button)sender;
            //        seleccionado.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#778DA9"));
            //        break;
            //    case "Datos":
            //        seleccionado.Background = null;
            //        seleccionado = (Button)sender;
            //        seleccionado.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#778DA9"));
            //        ContenedorPrincipal = new DatosPantalla();
            //        break;
            //    case "Ajustes":
            //        seleccionado.Background = null;
            //        seleccionado = (Button)sender;
            //        seleccionado.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#778DA9"));
            //        break;
            //}

        }
    }
}
