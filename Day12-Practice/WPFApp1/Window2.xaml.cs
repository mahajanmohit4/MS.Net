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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        static string firstName;
        static string lastName;
       
        public Window2()
        {
            InitializeComponent();
        }

        private void txtFullName_TextChanged(object sender, TextChangedEventArgs e)
        {
             string fullName = firstName +" "+lastName;
             txtFullName.Text = fullName;
            //txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
        }

        private void txtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lastName = (string)txtLastName.Text;
            string fullName = firstName + " " + lastName;
            txtFullName.Text = fullName;
            // txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
        }

        private void txtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            firstName = (string)txtFirstName.Text;
            string fullName = firstName + " " + lastName;
            txtFullName.Text = fullName;
            // txtFullName.Text = txtFirstName.Text + " " + txtLastName.Text;
        }
    }
}
