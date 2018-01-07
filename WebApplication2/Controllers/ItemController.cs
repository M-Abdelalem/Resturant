using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ItemController : Controller
    {
        public ActionResult Index(string sershed_text)
            {

            Item_manager sub_fk = new Item_manager();
            ViewBag.fk = sub_fk.getfk();




                Concreate.Irepostory<Item> item = new Item_manager();

                var All_Item = item.GetAll();
                if (!string.IsNullOrWhiteSpace(sershed_text))
                {
                    var serched = All_Item.Where(m => m.item_name.Contains(sershed_text));
                    return View(serched);

                }
                return View(All_Item);
            }
            public ActionResult Add()
            {
                Item_manager sub_fk = new Item_manager();
                ViewBag.fk = sub_fk.getfk();
                return View();

            }
            [HttpPost]
            public ActionResult Add(Item items)
            {
                Item_manager sub_fk = new Item_manager();
                ViewBag.fk = sub_fk.getfk();
                if (ModelState.IsValid)
                {
                    Concreate.Irepostory<Item> item = new Item_manager();
                    item.Add(items);
                }
                return View("Add");

            }
            public ActionResult update(int Id)
            {
                Item_manager sub_fk = new Item_manager();
                ViewBag.fk = sub_fk.getfk();
                Concreate.Irepostory<Item> item = new Item_manager();
                var x = item.Get_Item(Id);
                return View(x);




            }

            [HttpPost]

            public ActionResult update(Item items)
            {
                Item_manager sub_fk = new Item_manager();
                ViewBag.fk = sub_fk.getfk();
                if (ModelState.IsValid)
                {
                    Concreate.Irepostory<Item> item = new Item_manager();
                    item.Update_Item(items);
                }
                return View();


            }
            public ActionResult delete(Item items)
            {
                Concreate.Irepostory<Item> item = new Item_manager();
                item.delete_ITeem(items);
                return RedirectToAction("index");

            }



        }
 
}
