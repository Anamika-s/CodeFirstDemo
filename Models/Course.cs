using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFiratApproach.Models
{
    class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        
        // Main Class
        public List<Batch> Batches { get; set; }
    }
}
