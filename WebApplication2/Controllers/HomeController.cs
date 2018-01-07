using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            HttpCookie local = Request.Cookies["servername"];
            if (local != null)
            {
                string cookiename = local.Values["username"];
                string cookiepass = local.Values["password"];
                return View();

            }
            else
            {

                return View("errors");
            }
        }
             public ActionResult errors()
        {
                 return View();}
        }

       
    }
