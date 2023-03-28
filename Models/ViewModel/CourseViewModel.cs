using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFMS.Models.ViewModel
{
    public class CourseViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime OpeningDate { get; set; }
        public int DurationInHour { get; set; }
        public int Fees { get; set; }
    }
}
