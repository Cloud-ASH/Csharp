using System.Collections.Generic;

namespace ObjectOrientedProgramming
{
    public class Student : Person
    {
        private Dictionary<string, char> CourseGrades = new Dictionary<string, char>();

        public Student(string name, DateTime birthDate) : base(name, birthDate) { }

        public void AddCourseGrade(string course, char grade)
        {
            CourseGrades[course] = grade;
        }

        public double CalculateGPA()
        {
            int totalPoints = 0;
            foreach (var grade in CourseGrades.Values)
            {
                totalPoints += grade switch
                {
                    'A' => 4,
                    'B' => 3,
                    'C' => 2,
                    'D' => 1,
                    _ => 0
                };
            }
            return CourseGrades.Count > 0 ? (double)totalPoints / CourseGrades.Count : 0;
        }

        public override decimal CalculateSalary()
        {
            return 0; // Students typically don't have a salary in this context
        }
    }
}