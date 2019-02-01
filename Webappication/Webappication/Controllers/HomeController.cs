using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webappication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //----Changes
            //-----Code is edited from GitHub
            return View();
        }

        public ActionResult About()
        {
        
        //-----Code Changes 2nd from GitHub
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
