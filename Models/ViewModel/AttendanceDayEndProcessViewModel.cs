using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFMS.Models.ViewModel
{
    public class AttendanceDayEndProcessViewModel
    {
        public string Id { get; set; }
        public DateTime FromDayEndDate { get; set; }
        public DateTime ToDayEndDate { get; set; }
        public string StudentId { get; set; }
        public string BatchNameId { get; set; }
        public IList<BatchViewModel> batches { get; set; }
        public IList<StudentViewModel> students { get; set; }

    }
}
