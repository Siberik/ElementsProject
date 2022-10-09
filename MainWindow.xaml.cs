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
using System.Xml.Schema;

namespace ElemetsProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         
        }

       

        private void NormalButtonClick(object sender, RoutedEventArgs e)
        {
           NormalButton.Background = Brushes.Blue;
        }

        private void ToggleButtonClick(object sender, RoutedEventArgs e)
        {
            if (ToggleButton.IsChecked == true)
            {
                ToggleButton.Content = "Сейчас true";
            }
            if (ToggleButton.IsChecked == false)
            {
                ToggleButton.Content = "Сейчас false";
            }



        }
    }
}
