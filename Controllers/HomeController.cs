using MVCCURD.dbcontent;
using MVCCURD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCURD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EmployeedbEntities1 obj = new EmployeedbEntities1();
            List<empmodel> li = new List<empmodel>();
            var res=obj.empdetails.ToList();
            foreach(var item in res)
            {
                li.Add(new empmodel
                    {
                    id = item.id,
                    Name=item.Name,
                    Phone=item.Phone,
                    salary=item.salary
                });
            }
          

            return View(li);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

namespace MVCCURD
{
    class Model
    {
    }
}