using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_06.Models
{
    public class Class
    {
        public Subject Subject { get; set; }
        public Group Group { get; set; }
        public Teacher Teacher { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Classroom Classroom { get; set; }
    }
}
