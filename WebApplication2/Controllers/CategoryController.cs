using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Index(string sershed_text)
        { 
           

            Concreate.Irepostory<Category>category=new Category_manager();

            var ALL_User = category.GetAll();
       if (!string.IsNullOrWhiteSpace(sershed_text))
            {
                var serched = ALL_User.Where(m => m.Category_name.Contains(sershed_text));
       return View(serched);
       
            }
         return View(ALL_User);
        }
        public ActionResult Add()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Add(Category item)
        {
            if(ModelState.IsValid)
            {
                Concreate.Irepostory<Category> category = new Category_manager();
                category.Add(item);
            }
            return View("Add"); 
        
        }
        public ActionResult update(int Id)
        {

            Concreate.Irepostory<Category> category = new Category_manager();
            var x = category.Get_Item(Id);
                return View(x);
            
          
           

        }
   
        [HttpPost]

        public ActionResult update(Category categories)
        {
            if (ModelState.IsValid)
            {
                Concreate.Irepostory<Category> category = new Category_manager();
                category.Update_Item(categories);
            }
            return View(); 
        
        
        }
        public ActionResult delete(Category categories)
        {
            Concreate.Irepostory<Category> category = new Category_manager();
            category.delete_ITeem(categories);
            return RedirectToAction("index");
        
        }


    }
}

