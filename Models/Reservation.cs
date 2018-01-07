using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime time { set; get; }
        [Required]
        public int table_number { get; set; }
        [ForeignKey("Fk_user")]
        public User users { get; set; }
        public int Fk_user { get; set; }

    }

}
