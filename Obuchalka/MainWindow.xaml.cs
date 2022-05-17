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
        //Теория
        private void StartTeor_Click(object sender, RoutedEventArgs e)
        {
            StartTeor.Visibility = Visibility.Hidden;
            Label.Visibility = Visibility.Hidden;
            Exit.Visibility = Visibility.Hidden;
            StartPract.Visibility = Visibility.Hidden;
            Teor1.Visibility = Visibility.Visible;
            ImageTeor1.Visibility = Visibility.Visible;
            Next1.Visibility = Visibility.Visible;    
            GlavTeor1.Visibility= Visibility.Visible;
        }
        //Стр 1
        private void Next1_Click(object sender, RoutedEventArgs e)
        {
            Teor1.Visibility = Visibility.Hidden;
            ImageTeor1.Visibility= Visibility.Hidden;
            Next1.Visibility = Visibility.Hidden;
            GlavTeor1.Visibility = Visibility.Hidden;
            Teor2.Visibility = Visibility.Visible;
            ImageTeor2.Visibility = Visibility.Visible;
            Next2.Visibility = Visibility.Visible;
            Back2.Visibility = Visibility.Visible;
        }
        private void GlavTeor1_Click(object sender, RoutedEventArgs e)
        {
            Teor1.Visibility = Visibility.Hidden;
            ImageTeor1.Visibility = Visibility.Hidden;
            Next1.Visibility = Visibility.Hidden;
            GlavTeor1.Visibility = Visibility.Hidden;
            StartTeor.Visibility = Visibility.Visible;
            Label.Visibility = Visibility.Visible;
            Exit.Visibility = Visibility.Visible;
            StartPract.Visibility = Visibility.Visible;
        }
        //Стр 2
        private void Next2_Click(object sender, RoutedEventArgs e)
        {
            Teor2.Visibility = Visibility.Hidden;
            ImageTeor2.Visibility = Visibility.Hidden;
            Next2.Visibility = Visibility.Hidden;
            Back2.Visibility= Visibility.Hidden;
            TeorLast.Visibility = Visibility.Visible;
            ImageTeorLast.Visibility = Visibility.Visible;
            GlavTeorLast.Visibility = Visibility.Visible;
            BackLast.Visibility = Visibility.Visible;
        }
        private void Back2_Click(object sender, RoutedEventArgs e)
        {
            Teor2.Visibility = Visibility.Hidden;
            ImageTeor2.Visibility = Visibility.Hidden;
            Next2.Visibility = Visibility.Hidden;
            Back2.Visibility = Visibility.Hidden;
            Teor1.Visibility = Visibility.Visible;
            ImageTeor1.Visibility = Visibility.Visible;
            Next1.Visibility = Visibility.Visible;
            GlavTeor1.Visibility= Visibility.Visible;
        }
        //Последняя стр
        private void GlavTeorLast_Click(object sender, RoutedEventArgs e)
        {
            TeorLast.Visibility = Visibility.Hidden;
            ImageTeorLast.Visibility = Visibility.Hidden;
            GlavTeorLast.Visibility = Visibility.Hidden;
            BackLast.Visibility= Visibility.Hidden;
            StartTeor.Visibility = Visibility.Visible;
            Label.Visibility = Visibility.Visible;
            Exit.Visibility = Visibility.Visible;
            StartPract.Visibility = Visibility.Visible;
        }
        private void BackLast_Click(object sender, RoutedEventArgs e)
        {
            Teor2.Visibility = Visibility.Visible;
            ImageTeor2.Visibility = Visibility.Visible;
            Next2.Visibility = Visibility.Visible;
            Back2.Visibility = Visibility.Visible;
            TeorLast.Visibility = Visibility.Hidden;
            ImageTeorLast.Visibility = Visibility.Hidden;
            GlavTeorLast.Visibility = Visibility.Hidden;
            BackLast.Visibility = Visibility.Hidden;
        }
        //Выход
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        //Практика
        private void StartPract_Click(object sender, RoutedEventArgs e)
        {
            StartTeor.Visibility = Visibility.Hidden;
            Label.Visibility = Visibility.Hidden;
            Exit.Visibility = Visibility.Hidden;
            StartPract.Visibility = Visibility.Hidden;
            Pract1.Visibility = Visibility.Visible;
            ImagePract1.Visibility = Visibility.Visible;
            Zad1.Visibility = Visibility.Visible;
        }
        //Выход на главную из практики
        private void GlavPract_Click(object sender, RoutedEventArgs e)
        {
            GlavPract.Visibility = Visibility.Hidden;
            LabelPr.Visibility = Visibility.Hidden;
            Pr1.Visibility = Visibility.Hidden;
            Pr2.Visibility = Visibility.Hidden;
            StartTeor.Visibility = Visibility.Visible;
            Label.Visibility = Visibility.Visible;
            Exit.Visibility = Visibility.Visible;
            StartPract.Visibility = Visibility.Visible;
        }

    }
}
