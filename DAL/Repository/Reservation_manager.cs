using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Reservation_manager : Repository<Reservation>
    {
        public Reservation_manager() { }

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
