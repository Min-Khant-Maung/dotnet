using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace SFMS.Models
{
    [Table("FinePolicy")]
    public class FinePolicy:BaseEntity
    {
        public string Name { get; set; }
        public string Rule { get; set; }
        public int FineAmount { get; set; }
        public int FineAfterMinutes { get; set; }
    }
}
