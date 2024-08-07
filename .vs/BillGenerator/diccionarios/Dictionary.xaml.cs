using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace BillGenerator.diccionarios
{
    public partial class Dictionary : ResourceDictionary
    {
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            b.Background = (Brush)new BrushConverter().ConvertFrom("#778DA9");
        }
        private void hover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Background = (Brush)new BrushConverter().ConvertFrom("#778DA9");
        }
    }
   
}
