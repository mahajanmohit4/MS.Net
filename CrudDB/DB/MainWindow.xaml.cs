
using DB.DataSet1TableAdapters;
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

namespace DB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        DataSet1 ds;
        private void Button_Click(object sender, RoutedEventArgs e)
        {   // FiLL
            ds = new DataSet1();
            EmployeesTableAdapter daEmps = new EmployeesTableAdapter();
            daEmps.Fill(ds.Employees);
            dgEmps.ItemsSource = ds.Employees.DefaultView;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   //Update
            EmployeesTableAdapter daEmps = new EmployeesTableAdapter();
            daEmps.Update(ds.Employees);
        }
    }
}
