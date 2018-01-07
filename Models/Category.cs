using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {
        public Category()
       {

           Sub_Categorys = new HashSet<Sub_Category>();
       }


        [Key]
        public int Id { get; set; }
        [Required]
        public string Category_name { get; set; }

        ICollection<Sub_Category> Sub_Categorys { set; get; }
    }
}
