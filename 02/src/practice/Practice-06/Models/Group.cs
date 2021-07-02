using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_06.Models
{
    public class Group
    {
        public string Name { get; set; }
        public Student[] Students { get; set; }
        public Subject[] Subjects { get; set; }
        public Class[] Schedule { get; set; }
    }
}
