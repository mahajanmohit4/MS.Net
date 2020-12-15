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

namespace Addition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int n1;
        static int n2;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void txtNum1_KeyDown(object sender, KeyEventArgs e)
        {
            int ascii = KeyInterop.VirtualKeyFromKey(e.Key);
          
            if (ascii >= 48 && ascii <= 57)
            {                
                MessageBox.Show(KeyInterop.VirtualKeyFromKey(e.Key).ToString() + " " + ascii);
            }
            else {
                e.Handled = true; 
                MessageBox.Show("Invalid Key Press");
            } 

        }

        private void txtNum2_KeyDown(object sender, KeyEventArgs e)
        {
            int ascii = KeyInterop.VirtualKeyFromKey(e.Key);
           
            if (ascii >= 48 && ascii <= 57)
            {                              
                MessageBox.Show(KeyInterop.VirtualKeyFromKey(e.Key).ToString() + " " + ascii);                
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Invalid Key Press");
            }
        }

        private void txtSum_TextChanged(object sender, TextChangedEventArgs e)
        {
            //int sum = n1 + n2;
            //txtSum.Text = sum.ToString();
            //txtSum.Text = sum.ToString();
        }

        private void txtNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            n1 = Int32.Parse(txtNum1.Text);
            int sum = n1+n2;
            txtSum.Text = sum.ToString();
        }

        private void txtNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            n2 = Int32.Parse(txtNum2.Text);
            int sum = n2+n1;
            txtSum.Text = sum.ToString();
        }
    }
}
