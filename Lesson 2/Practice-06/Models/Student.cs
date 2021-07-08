using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_06.Models
{
    class Student
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Patronym { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EntrollmentDate { get; set; }
        


        Student(string Name, string Surname, string SecondName)
        {
            this.FirstName = Name;
            this.Patronym = SecondName;
            this.LastName = Surname;
        }
    }
}
