using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gatewayfinal.Models;
using System.Web.Security;

namespace gatewayfinal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AccountUser user)
        {
            if (ModelState.IsValid)
            {
                dataEntities2 entities2 = new dataEntities2();
                if (entities2.AccountUser.Any(x=>x.Username == user.Username))
                {
                    ViewBag.message = "username is already exists.";
                    return View("Index");
                }
                entities2.AccountUser.Add(user);
                entities2.SaveChanges();

                return RedirectToAction("Message");
            }
            return View();
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountUser Login)
        {
            using(dataEntities2 entities2 = new dataEntities2())
            {
               if(entities2.AccountUser.Any(x => x.Username == Login.Username && x.Password == Login.Password))
                {
                    Session["username"] = Login.Username.ToString();
                    FormsAuthentication.SetAuthCookie(Login.Username, false);
                    return RedirectToAction("Details");
                }
            }
            ViewBag.alert = ("Please Enter Valid Username & Password.");
            return View("Login");
        }

        [Authorize]
        public ActionResult Details()
        {
            dataEntities2 entities2 = new dataEntities2();
            return View(entities2.AccountUser.ToList());
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}