using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.
        public override string ToString()
        {
            return ($"Topic: {Topic}\nInstructor: {Instructor}\nEnrolled students:\n{enrolledStudents}");
        }


        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
        public override bool Equals(object toBeCompared)
        {
            if (toBeCompared == null)
            {
                return false;
            }
            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Course c = toBeCompared as Course;
            return c.Topic == Topic;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
