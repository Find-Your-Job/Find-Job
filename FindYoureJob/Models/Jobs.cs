using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYoureJob.Models
{
    public class Jobs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public Departments Departments { get; set; }

        public List<Jobs> Job { get; set; }
    }
}
