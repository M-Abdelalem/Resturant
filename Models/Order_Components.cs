using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order_Components
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Fk_item")]
        public Item items { get; set; }
        public int Fk_item { get; set; }
        [ForeignKey("Fk_order")]
        public Order orders { set; get; }
        public int Fk_order { set; get; }
    }
}
