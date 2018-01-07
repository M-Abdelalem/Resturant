using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models
{
  public  class User
    {
      public User() 
      {
          orders = new HashSet<Order>();
          reservations = new HashSet<Reservation>();

      
      }


      [Key]
      public int Id { get; set; }
      [Required]
      public string Name { get; set; }
      [DataType(DataType.Password)]
      public string password { get; set; }
      public string address { get; set; }
      [DataType(DataType.PhoneNumber)]
      public int telephone { get; set; }
      [ForeignKey("FK_Role")]
      public Role Role { get; set; }
      [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
      public int FK_Role { get; set; }

      public IEnumerable<Order> orders { get; set; }
      public IEnumerable<Reservation> reservations { get; set; }

    }
}
