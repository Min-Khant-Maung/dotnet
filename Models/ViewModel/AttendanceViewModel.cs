using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFMS.Models.ViewModel
{
    public class AttendanceViewModel
    {
        public string Id { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string Intime { get; set; }
        public string OutTime { get; set; }
        public string IsLeave { get; set; }
        public string IsLate { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }

    }
}
