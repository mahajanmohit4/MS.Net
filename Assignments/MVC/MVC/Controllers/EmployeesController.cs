using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace MVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EMPLOYEES";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Employee> objEmpList = new List<Employee>();
            while (dr.Read())
            {
                objEmpList.Add(new Employee { EmpNo = (int)dr["EmpNo"], Name = (string)dr["Name"], Basic = (decimal)dr["Basic"], DeptNo = (short)(int)dr["DeptNo"] });
            }                  

            return View(objEmpList);
            dr.Close();
            cn.Close();
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id=0)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EMPLOYEES";          

            SqlDataReader dr = cmd.ExecuteReader();
            
            Employee objEmp = new Employee();
            while (dr.Read())
            {               
                if(id == (int)dr["EmpNo"])
                {
                    objEmp.EmpNo = (int)dr["EmpNo"];
                    objEmp.Name = (string)dr["Name"];
                    objEmp.Basic = (decimal)dr["Basic"];
                    objEmp.DeptNo = (short)(int)dr["DeptNo"];
                }
            }

            return View(objEmp);
            dr.Close();
            cn.Close();
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(Employee objEmp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO EMPLOYEES Values(@EmpNo,@Name,@Basic,@DeptNo)";

            cmd.Parameters.AddWithValue("@EmpNo", objEmp.EmpNo);
            cmd.Parameters.AddWithValue("@Name", objEmp.Name);
            cmd.Parameters.AddWithValue("@Basic", objEmp.Basic);
            cmd.Parameters.AddWithValue("@DeptNo", objEmp.DeptNo);
            try
            {
                cmd.ExecuteNonQuery();
               
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
          
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id = 0)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EMPLOYEES";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Employee> objEmpList = new List<Employee>();
            Employee objEmp = new Employee();
            while (dr.Read())
            {
                objEmpList.Add(new Employee { EmpNo = (int)dr["EmpNo"], Name = (string)dr["Name"], Basic = (decimal)dr["Basic"], DeptNo = (short)(int)dr["DeptNo"] });
                if (id == (int)dr["EmpNo"])
                {
                    objEmp.EmpNo = (int)dr["EmpNo"];
                    objEmp.Name = (string)dr["Name"];
                    objEmp.Basic = (decimal)dr["Basic"];
                    objEmp.DeptNo = (short)(int)dr["DeptNo"];
                }
            }

            return View(objEmp);
            dr.Close();
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, Employee objEmp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE EMPLOYEES SET Name=@Name, Basic=@Basic, DeptNo=@DeptNo WHERE EmpNo=@EmpNo";

            cmd.Parameters.AddWithValue("@EmpNo", id);
            cmd.Parameters.AddWithValue("@Name", objEmp.Name);
            cmd.Parameters.AddWithValue("@Basic", objEmp.Basic);
            cmd.Parameters.AddWithValue("@DeptNo", objEmp.DeptNo);
            try
            {
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EMPLOYEES";

            SqlDataReader dr = cmd.ExecuteReader();
          
            Employee objEmp = new Employee();
            while (dr.Read())
            {
                
                if (id == (int)dr["EmpNo"])
                {
                    objEmp.EmpNo = (int)dr["EmpNo"];
                    objEmp.Name = (string)dr["Name"];
                    objEmp.Basic = (decimal)dr["Basic"];
                    objEmp.DeptNo = (short)(int)dr["DeptNo"];
                }
            }

            return View(objEmp);
            dr.Close();
        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee objEmp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM EMPLOYEES WHERE EmpNo=@EmpNo";

            cmd.Parameters.AddWithValue("@EmpNo", id);
           
            try
            {
                cmd.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
