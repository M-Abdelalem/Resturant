using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role


        public ActionResult Index(string sershed_text)
        {

            Concreate.Irepostory<Role> s = new Role_manager();

            var all_data=s.GetAll();
            if(!string.IsNullOrWhiteSpace(sershed_text)){
            var filterd = from data_item in all_data
                          where (data_item.Role_Name.Contains(sershed_text))
                          select data_item;
            return View(filterd);
            }
            return View(all_data);
        }


        public ActionResult update(int Id)
        {
            Concreate.Irepostory<Role> s = new Role_manager();

           var x=s.Get_Item(Id);
           return View(x);
        }


        [HttpPost]
        public ActionResult update(Role Roles)
        {
            Concreate.Irepostory<Role> s = new Role_manager();
            if(ModelState.IsValid)
            {
            s.Update_Item(Roles);
            }
            return View();
        }
        public ActionResult delete(Role Roles)
        {
            Concreate.Irepostory<Role> s = new Role_manager();
            s.delete_ITeem(Roles);
            return  RedirectToAction("index");
        }
        public ActionResult add()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult add(Role Roles)
        {
            Concreate.Irepostory<Role> s = new Role_manager();
            s.Add(Roles);
            return View();
        }

    }
}