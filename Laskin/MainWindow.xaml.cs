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

namespace Laskin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int eka;
        int toka;

        char op;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Content.ToString();
            toka = Int32.Parse(txtResult.Text);
        }

        private void subButton_Click(object sender, RoutedEventArgs e)
        {
            eka = Int32.Parse(txtResult.Text);
            op ='-';
            txtResult.Clear();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            eka = Int32.Parse(txtResult.Text);
            op = '+';
            txtResult.Clear();
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            eka = Int32.Parse(txtResult.Text);
            op = '/';
            txtResult.Clear();
        }

        private void multipleButton_Click(object sender, RoutedEventArgs e)
        {
            eka = Int32.Parse(txtResult.Text);
            op = '*';
            txtResult.Clear();
        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            toka = Int32.Parse(txtResult.Text);
            int result = 0;

            if (op == '+')
            {
                result = eka + toka;
            }

            else if (op == '-') 
            { 
                result = eka - toka; 
            }   

            else if (op == '*')
            {
                result = eka * toka;
            }
            else if (op == '/')
            {
                result = eka / toka;
            }
            txtResult.Text = result.ToString(); 
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Clear();
        }


    }
}
