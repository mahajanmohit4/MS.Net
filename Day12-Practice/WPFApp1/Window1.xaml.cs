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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        static string firstName;
        static string lastName;
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // string fullNmae = firstName + " " + lastName;
            // txtFullName.Text = fullNmae;

            //second Method
            txtFullName.Text = txtFirstName + " " + txtLasstName;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             firstName = (string)txtFirstName.Text;
        }

        private void txtLasstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lastName = (string)txtLasstName.Text;
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            lastName = (string)txtLasstName.Text;
           // MessageBox.Show("txtFirstNmae_KeyDown");
        }

        private void txtFullName_TextChanged(object sender, TextChangedEventArgs e)
        {
            // txtFullName.Text = (string)txtFirstName.Text;
            txtFullName.Text = txtFirstName + " " + txtLasstName;
        }
    }
}
