using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
   public class Data_Context:DbContext
    {


        public Data_Context()
            : base("DefaultConnection")
        { }
        public DbSet<User> users { get; set; }
        public DbSet<Category> Categories { get; set; }
      
        public DbSet<Contact_Us_Information> Contact_Us_Informations { get; set; }
        
        public DbSet<Item> items { get; set; }

     
        public DbSet<Order> orders { set; get; }
        public DbSet<Order_Components> Order_Components { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sub_Category> Sub_Categories { get; set; }
    
    }
}
