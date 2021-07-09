using System;
using System.Collections.Generic;

namespace Practice_06
{
    public class People
    {
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public class Student : People
        {
            public DateTime EnrollmentData { get; set; }
            public DateTime GradueteData { get; set; }
            public Degree Degree { get; set; }
            public Group Group { get; set; }
            public Class Classes { get; set; }
        }
        public class Teacher : People
        {
            public Subject Subject { get; set; }
            public Group[] Groups { get; set; }
            public DateTime OnboardData { get; set; }
            public int Salary { get; set; }
        }

    }
    public class Degree
    {

    }
    public class Group
    {
        public string Name { get; set; }
        public People.Student[] students { get; set; }
        public Subject[] Subjects { get; set; }
        public Class[] Classes { get; set; }
    }
    public class Class
    {
        public Subject Subject { get; set; }
        public Group[] Group { get; set; }
        public People.Teacher Teacher { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Classroom { get; set; }

    }
    public class Subject
    {
        public string Name { get; set; }
        public string[] Books { get; set; }
        public int Hours { get; set; }
    }
    public class ClassRoom
    {
        public string Name { get; set; }
        public int MaxStudents { get; set; }
    }
    public class Schedule
    {
        public List<Class> Classes { get; set; }
        public void AddClass(Class @class)
        {

        }
        public List<Class> GetClassesByRoom(ClassRoom classRoom)
        {
            return default;
        }
        public List<Class> GetClassesByStartData(DateTime startData)
        {
            return default;
        }
        public List<Class> GetClassesByGroup(Group group)
        {
            return default;
        }
        public List<Class> GetClassesByTeacher(People.Teacher teacher)         
        {
            return default;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
