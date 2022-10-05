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

namespace ISRPO_Palashicheva_PR6
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

        string l = "login";
        string p = "pass54321";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (log.Text != l)
            {
                MessageBox.Show("Не найден логин");

            }
            else if (pass.Text != p)
            {
                MessageBox.Show("Неверный пароль");
            }
            else if (log.Text == l && pass.Text == p)
            {
                Window1 window1 = new Window1();
                window1.Show();
                mainw.Close();
            }
        }
    }
}
