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
using Сетевое_прогр._Практика__16_.ViewModel;

namespace Сетевое_прогр._Практика__16_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            frombox.ItemsSource = new Fval[]
            {
                new Fval {val = "RUB"},
                new Fval {val = "USD"},
                new Fval {val = "EUR"},
                new Fval {val = "GBP"},
                new Fval {val = "UAH"},
            };
            frombox.SelectedIndex = 0;
            tobox.ItemsSource = new Fval[]
            {
                new Fval {val = "RUB"},
                new Fval {val = "USD"},
                new Fval {val = "EUR"},
                new Fval {val = "GBP"},
                new Fval {val = "UAH"},
            };
            tobox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string from = frombox.SelectedItem.ToString();
                string to = tobox.SelectedItem.ToString();
                //vb.Navigate("https://mainfin.ru/konvert/" + from + "-" + to + "/" + tb1.Text);
                //vb.Navigate("https://www.banki.ru/products/currency/" + tb1.Text + from + "_" + to);
                vb.Navigate("https://www.google.ru  /search?q=" + tb1.Text.ToString() + from + "%D0%B2" + to);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
