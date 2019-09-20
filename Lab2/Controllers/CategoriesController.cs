using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(String parameter)
        {
            ViewBag.Message = "You Selected Category is: " + parameter;
            return View();
        }

        public ActionResult Food()
        {
           
            return View();
        }

        public ActionResult Sports()
        {
            
            return View();
        }

        public ActionResult Tech()
        {
            
            return View();
        }
    }
}