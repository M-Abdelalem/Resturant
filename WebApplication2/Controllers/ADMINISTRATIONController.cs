using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Repository;
using Concreate;
namespace WebApplication2.Controllers
{
    public class ADMINISTRATIONController : Controller
    {

        public ActionResult Index()
        {

            return View();
        
        }



        // GET: ADMINISTRATION
        [HttpPost]
        public ActionResult Index(User user )
        {

            ADMINSTRATIONmanager a = new ADMINSTRATIONmanager();
            int result=a.login(user);

            if (result == 1 )
            {

                HttpCookie local = new HttpCookie("servername");
                local.Values.Add("username", user.Name);
                local.Values.Add("userpassword", user.password);
                Response.Cookies.Add(local);
                local.Expires = DateTime.Now.AddSeconds(500);

                return RedirectToAction("index", "Home");
            }
            else if (result == 2)
            {
                return View("error");
            }
            else 
                return View();
        }

        public ActionResult Home()

        {
             HttpCookie local = Request.Cookies["servername"];
             if (local != null)
             {
                 string cookiename = local.Values["username"];
                 string cookiepass = local.Values["password"];
                 return View();

             }
             else {

                 return View("error");
             }


           

        }
        public ActionResult error ()

        {

            return View();

        }

    }
}