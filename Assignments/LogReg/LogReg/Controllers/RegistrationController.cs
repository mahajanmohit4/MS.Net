using LogReg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace LogReg.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InsertData()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True;Pooling=False";

            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO UserMaster Values(@LoginName,@Password,@FullName,@EmailId,@CityId,@Phone)";

            
            cmd.Parameters.AddWithValue("@LoginName", "MOhit");
            cmd.Parameters.AddWithValue("@Password", "sadf");
            cmd.Parameters.AddWithValue("@FullName", "mohit mahajan");
            cmd.Parameters.AddWithValue("@EmailId", "mohit@123");
            cmd.Parameters.AddWithValue("@CityId", 1);
            cmd.Parameters.AddWithValue("@Phone", "123456773");
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
        // GET: Registration/Details/5
        public ActionResult Details(int id)
        {

            
           
            return View();
        }

        // GET: Registration/Create
        public ActionResult Register()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Emp_Rec;Integrated Security=True;Pooling=False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CITY";
            SqlDataReader dr = cmd.ExecuteReader();
            Reg obj = new Reg();
           
            List<SelectListItem> objDepts = new List<SelectListItem>();
            
            while (dr.Read())
            {
               
                objDepts.Add(new SelectListItem { Text = dr["CityName"].ToString(), Value = dr["CityId"].ToString() }) ;
            }
           
            obj.Citys = objDepts;

            dr.Close();




            return View(obj);
        }

        // POST: Registration/Create
        [HttpPost]
        public ActionResult Register(Reg collection)
        {
            
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Emp_Rec;Integrated Security=True;Pooling=False";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO UserMaster Values(@LoginName,@Password,@FullName,@EmailId,@CityId,@Phone)";

                

                List<SelectListItem> obj = new List<SelectListItem>();
                obj.Add(new SelectListItem { Text = "aa", Value = "1" });

                cmd.Parameters.AddWithValue("@LoginName", collection.LoginName);
                cmd.Parameters.AddWithValue("@Password", collection.Password);
                cmd.Parameters.AddWithValue("@FullName", collection.FullName);
                cmd.Parameters.AddWithValue("@EmailId", collection.EmailId);
                cmd.Parameters.AddWithValue("@CityId", (int)collection.CityId);
                cmd.Parameters.AddWithValue("@Phone", collection.Phone);

                cmd.ExecuteNonQuery();
              
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }


        public ActionResult signIn()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Emp_Rec;Integrated Security=True;Pooling=False";
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CITY";
            SqlDataReader dr = cmd.ExecuteReader();
            Reg obj = new Reg();

            List<SelectListItem> objDepts = new List<SelectListItem>();

            while (dr.Read())
            {
                SelectListItem objItem = new SelectListItem();
                objItem.Text = dr["CityName"].ToString();
                objItem.Value = dr["CityId"].ToString();
                objDepts.Add(objItem);
                obj.Citys = objDepts;

               // objDepts.Add(new SelectListItem { Text = dr["CityName"].ToString(), Value = dr["CityId"].ToString() });
            }

           // obj.Citys = objDepts;
            return View(obj);
        }

        [HttpPost]
        public ActionResult signIn(Reg collection)
        {

            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Emp_Rec;Integrated Security=True;Pooling=False";
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO UserMaster Values(@LoginName,@Password,@FullName,@EmailId,@CityId,@Phone)";

                cmd.Parameters.AddWithValue("@LoginName", collection.LoginName);
                cmd.Parameters.AddWithValue("@Password", collection.Password);
                cmd.Parameters.AddWithValue("@FullName", collection.FullName);
                cmd.Parameters.AddWithValue("@EmailId", collection.EmailId);
                cmd.Parameters.AddWithValue("@CityId", collection.CityId);
                cmd.Parameters.AddWithValue("@Phone", collection.Phone);
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Registration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registration/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registration/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
