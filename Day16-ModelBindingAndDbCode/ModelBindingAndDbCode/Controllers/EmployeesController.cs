using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBindingAndDbCode.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id=0)
        {
            Employee objEmp = new Employee();
            objEmp.EmpNo = 123;
            objEmp.Name = "Mohit";
            objEmp.Basic = 1234;
            objEmp.DeptNo = 11;
            return View(objEmp);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
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

        // GET: Employees/Edit/5
        public ActionResult Edit(int id=0)
        {
            Employee objEmp = new Employee();
            objEmp.EmpNo = 123;
            objEmp.Name = "Vik";
            objEmp.Basic = 12345;
            objEmp.DeptNo = 10;
            return View(objEmp);
            
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, Employee objEmp)
        {
            try
            {
                // TODO: Add update logic here

                //int EmpNo =Convert.ToInt32( collection["EmpNo"]);
                //string Name = collection["Name"];
                string Name = objEmp.Name;

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
            return View();
        }

        // POST: Employees/Delete/5
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
