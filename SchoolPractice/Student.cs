using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            double qualityScore = courseCredits * grade;
            double totalQualityScore = (Gpa * NumberOfCredits) + qualityScore;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            if (credits < 30)
            {
                return "Freshman";
            }
            else if (credits >= 30 && credits < 60)
            {
                return "Sophomore";
            }
            else if (credits >=60 && credits < 90)
            {
                return "Junior";
            }
            else if (credits >= 90)
            {
                return "Senior";
            }
            return "grade level TBD";
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return ($"Name: {Name}\nStudent ID: {StudentId}\nNumber of credits: {NumberOfCredits}\nGPA: {Gpa}");
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
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

            Student s = toBeCompared as Student;
            return s.StudentId == StudentId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
