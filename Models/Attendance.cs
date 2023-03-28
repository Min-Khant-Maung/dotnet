using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace SFMS.Models
{
    [Table("Attendance")]
    public class Attendance:BaseEntity
    {
        public DateTime AttendanceDate { get; set; }
        public string Intime { get; set; }
        public string OutTime { get; set; }
        public bool IsLeave { get; set; }
        public bool IsLate { get; set; }
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]

        public Student Student { get; set; }
    }
}
