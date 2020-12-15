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

namespace Addition
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstNames.Items.Add("Virat");
            lstNames.Items.Add("Pujara");
            lstNames.Items.Add("Rahane");

            lstNames_Copy.Items.Add("Math");
            lstNames_Copy.Items.Add("Computer");
            lstNames_Copy.Items.Add("Physics");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lstNames.Items.Count.ToString());
            //MessageBox.Show(lstNames.SelectedItem.ToString());
            //MessageBox.Show(lstNames.SelectedIndex.ToString());
            foreach (var item in lstNames.SelectedItems)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lstNames.Items.RemoveAt(lstNames.SelectedIndex);
        }

       

       

        private void lstNames_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
