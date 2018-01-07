using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Item
    {
        public Item()
        {

            Order_Components = new HashSet<Order_Components>();
        
        }


        [Key]
        public int Id { get; set; }
        [Required]
        public string item_name { get; set; }
        [Required]
        public int price { get; set; }
        [ForeignKey("Fk_sub_category")]
        public Sub_Category sub_categorys { get; set; }
        public int Fk_sub_category { get; set; }


        IEnumerable<Order_Components> Order_Components { get; set; }

    }
}
