using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NIIT.BookStore.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            object s = "Helloword";
            //ViewBag.Hello = s;  //动态类型
            //ViewData["Hello"] = s;
           
            return View(s);
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