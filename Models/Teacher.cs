using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace SFMS.Models
{
    [Table("Teacher")]
    public class Teacher:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
