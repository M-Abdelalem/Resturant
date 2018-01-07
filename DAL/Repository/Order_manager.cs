using DAL.Data;
using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Order_manager : Repository<Order>
    {

      public  Order_manager() { }
        
        
        
        int all_cost;



       override  public void Add(Order item)
        {



            var q = from x in context.items
                    from m in context.Order_Components
                    from z in set
                    from w in context.orders
                    where (x.Id == m.Fk_item)
                    where (m.Fk_order == w.Id)
                    select x.price;
          
            foreach (var r in q)
            {
                all_cost = all_cost+r;
            
            
            }
            item.coste = all_cost;

            set.Add(item);
            context.SaveChanges();
        
        


    
    }
       override public void Update_Item(Order item)
       {



           var q = from x in context.items
                   from m in context.Order_Components
                   from z in set
                   from w in context.orders
                   where (x.Id == m.Fk_item)
                   where (m.Fk_order == w.Id)
                   select x.price;

           foreach (var r in q)
           {
               all_cost = all_cost + r;


           }
           item.coste = all_cost;

           context.Entry<Order>(item).State = System.Data.Entity.EntityState.Modified;
           context.SaveChanges();


       }


       public List<Get_name_fk> getfk()
       {

           List<Get_name_fk> n = new List<Get_name_fk>();

           var m = from x in context.users
                   select new { Id = x.Id, Name = x.Name };


           foreach (var item in m)
           {
               Get_name_fk v = new Get_name_fk();
               v.Id = item.Id;
               v.Name = item.Name;
               n.Add(v);

           }




           return (n);

       }





    } 
}

