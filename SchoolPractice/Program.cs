using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student parker = new Student("Parker", 123, 40, 4.0);

            Console.WriteLine(parker + "\n***********");

            parker.AddGrade(2, 0);

            Console.WriteLine(parker + "\n***********");

            Console.WriteLine(parker.GetGradeLevel(parker.NumberOfCredits) + "\n**********");

            Teacher smith = new Teacher("John","Smith","Calculus",4);

            Course calc = new Course();
            calc.Instructor = smith;
            calc.Topic = "Calculus";
            //calc.enrolledStudents.Add(parker);

            //Console.WriteLine(calc);
        }
    }
}
