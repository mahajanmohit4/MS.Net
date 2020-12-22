using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using ModelViewCtnr.Models;

namespace ModelViewCtnr.Controllers
{
    public class FriendController : Controller
    {
        // GET: Friend
        public ActionResult Index()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Friend";

            SqlDataReader dr = cmd.ExecuteReader();
            List<Friend> objFList = new List<Friend>();
            while (dr.Read())
            {
                objFList.Add(new Friend { FriendId = (int)dr["FriendId"], FriendName = (string)dr["FriendName"], Place = dr["Place"].ToString() });
            }

            return View(objFList);
            dr.Close();
            cn.Close();
            return View();
        }

        // GET: Friend/Details/5
        public ActionResult Details(int id=0)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Friend";

            SqlDataReader dr = cmd.ExecuteReader();

            Friend objFrd = new Friend();
            while (dr.Read())
            {
                if (id == (int)dr["FriendId"])
                {
                    objFrd.FriendId = (int)dr["FriendId"];
                    objFrd.FriendName = (string)dr["FriendName"];
                    objFrd.Place = (string)dr["Place"];
                   
                }
            }
            return View(objFrd);
            dr.Close();
            cn.Close();
        }

        // GET: Friend/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Friend/Create
        [HttpPost]
        public ActionResult Create(Friend collection)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";

                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Friend Values(@FriendId,@FriendName,@Place)";

                cmd.Parameters.AddWithValue("@FriendId", collection.FriendId);
                cmd.Parameters.AddWithValue("@FriendName", collection.FriendName);
                cmd.Parameters.AddWithValue("@Place", collection.Place);
               

                cmd.ExecuteNonQuery();

                cn.Close();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Friend/Edit/5
        public ActionResult Edit(int id=0)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Friend";

            SqlDataReader dr = cmd.ExecuteReader();

            Friend objFrd = new Friend();
            while (dr.Read())
            {
                if (id == (int)dr["FriendId"])
                {
                    objFrd.FriendId = (int)dr["FriendId"];
                    objFrd.FriendName = (string)dr["FriendName"];
                    objFrd.Place = (string)dr["Place"];

                }
            }
            return View(objFrd);
           
        }

        // POST: Friend/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Friend frd)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";

                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                
                cmd.CommandText = "UPDATE Friend SET FriendName=@FriendName, Place=@Place Where FriendId=@FriendId";
               
                cmd.Parameters.AddWithValue("@FriendId", id);
                cmd.Parameters.AddWithValue("@FriendName", frd.FriendName );
                cmd.Parameters.AddWithValue("@Place", frd.Place);

                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Friend/Delete/5
        public ActionResult Delete(int id=0)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Friend";

            SqlDataReader dr = cmd.ExecuteReader();

            Friend objFrd = new Friend();
            while (dr.Read())
            {
                if (id == (int)dr["FriendId"])
                {
                    objFrd.FriendId = (int)dr["FriendId"];
                    objFrd.FriendName = (string)dr["FriendName"];
                    objFrd.Place = (string)dr["Place"];

                }
            }
            return View(objFrd);
        }

        // POST: Friend/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Friend frnd)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";

                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete FROM Friend where FriendId=@FriendId";
                cmd.Parameters.AddWithValue("@FriendId", id);

                cmd.ExecuteNonQuery();


                return RedirectToAction("Index");

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
        public ActionResult login(login objlogin)

        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=emp_Rec;Integrated Security=True";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Select * from friend where FriendName=@FriendName and Place=@Place";

            cmd.Parameters.AddWithValue("@FriendName", objlogin.FriendName);
            cmd.Parameters.AddWithValue("@Place", objlogin.Place);
            SqlDataReader dr = cmd.ExecuteReader();

            HttpCookie objCookie = new HttpCookie("Usercookie");
           
            if (dr.Read())
            {
                Session["username"] = objlogin.FriendName.ToString();
                Session["fullname"] = objlogin.FriendName.ToString();
                cn.Close();
                return RedirectToAction("Home");
            }

            else
            {
                ViewBag.Msg1 = "Enter the valid Username and Password";
                // return login();
                return View();
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

        [HttpPost]
        public ActionResult logout()
        {
            return RedirectToAction("login", "Friend");
        }

    }
}
