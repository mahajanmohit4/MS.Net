using Miniproject2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Miniproject2.Controllers
{
    public class UserController : Controller
    {



        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserClass obj)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = CommandType.Text;


                cmdInsert.CommandText = "insert into userdetails values(@Loginname,@Password,@Confirmpassword,@FullName,@EmailId,@City,@Phone)";

                cmdInsert.Parameters.AddWithValue("@Loginname", obj.Loginname);
                cmdInsert.Parameters.AddWithValue("@Password", obj.Password);
                cmdInsert.Parameters.AddWithValue("@Confirmpassword", obj.Confirmpassword);
                cmdInsert.Parameters.AddWithValue("@FullName", obj.FullName);
                cmdInsert.Parameters.AddWithValue("@EmailId", obj.EmailId);
                cmdInsert.Parameters.AddWithValue("@City", obj.City);
                cmdInsert.Parameters.AddWithValue("@Phone", obj.Phone);
                cmdInsert.ExecuteNonQuery();




                cn.Close();
                ViewBag.Msg = "User Registered Successfully";
                return RedirectToAction("login");


            }

            catch
            {

                return View();
            }
        }

        public ActionResult login()
        {
            HttpCookie cookie = Request.Cookies["Usercookie"];
            if (cookie != null)
            {
                ViewBag.uname = cookie["username"];
                ViewBag.pwd = cookie["pwd"];

            }

            return View();


        }

        [HttpPost]

        public ActionResult login(loginclass objlogin)

        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";
            cn.Open();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = CommandType.Text;

            cmdInsert.CommandText = "Select * from userdetails where Loginname=@Loginname and Password=@Password";

            cmdInsert.Parameters.AddWithValue("@Loginname", objlogin.LoginName);
            cmdInsert.Parameters.AddWithValue("@Password", objlogin.Password);
            SqlDataReader dr = cmdInsert.ExecuteReader();

            HttpCookie objCookie = new HttpCookie("Usercookie");
            if (objlogin.isRemember == true)
            {


                objCookie["username"] = objlogin.LoginName;
                objCookie["pwd"] = objlogin.Password;
                objCookie.Expires = DateTime.Now.AddDays(25);
                HttpContext.Response.Cookies.Add(objCookie);

            }

            else
            {
                objCookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Response.Cookies.Add(objCookie);


            }
            if (dr.Read())
            {

                Session["username"] = objlogin.LoginName.ToString();
                Session["fullname"] = dr[3];
                cn.Close();
                return RedirectToAction("Home");

            }

            else
            {

                ViewBag.Msg1 = "Enter the valid Username and Password";
                return login();
            }





        }



        public ActionResult Home()
        {


            return View();

        }
        [HttpPost]
        public ActionResult Homelogout()
        {

            Session.Abandon();
            return RedirectToAction("login");

        }

        public ActionResult update(string id)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM userdetails";

            SqlDataReader dr = cmd.ExecuteReader();
            List<UserClass> objEmpList = new List<UserClass>();

            UserClass objEmp = new UserClass();
            while (dr.Read())
            {
               
                if (id == dr["LoginName"].ToString())
                {
                     Loginname = Convert.ToString(dr["LoginName"]),
                        Password = Convert.ToString(dr["Password"]),
                        Confirmpassword = Convert.ToString(dr["Confirmpassword"]),
                        FullName = Convert.ToString(dr["FullName"]),
                        EmailId = Convert.ToString(dr["EmailId"]),
                        City = Convert.ToString(dr["City"]),
                        Phone = Convert.ToString(dr["Phone"])

                }
            }

            return View(objEmp);
            dr.Close();
            


        }

        [HttpPost]


        public ActionResult update(string id, UserClass objup)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";
            cn.Open();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = CommandType.Text;

            cmdInsert.CommandText = "Update userdetails set FullName=@Fullname,EmailId =@EmailId,City=@City,Phone=@Phone where Loginname=@Loginname";

            cmdInsert.Parameters.AddWithValue("@Loginname", id);
            cmdInsert.Parameters.AddWithValue("@Fullname", objup.FullName);
            cmdInsert.Parameters.AddWithValue("@EmailId", objup.EmailId);
            cmdInsert.Parameters.AddWithValue("@City", objup.City);
            cmdInsert.Parameters.AddWithValue("@Phone", objup.Phone);

            cmdInsert.ExecuteNonQuery();
            cn.Close();

            ViewBag.Msg3 = "Updated Successfully";
            return View();



        }


        [HttpPost]
        public ActionResult logout()
        {
            return RedirectToAction("login", "User");
        }
        



    }
}

