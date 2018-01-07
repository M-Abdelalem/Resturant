using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concreate
{
  public  interface Irepostory<t> where t:class
    {
       IQueryable<t> GetAll();
       t Get_Item(int Id);
       void Update_Item(t Item);
       void delete_ITeem(t Item);
       void Add(t Item);

    }
}
