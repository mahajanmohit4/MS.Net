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
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using LinqToSql.MyDataSetTableAdapters;

namespace LinqToSql
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
       
        //Insert
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            Employee o = new Employee();

            try
            {
                o.EmpNo = Convert.ToInt32(txtEmpNo.Text);
                o.Name = txtName.Text;
                o.Basic = Convert.ToDecimal(txtBasic.Text);
                o.DeptNo = Convert.ToInt32(txtDeptNo.Text);
                dbContext.Employees.InsertOnSubmit(o);
                dbContext.SubmitChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgView1.ItemsSource = dbContext.Employees;
        }
        //Show 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();


            DataTable dt = dbContext.Employees.ToDataTable();
            dt.Columns.Remove("Department");
            dgView1.ItemsSource = dbContext.Employees;
           
            //ds = new MyDataSet();
            //EmployeesTableAdapter adEmps = new EmployeesTableAdapter();
            //adEmps.Fill(ds.Employees);
            //dgView1.ItemsSource = ds.Employees.DefaultView;

        }
        //Update
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            Employee o = dbContext.Employees.SingleOrDefault(emp => emp.EmpNo == Convert.ToInt32(txtEmpNo.Text));
            if (o != null)
            {
                try
                {
                    o.Name = txtName.Text;
                    o.Basic = Convert.ToDecimal(txtBasic.Text);
                    o.DeptNo = Convert.ToInt32(txtDeptNo.Text);

                    dbContext.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else MessageBox.Show("Employee with given employee number doesnt exists");
            dgView1.ItemsSource = dbContext.Employees;

        }
        //Delete
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            Employee o = dbContext.Employees.SingleOrDefault(emp => emp.EmpNo == Convert.ToInt32(txtEmpNo.Text));
            if (o != null)
            {
                dbContext.Employees.DeleteOnSubmit(o);
                dbContext.SubmitChanges();
            }
            else MessageBox.Show("Employee with given employee number doesnt exists");
            dgView1.ItemsSource = dbContext.Employees;
        }
    }
    public static class ListHelper
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> list)
        {
            DataTable dt = new DataTable();
            Type listType = list.ElementAt(0).GetType();
            //get element properties nad datatable columns 
            PropertyInfo[] properties = listType.GetProperties();

            foreach (PropertyInfo property in properties)
                dt.Columns.Add(new DataColumn() { ColumnName = property.Name });
            foreach (object item in list)
            {
                DataRow dr = dt.NewRow();
                foreach (DataColumn col in dt.Columns)
                    dr[col] = listType.GetProperty(col.ColumnName).GetValue(item, null);
                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
