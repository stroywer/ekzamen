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

namespace Ekzamen
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Vxod_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            MainFrame.Navigate(new VxodPage());
        }

        private void Now_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            MainFrame.Navigate(new NowPage());
        }

        private void NowFuture_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            MainFrame.Navigate(new NewFuturePage());
        }
    }
}
