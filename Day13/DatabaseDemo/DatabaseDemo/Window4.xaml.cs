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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DatabaseDemo
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection();
       
           
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=true";
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            cn.Open();
            cn.Close();
            MessageBox.Show("ok");
        }

        private void DataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
