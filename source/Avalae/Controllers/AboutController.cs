using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Avalae.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your app description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
