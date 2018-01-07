using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class order_componentController : Controller
    {
        // GET: order_component
        public ActionResult Index()
        {


            Order_Components_manager ordrcomponent = new Order_Components_manager();
            ViewBag.fk = ordrcomponent.getfkItem();
            ViewBag.fkorder = ordrcomponent.getfkorder();



            Concreate.Irepostory<Order_Components> order_components = new Order_Components_manager();

            var ALL_order_components = order_components.GetAll();
           
            return View(ALL_order_components);
        }
        public ActionResult Add()
        {
            Order_Components_manager ordrcomponent = new Order_Components_manager();
            ViewBag.fk = ordrcomponent.getfkItem();
            ViewBag.fkorder = ordrcomponent.getfkorder();

            return View();

        }
        [HttpPost]
        public ActionResult Add(Order_Components item)
        {

            Order_Components_manager ordrcomponent = new Order_Components_manager();
            ViewBag.fk = ordrcomponent.getfkItem();
            ViewBag.fkorder = ordrcomponent.getfkorder();


            if (ModelState.IsValid)
            {
                Concreate.Irepostory<Order_Components> order_component = new Order_Components_manager();
                order_component.Add(item);
            }
            return View("Add");

        }
        public ActionResult update(int Id)
        {
            Order_Components_manager ordrcomponent = new Order_Components_manager();
            ViewBag.fk = ordrcomponent.getfkItem();
            ViewBag.fkorder = ordrcomponent.getfkorder();

            Concreate.Irepostory<Order_Components> order_component = new Order_Components_manager();
            var x = order_component.Get_Item(Id);
            return View(x);




        }

        [HttpPost]

        public ActionResult update(Order_Components order_components)
        {
            Order_Components_manager ordrcomponent = new Order_Components_manager();
            ViewBag.fk = ordrcomponent.getfkItem();
            ViewBag.fkorder = ordrcomponent.getfkorder();


            if (ModelState.IsValid)
            {
                Concreate.Irepostory<Order_Components> order_component = new Order_Components_manager();
                order_component.Update_Item(order_components);
            }
            return View();


        }
        public ActionResult delete(Order_Components order_components)
        {
            Concreate.Irepostory<Order_Components> order_component = new Order_Components_manager();
            order_component.delete_ITeem(order_components);
            return RedirectToAction("index");

        }


    }
}