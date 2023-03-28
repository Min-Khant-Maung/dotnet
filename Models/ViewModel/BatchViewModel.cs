using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFMS.Models.ViewModel
{
    public class BatchViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
