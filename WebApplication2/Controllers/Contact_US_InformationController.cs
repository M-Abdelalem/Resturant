using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class Contact_US_InformationController : Controller
    {
        // GET: Contact_US_Information
        public ActionResult Index()
        {


            Concreate.Irepostory<Contact_Us_Information> Contact = new Contact_Us_Information_manager();

            var ALL_Contact = Contact.GetAll();

            return View(ALL_Contact);
        }
        public ActionResult Add()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Add(Contact_Us_Information item)
        {
            if (ModelState.IsValid)
            {
                Concreate.Irepostory<Contact_Us_Information> Contact = new Contact_Us_Information_manager();
                Contact.Add(item);
            }
            return View("Add");

        }
        public ActionResult update(int Id)
        {

            Concreate.Irepostory<Contact_Us_Information> Contact = new Contact_Us_Information_manager();
            var x = Contact.Get_Item(Id);
            return View(x);




        }

        [HttpPost]

        public ActionResult update(Contact_Us_Information contacts)
        {
            if (ModelState.IsValid)
            {
                Concreate.Irepostory<Contact_Us_Information> Contact = new Contact_Us_Information_manager();
                Contact.Update_Item(contacts);
            }
            return View();


        }
        public ActionResult delete(Contact_Us_Information contacts)
        {
            Concreate.Irepostory<Contact_Us_Information> Contact = new Contact_Us_Information_manager();
            Contact.delete_ITeem(contacts);
            return RedirectToAction("index");

        }


    }
}