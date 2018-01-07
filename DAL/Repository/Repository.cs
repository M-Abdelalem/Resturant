using Concreate;
using DAL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository<t> : Irepostory<t> where t:class
    {
        public Data_Context context;
        public DbSet<t> set;
        public Repository()
            : this(new Data_Context())
         { }
        public Repository(Data_Context _context)
        {
            context = _context;
            set = context.Set<t>();
        
        }


        virtual public IQueryable<t> GetAll()
        {
           
         return(set);
        
        
        }
         virtual public t Get_Item(int Id) 
        { 
         return(set.Find(Id));
        }
        virtual public void Update_Item(t Item)
        {
            context.Entry<t>(Item).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void delete_ITeem(t Item) 
        {

            context.Entry<t>(Item).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
      virtual  public void Add(t Item)
        {
            set.Add(Item);
            context.SaveChanges();
        
        
        }



    }
}
