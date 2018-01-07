using Concreate;
using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
      


        // GET: User
        public ActionResult Index(string sershed_text)
        {

            User_manager users = new User_manager();
            ViewBag.fk = users.getfk();





            Concreate.Irepostory<User>user=new User_manager();
           var ALL_User= user.GetAll();
           if (!string.IsNullOrWhiteSpace(sershed_text))
            {
                var serched = ALL_User.Where(m => m.Name.Contains(sershed_text));
                return View(serched);
       
            }
         return View(ALL_User);
        }
        public ActionResult Add()
        {
            User_manager users = new User_manager();
            ViewBag.fk = users.getfk();

            return View();

        }
        [HttpPost]
        public ActionResult Add(User item)
        {
            User_manager users = new User_manager();
            ViewBag.fk = users.getfk();


            if(ModelState.IsValid)
            {
            Concreate.Irepostory<User> user = new User_manager();
            user.Add(item);
            }
            return View("Add"); 
        
        }
        public ActionResult update(int Id)
        {
            User_manager users = new User_manager();
            ViewBag.fk = users.getfk();

                Concreate.Irepostory<User> user = new User_manager();
                var x = user.Get_Item(Id);
                return View(x);
            
          
           

        }
   
        [HttpPost]

        public ActionResult update(User users)
        {
            User_manager role_fk = new User_manager();
            ViewBag.fk = role_fk.getfk();
            if (ModelState.IsValid)
            {
                Concreate.Irepostory<User> user = new User_manager();
                user.Update_Item(users);
            }
            return View(); 
        
        
        }
        public ActionResult delete(User users)
        {
            Concreate.Irepostory<User> user = new User_manager();
            user.delete_ITeem(users);
            return RedirectToAction("index");
        
        }



    }
}