using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Practice_06.Models.Enums;

namespace Practice_06.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronym { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public Degree Degree { get; set; }
        public Group Group { get; set; }
        public Class[] Classes { get; set; }

    }
}
