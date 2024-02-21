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

namespace PRaKIkA4stach_panel
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

        private void Butten_1_Click(object sender, RoutedEventArgs e)
        {
            Border.Background = Brushes.White;
            MessageBox.Show("цвет White встал ");
        }

        private void Butten_2_Click(object sender, RoutedEventArgs e)
        {
            Border.Background = Brushes.Gray;
            MessageBox.Show("цвет Gray встал ");
        }

        private void Butten_3_Click(object sender, RoutedEventArgs e)
        {
            Border.Background = Brushes.BurlyWood;
            MessageBox.Show("цвет BurlyWood встал ");
        }

        private void Butten_4_Click(object sender, RoutedEventArgs e)
        {
            Border.Background = Brushes.IndianRed;
            MessageBox.Show("вернул стандартный цвет");
        }
    }
}
