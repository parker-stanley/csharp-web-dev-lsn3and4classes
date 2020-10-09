using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {

        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public Dictionary<string, string> Syllabus { get; set; }

        public Course()
        {

        }
    }
}
