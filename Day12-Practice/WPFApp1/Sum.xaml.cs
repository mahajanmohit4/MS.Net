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
    /// Interaction logic for Sum.xaml
    /// </summary>
    public partial class Sum : Window
    {
        public Sum()
        {
            InitializeComponent();
        }

        private void txtNum2_KeyDown(object sender, KeyEventArgs e)
        {
            int ascii = KeyInterop.VirtualKeyFromKey(e.Key);
            MessageBox.Show(KeyInterop.VirtualKeyFromKey(e.Key).ToString()+" "+ascii);

            if(ascii <48 && ascii >57)


            if (ascii >= 48 && ascii <= 57)
            {
                e.Handled = true;
                txtNum2.Text = char.ConvertFromUtf32(ascii);
            }       
            else
                txtNum2.Text = null;
           
            // MessageBox.Show(e.Key.ToString());
        }
        private void txtNum1_KeyDown(object sender, KeyEventArgs e)
        {
            int ascii = KeyInterop.VirtualKeyFromKey(e.Key);
            MessageBox.Show(KeyInterop.VirtualKeyFromKey(e.Key).ToString() + " " + ascii);

            if (ascii < 48 && ascii > 57)


                if (ascii >= 48 && ascii <= 57)
                {
                    e.Handled = false;
                    MessageBox.Show(KeyInterop.VirtualKeyFromKey(e.Key).ToString() + " " + ascii);
                    //txtNum2.Text = char.ConvertFromUtf32(ascii);
                }
                else
                    txtNum2.Text = null;
        }
        private void txtNum1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtSum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
    }
}
