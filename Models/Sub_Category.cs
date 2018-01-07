using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sub_Category
    {
        public Sub_Category()
        {

            items = new HashSet<Item>();
        
        }


        [Key]
        public int Id { get; set; }
        [Required]
        public string sub_category_name { get; set; }
        [ForeignKey("Fk_category")]
        public Category category { set; get; }
      public   int Fk_category { get; set; }

        public ICollection<Item> items { get; set; }
    }
}
