using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SFMS.Models.ViewModel
{
    public class FinePolicyViewModel
    {
        public string Name { get; set; }
        public string Rule { get; set; }
        public int FineAmount { get; set; }
        public int FineAfterMinutes { get; set; }
    }
}
