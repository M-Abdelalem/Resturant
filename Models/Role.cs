using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Role
    {
        [Key]
      public  int Id { get; set; }
        [Required]
        public string Role_Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
