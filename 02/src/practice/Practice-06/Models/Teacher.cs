using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_06.Models
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronym { get; set; }
        public Subject[] Subjects { get; set; }
        public Group[] Group { get; set; }
        public DateTime OnboardDate { get; set; }
        public int Salary { get; set; }


    }
}
