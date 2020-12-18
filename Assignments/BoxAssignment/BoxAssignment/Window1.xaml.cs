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

namespace BoxAssignment
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void WindowsLoad(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add("Data Structure");
            lstNames.Items.Add("Testing");
            lstNames.Items.Add("Cloud Computing");
            lstNames.Items.Add("Computer Network");
            lstNames.Items.Add("DBMS");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {//Forword dir
            foreach (var item in lstNames.SelectedItems)
            {
                lstNames_1.Items.Add(item.ToString());
            }
           
            lstNames.Items.RemoveAt(lstNames.SelectedIndex);
                      
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {//All Forword
            foreach (var item in lstNames.Items)
            {
                lstNames_1.Items.Add(item.ToString());

            }
            foreach (var item in lstNames_1.Items)
            {
                lstNames.Items.Remove(item.ToString());
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {//backword 

            foreach (var item in lstNames_1.SelectedItems)
            {
                lstNames.Items.Add(item.ToString());
            }

            lstNames_1.Items.RemoveAt(lstNames_1.SelectedIndex);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {//Backword All
            foreach (var item in lstNames_1.Items)
            {
                lstNames.Items.Add(item.ToString());

            }
            foreach (var item in lstNames.Items)
            {
                lstNames_1.Items.Remove(item.ToString());
            }
        }
    }
}
