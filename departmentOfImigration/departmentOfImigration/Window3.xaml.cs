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
using System.Windows.Shapes;

namespace imigrationdepartment
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 thi = new Window3();
            thi.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 fir = new Window1();
            fir.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Hide();
            this.Visibility = Visibility.Hidden;
            InitializeComponent();
            Hide();
            Form2 fro = new Form2();
            fro.ShowDialog();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Hide();
            this.Visibility = Visibility.Hidden;
            InitializeComponent();
            Hide();
            Form1 from = new Form1();
            from.ShowDialog();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Hide();
            this.Visibility = Visibility.Hidden;
            InitializeComponent();
            Hide();
            Form3 third = new Form3();
           third.ShowDialog();
            Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
