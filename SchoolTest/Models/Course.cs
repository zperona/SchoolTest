﻿using System.Collections.Generic;

namespace SchoolTest.Models
{
    public class Course : BaseId
    {
        public ICollection<Student> Students { get ; set ; }

        public ICollection<Subject> Subjects { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

    }
}
