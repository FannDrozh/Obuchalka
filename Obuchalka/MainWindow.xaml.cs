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

namespace Obuchalka
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

        private void StartTeor_Click(object sender, RoutedEventArgs e)
        {
            StartTeor.Visibility = Visibility.Hidden;
            Label.Visibility = Visibility.Hidden;
            Exit.Visibility = Visibility.Hidden;
            StartPract.Visibility = Visibility.Hidden;
            Teor1.Visibility = Visibility.Visible;
            ImageTeor1.Visibility = Visibility.Visible;
            Next1.Visibility = Visibility.Visible;            
        }

        private void Next1_Click(object sender, RoutedEventArgs e)
        {
            Teor1.Visibility = Visibility.Hidden;
            ImageTeor1.Visibility= Visibility.Hidden;
            Next1.Visibility = Visibility.Hidden;
            Teor2.Visibility = Visibility.Visible;
            ImageTeor2.Visibility = Visibility.Visible;
            Next2.Visibility = Visibility.Visible;
        }

        private void Next2_Click(object sender, RoutedEventArgs e)
        {
            Teor2.Visibility = Visibility.Hidden;
            ImageTeor2.Visibility = Visibility.Hidden;
            Next2.Visibility = Visibility.Hidden;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void StartPract_Click(object sender, RoutedEventArgs e)
        {
            StartTeor.Visibility = Visibility.Hidden;
            Label.Visibility = Visibility.Hidden;
            Exit.Visibility = Visibility.Hidden;
            StartPract.Visibility = Visibility.Hidden;
            Pract1.Visibility = Visibility.Visible;
            Image1.Visibility = Visibility.Visible;
            Next1.Visibility = Visibility.Visible;
        }
    }
}
