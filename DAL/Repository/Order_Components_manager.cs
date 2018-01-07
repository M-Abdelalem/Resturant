using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Order_Components_manager : Repository<Order_Components>
    {
        public Order_Components_manager() { }
        public List<Get_name_fk> getfkItem()
        {


            List<Get_name_fk> n = new List<Get_name_fk>();

            var m = from x in context.items
                    select new { Id = x.Id, Name = x.item_name };


            foreach (var item in m)
            {
                Get_name_fk v = new Get_name_fk();
                v.Id = item.Id;
                v.Name = item.Name;
                n.Add(v);

            }




            return (n);

        }
        public List<int> getfkorder()
        {


            List<int> n = new List<int>();

            var m = from x in context.orders
                    select new { Id = x.Id };
            List<int> y=new List<int>();
            foreach(var z in m)
            {

                y.Add(z.Id);
            
            
            
            }
            



            return (y);

        }

       





    }
}
