using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
        public List<Course> Courses { get; }

        public Student()
        {
            // Set default values for properties 
            FirstName = string.Empty;
            LastName = string.Empty;
            StudentID = 0;
            Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public override string ToString()
        {
            //return a string with the values of the properties
            return $"{FirstName} {LastName} ({StudentID}) is taking {Courses.Count()} classes.";
        }
    }
}
