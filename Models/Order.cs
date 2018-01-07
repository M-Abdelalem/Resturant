using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public bool situation { get; set; }
        [Required]
        public int coste { get; set; }

        public DateTime time { get; set; }
        [ForeignKey("Fk_users")]
        public User users { get; set; }
        public int Fk_users { get; set; }


    }
}
