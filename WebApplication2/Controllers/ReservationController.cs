using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Reservation
        public ActionResult Index()
        {

            Reservation_manager reservatons = new Reservation_manager();
            ViewBag.fk = reservatons.getfk();



            Concreate.Irepostory<Reservation> reserve = new Reservation_manager();

            var ALL_resrve = reserve.GetAll();

            return View(ALL_resrve);
        }
        public ActionResult Add()
        {
            Reservation_manager reservatons = new Reservation_manager();
            ViewBag.fk = reservatons.getfk();

            return View();

        }
        [HttpPost]
        public ActionResult Add(Reservation item)
        {
            Reservation_manager reservatons = new Reservation_manager();
            ViewBag.fk = reservatons.getfk();


            if (ModelState.IsValid)
            {
                Concreate.Irepostory<Reservation> reserve = new Reservation_manager();
                reserve.Add(item);

            }
            return View("Add");

        }
        public ActionResult update(int Id)
        {
            Reservation_manager reservatons = new Reservation_manager();
            ViewBag.fk = reservatons.getfk();

            Concreate.Irepostory<Reservation> reserve = new Reservation_manager();
            var x = reserve.Get_Item(Id);
            return View(x);




        }

        [HttpPost]

        public ActionResult update(Reservation reserves)
        {

            Reservation_manager reservatons = new Reservation_manager();
            ViewBag.fk = reservatons.getfk();
            if (ModelState.IsValid)
            {
                Concreate.Irepostory<Reservation> reserve = new Reservation_manager();
                reserve.Update_Item(reserves);
            }
            return View();


        }
        public ActionResult delete(Reservation reserves)
        {
            Concreate.Irepostory<Reservation> reserve = new Reservation_manager();
            reserve.delete_ITeem(reserves);
            return RedirectToAction("index");

        }

    }
}