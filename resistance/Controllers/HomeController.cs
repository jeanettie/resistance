using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace resistance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult jeanettiesblog()
        {
            return View();
        }

        public ActionResult addedit()
        {
            ViewBag.Message = "addedit";

            return View();
        }

        public ActionResult edit()
        {
            ViewBag.Message = "edit";

            return View();
        }

        
    }
}