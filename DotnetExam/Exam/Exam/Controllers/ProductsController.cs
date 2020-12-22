using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using Exam.Models;

namespace Exam.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=exam;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetProduct";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = cn;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "GetCategory";


            SqlDataReader dr = cmd.ExecuteReader();
            List<Product1> objPro = new List<Product1>();
            Product1 pr = new Product1();
            while (dr.Read())
            {
               
                pr.ProductId = Convert.ToInt32(dr["ProductId"]);
                pr.ProductName = (string)dr["ProductName"];
                pr.Rate = (decimal)dr["Rate"];
                pr.Description = (string)dr["Description"];
                pr.CategoryId = (int)dr["CategoryId"];
                objPro.Add(pr);
            }

            SqlDataReader dr2 = cmd1.ExecuteReader();
            List<SelectListItem> objCat = new List<SelectListItem>();
            while (dr2.Read())
            {
           new SelectListItem { Text = dr2["CategoryNmae"].ToString(), Value = dr2["CategoryId"].ToString() };
               
            }

            pr.Categories1 = objCat;
            dr2.Close();
            dr.Close();

            return View(objPro);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int ProductId=0)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=exam;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetProduct";

            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            SqlDataReader dr = cmd.ExecuteReader();
            Product1 pr = new Product1();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = cn;
            cmd1.CommandType = CommandType.StoredProcedure;
           

            while (dr.Read())
            {

                pr.ProductId = Convert.ToInt32(dr["ProductId"]);
                pr.ProductName = (string)dr["ProductName"];
                pr.Rate = (decimal)dr["Rate"];
                pr.Description = (string)dr["Description"];
                pr.CategoryId = (int)dr["CategoryId"];

                cmd1.CommandText = "GetCategoryName";
                SqlDataReader dr2 = cmd1.ExecuteReader();

                string CategoryName = dr2["CategoryName"].ToString();

                dr2.Close();
            }

            dr.Close();



            return View(pr);
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product1 objPr)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=exam;Integrated Security=True";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateProduct";

                cmd.Parameters.AddWithValue("@ProductId", objPr.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", objPr.ProductName);
                cmd.Parameters.AddWithValue("@Rate", objPr.Rate);
                cmd.Parameters.AddWithValue("@Description", objPr.Description);
                cmd.Parameters.AddWithValue("@CategoryId", objPr.CategoryId);

                cmd.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
          
        }
        [ChildActionOnly]
        public ActionResult Myname(int id)
        {
            ViewBag.Myname = "Mohit";
            ViewBag.Center = "Juhu";
            ViewBag.RollNo = "20240520057";
            

            return View();
        }

        // POST: Products/Delete/5
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
