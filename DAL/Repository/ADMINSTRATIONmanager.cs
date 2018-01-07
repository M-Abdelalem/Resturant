using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ADMINSTRATIONmanager : Repository<User>
    {
        int n = 2;
        int y = 2;
        public ADMINSTRATIONmanager() { }
        public int login(User user)
        {
           
            List<User> x =( from item in context.users
                    select item).ToList();


            foreach (var item in x)
            {
                List<string> m = new List<string>();
                m.Add(item.Name);
            
            
            
            }





            foreach (var item in x.ToList())
            {
               string z= item.Name.ToString();
                if (z == user.Name)
                {
                    if (item.password == user.password)
                    {
                        
                        return (1);
                       

                    }
                    else
                    {
                        return (2);
                       
                    }



}
                else
                {
                    continue;
                    
                }
            }

            return (3);
        }

    }
}
    
  

    //    if (y!= 2)
    //    {
            
    //            var  z = from item in set
              
                
    //                select item.password;


    //            foreach (var item in z)
    //            {
    //                if (item == user.password)
    //                {
    //                    n = 1;

    //                    break;

    //                }

    //            }


    //            if (n != 2)
    //        {
    //            return (1);


    //        }
            
    //            else
    //           { 
    //                return (2);
      
    //            }

    //    }
    //    else 
    //    {
    //        return (3);
        
    //    }





      

    //}


    //}

