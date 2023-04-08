using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SFMS.Models
{
    [Table("FineTransition")]
    public class FineTransition:BaseEntity
    {
        public DateTime FinedDate { get; set; }
        public int FineAmount { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string FinePolicyId { get; set; }
        [ForeignKey("FinePolicyId")]
        public virtual FinePolicy FinePolicy { get; set; }
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}
