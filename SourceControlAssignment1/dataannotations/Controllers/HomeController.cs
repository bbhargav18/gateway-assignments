using System;
using System.Collections.Generic;
using System.Linq;
using dataannotations.Models;
using System.Web;
using System.Web.Mvc;

namespace dataannotations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Message");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Message()
        {
            return View();
        }
    }
}