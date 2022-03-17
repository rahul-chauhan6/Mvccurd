using MVCCURD.dbcontent;
using MVCCURD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCURD.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult Employee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Employee(empmodel obj)
        {
            EmployeedbEntities1 dbobj = new EmployeedbEntities1();
            empdetail tb=new empdetail();
            tb.id= obj.id;
            tb.Name = obj.Name;
            tb.Phone = obj.Phone;
            tb.salary = obj.salary;
            dbobj.empdetails.Add(tb);
            dbobj.SaveChanges();
          

            return RedirectToAction("Index","Home");
        }

        public ActionResult Delete(int id)
        {
            EmployeedbEntities1 dbobj1 = new EmployeedbEntities1();
            var deleteItem = dbobj1.empdetails.Where(m => m.id == id).First();
            dbobj1.empdetails.Remove(deleteItem);
            dbobj1.SaveChanges();
            return RedirectToAction("Index","Home");
        }

    }
}