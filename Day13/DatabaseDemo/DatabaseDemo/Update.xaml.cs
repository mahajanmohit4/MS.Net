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
using System.Data;
using System.Data.SqlClient;
namespace DatabaseDemo
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        public Update()
        {
            InitializeComponent();
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE Employees SET Name=@Name,Basic=@Basic,DeptNo=@DeptNo WHERE EmpNo=@EmpNo";

            cmd.Parameters.AddWithValue("@EmpNo", txtEmpNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Basic", txtBasic.Text);
            cmd.Parameters.AddWithValue("@DeptNo", txtDeptNo.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            cn.Close();
        
        }
    }
}
