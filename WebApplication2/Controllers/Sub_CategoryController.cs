using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class Sub_CategoryController : Controller
    {
        // GET: Sub_Category
      
            // GET: User
            public ActionResult Index(string sershed_text)
            {
                Sub_Category_manager category = new Sub_Category_manager();
                ViewBag.fk = category.getfk();


                Concreate.Irepostory<Sub_Category> sub_category = new Sub_Category_manager();

                var All_sub_category = sub_category.GetAll();
                if (!string.IsNullOrWhiteSpace(sershed_text))
                {
                    var serched = All_sub_category.Where(m => m.sub_category_name.Contains(sershed_text));
                    return View(serched);

                }
                return View(All_sub_category);
            }
            public ActionResult Add()
            {
                Sub_Category_manager category = new Sub_Category_manager();
                ViewBag.fk = category.getfk();



                return View();

            }
            [HttpPost]
            public ActionResult Add(Sub_Category item)
            {
                Sub_Category_manager category = new Sub_Category_manager();
                ViewBag.fk = category.getfk();


                if (ModelState.IsValid)
                {
                    Concreate.Irepostory<Sub_Category> sub_category = new Sub_Category_manager();
                    sub_category.Add(item);
                }
                return View("Add");

            }
            public ActionResult update(int Id)
            {
                Sub_Category_manager category = new Sub_Category_manager();
                ViewBag.fk = category.getfk();

                Concreate.Irepostory<Sub_Category> sub_category = new Sub_Category_manager();
                var x = sub_category.Get_Item(Id);
                return View(x);




            }

            [HttpPost]

            public ActionResult update(Sub_Category sub_categories)
            {
                Sub_Category_manager category = new Sub_Category_manager();
                ViewBag.fk = category.getfk();

                if (ModelState.IsValid)
                {
                    Concreate.Irepostory<Sub_Category> sub_category = new Sub_Category_manager();
                    sub_category.Update_Item(sub_categories);
                }
                return View();


            }
            public ActionResult delete(Sub_Category sub_categories)
            {
                Concreate.Irepostory<Sub_Category> sub_category = new Sub_Category_manager();
                sub_category.delete_ITeem(sub_categories);
                return RedirectToAction("index");

            }



        }
    }
