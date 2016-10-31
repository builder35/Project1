using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        //MEthod for the View for The home page
        public ActionResult Index()
        {
            return View();
        }
        //Method for the view for the about page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //Method for the Contact page view
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}