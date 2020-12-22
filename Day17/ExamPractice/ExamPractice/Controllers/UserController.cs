using ExamPractice.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamPractice.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<User> objUser = new List<User>();



            
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users";

            SqlCommand cmdCities = new SqlCommand();
            cmdCities.Connection = cn;
            cmdCities.CommandType = CommandType.Text;
            cmdCities.CommandText = "select * from cities";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                User o = new User();
                o.userId = Convert.ToInt32(dr["userId"]);
                o.LoginName = (string)(dr["LoginName"]);
                o.Password = (string)(dr["Password"]);
                o.FullName = (string)(dr["FullName"]);
                o.Email = (string)(dr["Email"]);
                o.CityId = Convert.ToInt32(dr["CityId"]);
                o.Phone = (string)(dr["Phone"]);
                objUser.Add(o);

               
                SqlDataReader dr2 = cmdCities.ExecuteReader();

                List<SelectListItem> ctList = new List<SelectListItem>();
                while (dr2.Read())
                {
                    new SelectListItem { Text = dr2["CityName"].ToString(), Value = dr2["CityId"].ToString() };
                  o.Cities = ctList;
                    
                }
                dr2.Close();
            }


            dr.Close();
            cn.Close();

            return View(objUser);
       }

        // GET: User/Details/5
        public ActionResult Details(int UserId)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where  userId = @userId";
            cmd.Parameters.AddWithValue("@userId", UserId);

            SqlDataReader dr = cmd.ExecuteReader();


            User objUser = new User();


            while (dr.Read())
            {


                objUser.userId = Convert.ToInt32(dr["userId"]);
                objUser.LoginName = (string)(dr["LoginName"]);
                objUser.Password = (string)(dr["Password"]);
                objUser.FullName = (string)(dr["FullName"]);
                objUser.Email = (string)(dr["Email"]);
                objUser.CityId = Convert.ToInt32(dr["CityId"]);
                objUser.Phone = (string)(dr["Phone"]);
               
            }


            dr.Close();
            cn.Close();
            return View(objUser);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmdCities = new SqlCommand();
            cmdCities.Connection = cn;
            cmdCities.CommandType = CommandType.Text;
            cmdCities.CommandText = "select * from cities";
            SqlDataReader dr2 = cmdCities.ExecuteReader();


            User o = new User();
            List<SelectListItem> ctList = new List<SelectListItem>();
            while (dr2.Read())
            {
                ctList.Add(new SelectListItem { Text = dr2["CityName"].ToString(), Value = dr2["CityId"].ToString() });
                
                o.Cities = ctList;
            }
            dr2.Close();
            return View(o);
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User objUser)
        {
            try
            {
                // TODO: Add insert logic here
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

                cn.Open();

                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = CommandType.Text;
                cmdInsert.CommandText = "insert into users values(@userId,@LoginName,@Password,@FullName,@Email,@CityId,@Phone)";

                cmdInsert.Parameters.AddWithValue("@userId", objUser.userId);
                cmdInsert.Parameters.AddWithValue("@LoginName", objUser.LoginName);
                cmdInsert.Parameters.AddWithValue("@Password", objUser.Password);
                cmdInsert.Parameters.AddWithValue("@FullName", objUser.FullName);
                cmdInsert.Parameters.AddWithValue("@Email", objUser.Email);
                cmdInsert.Parameters.AddWithValue("@CityId", objUser.CityId);
                cmdInsert.Parameters.AddWithValue("@Phone", objUser.Phone);



                cmdInsert.ExecuteNonQuery();
                //da.InsertCommand = cmdInsert;

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int UserId = 0)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where  userId = @userId";
            cmd.Parameters.AddWithValue("@userId", UserId);


            SqlCommand cmdCities = new SqlCommand();
            cmdCities.Connection = cn;
            cmdCities.CommandType = CommandType.Text;

            SqlCommand cmdTemp = new SqlCommand();
            cmdTemp.Connection = cn;
            cmdTemp.CommandType = CommandType.Text;
            



            SqlDataReader dr = cmd.ExecuteReader();


            User objUser = new User();


            while (dr.Read())
            {


                objUser.userId = Convert.ToInt32(dr["userId"]);
                objUser.LoginName = (string)(dr["LoginName"]);
                objUser.Password = (string)(dr["Password"]);
                objUser.FullName = (string)(dr["FullName"]);
                objUser.Email = (string)(dr["Email"]);
                objUser.CityId = Convert.ToInt32(dr["CityId"]);
                objUser.Phone = (string)(dr["Phone"]);

                cmdTemp.CommandText = "select * from cities where CityId=" + objUser.CityId;

                SqlDataReader dr3 = cmdTemp.ExecuteReader();
                string name=null;
                while (dr3.Read())
                {
                    name = dr3["CityName"].ToString();
                }
                
                dr3.Close();


                cmdCities.CommandText = "select * from cities ";
                SqlDataReader dr2 = cmdCities.ExecuteReader();
                List<SelectListItem> ctList = new List<SelectListItem>();
                while (dr2.Read())
                {
                    if (name.Equals(dr2["CityName"].ToString()))
                    {
                        ctList.Add(new SelectListItem { Text = dr2["CityName"].ToString(), Value = dr2["CityId"].ToString(),Selected=true});
                    }
                    else {
                        ctList.Add(new SelectListItem { Text = dr2["CityName"].ToString(), Value = dr2["CityId"].ToString() });  
                    }

                    objUser.Cities = ctList;

                }
                dr2.Close();
            }

            
            
           
            

            dr.Close();
            cn.Close();
            return View(objUser);


            
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int UserId, User objUser)
        {
            try { 
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = "update users set LoginName=@LoginName,Password=@Password,FullName=@FullName,Email=@Email,CityId=@CityId,Phone=@Phone where userId=@userId";

            
            cmdInsert.Parameters.AddWithValue("@LoginName", objUser.LoginName);
            cmdInsert.Parameters.AddWithValue("@Password", objUser.Password);
            cmdInsert.Parameters.AddWithValue("@FullName", objUser.FullName);
            cmdInsert.Parameters.AddWithValue("@Email", objUser.Email);
            cmdInsert.Parameters.AddWithValue("@CityId", objUser.CityId);
            cmdInsert.Parameters.AddWithValue("@Phone", objUser.Phone);
            cmdInsert.Parameters.AddWithValue("@userId", UserId);


            cmdInsert.ExecuteNonQuery();
            //da.InsertCommand = cmdInsert;

            return RedirectToAction("Index");
        }
            catch(Exception ex)
            {
                
                return View();
            }
}

        // GET: User/Delete/5
        public ActionResult Delete(int UserId)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where  userId = @userId";
            cmd.Parameters.AddWithValue("@userId", UserId);

            SqlDataReader dr = cmd.ExecuteReader();


            User objUser = new User();


            while (dr.Read())
            {


                objUser.userId = Convert.ToInt32(dr["userId"]);
                objUser.LoginName = (string)(dr["LoginName"]);
                objUser.Password = (string)(dr["Password"]);
                objUser.FullName = (string)(dr["FullName"]);
                objUser.Email = (string)(dr["Email"]);
                objUser.CityId = Convert.ToInt32(dr["CityId"]);
                objUser.Phone = (string)(dr["Phone"]);

            }


            dr.Close();
            cn.Close();
            return View(objUser);
           
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int UserId, FormCollection collection)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from users where  userId = @userId";
                cmd.Parameters.AddWithValue("@userId", UserId);

                SqlDataReader dr = cmd.ExecuteReader();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Login()
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
        public ActionResult Login(Login lgn)
        {

            if (lgn.LoginName==null || lgn.Password==null)
            {

                return View();

            }
            else
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp;Integrated Security=True;Pooling=False";

                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from users where  LoginName=@LoginName and Password=@Password";
                cmd.Parameters.AddWithValue("@LoginName", lgn.LoginName);
                cmd.Parameters.AddWithValue("@Password", lgn.Password);

                SqlDataReader dr = cmd.ExecuteReader();
                HttpCookie objCookie = new HttpCookie("Usercookie");
                if (lgn.RememberMe == true)
                {
                    objCookie["username"] = lgn.LoginName;
                    objCookie["pwd"] = lgn.Password;
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
                    return RedirectToAction("Home");
                }
                else
                {
                    return View();
                }
            }
                
        }

        public ActionResult Home()
        {
            return View();
        }


    }
}
