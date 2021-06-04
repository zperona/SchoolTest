using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolTest.Models
{
    public class Student : BaseId
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        public DateTime DoB { get; set; }

        public Course Courses { get; set; }

        public bool Active { get; set; }
    }
}
