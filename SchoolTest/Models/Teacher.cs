using System.Collections.Generic;

namespace SchoolTest.Models
{
    public class Teacher
    {
        public ICollection<Course> Courses { get; set; }
        public Subject Subject { get; set; }
    }
}