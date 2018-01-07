using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index( )
        {


            Order_manager ordersfk = new Order_manager();
            ViewBag.fk = ordersfk.getfk();




            Concreate.Irepostory<Order> order = new Order_manager();

            var ALL_Orders = order.GetAll();

            return View(ALL_Orders);
        }
        public ActionResult Add()
        {
            Order_manager ordersfk = new Order_manager();
            ViewBag.fk = ordersfk.getfk();

            return View();

        }
        [HttpPost]
        public ActionResult Add(Order item)
        {
            Order_manager ordersfk = new Order_manager();
            ViewBag.fk = ordersfk.getfk();


            if (ModelState.IsValid)
            {
                Concreate.Irepostory<Order> order = new Order_manager();
                order.Add(item);
            }
            return View("Add");

        }
        public ActionResult update(int Id)
        {
            Order_manager ordersfk = new Order_manager();
            ViewBag.fk = ordersfk.getfk();

            Concreate.Irepostory<Order> order = new Order_manager();
            var x = order.Get_Item(Id);
            return View(x);




        }

        [HttpPost]

        public ActionResult update(Order orders)
        {
            Order_manager ordersfk = new Order_manager();
            ViewBag.fk = ordersfk.getfk();


            if (ModelState.IsValid)
            {
                Concreate.Irepostory<Order> order = new Order_manager();
                order.Update_Item(orders);
            }
            return View();


        }
        public ActionResult delete(Order orders)
        {
            Concreate.Irepostory<Order> order = new Order_manager();
            order.delete_ITeem(orders);
            return RedirectToAction("index");

        }


    }
}