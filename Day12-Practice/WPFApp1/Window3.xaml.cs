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

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        static int x;
        static int y;
        public Window3()
        {
            InitializeComponent();
        }

        private void txtFullName_TextChanged(object sender, TextChangedEventArgs e)
        {            
            int sum = x + y;
            txtSum.Text = sum.ToString();
        }

        private void txtNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            x = Int32.Parse(txtNum1.Text);            
            int sum = x;
            txtSum.Text = sum.ToString();
        }

        private void txtNum2_TextChanged(object sender, TextChangedEventArgs e)
        {           
            y = Int32.Parse(txtNum2.Text);
            int sum = x + y;
            txtSum.Text = sum.ToString();
        }
    }
}
