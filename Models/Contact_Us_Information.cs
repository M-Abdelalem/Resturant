using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contact_Us_Information
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int telephone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string facebook { get; set; }
        [DataType(DataType.EmailAddress)]
        public string twitter { get; set; }
    }
}
