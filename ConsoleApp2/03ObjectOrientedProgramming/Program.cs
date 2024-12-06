using System;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Reverse an array using methods");
            Console.WriteLine("2. Fibonacci sequence using recursion");
            Console.WriteLine("3. Object-Oriented Programming Examples (Person, Student, Instructor)");
            Console.WriteLine("4. Ball and Color Example");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ArrayAndMethodExercises.RunArrayAndMethods();
                    break;
                case 2:
                    ArrayAndMethodExercises.RunFibonacciExample();
                    break;
                case 3:
                    RunOOPExamples();
                    break;
                case 4:
                    RunBallAndColorExample();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void RunOOPExamples()
        {
            // Implement and test Person, Student, and Instructor classes
            Person instructor = new Instructor("John Doe", new DateTime(1980, 5, 20), new DateTime(2010, 9, 1));
            Console.WriteLine($"Instructor: {instructor.GetDetails()}");
            Console.WriteLine($"Age: {instructor.CalculateAge()}");
            Console.WriteLine($"Salary: {instructor.CalculateSalary()}");

            Student student = new Student("Jane Smith", new DateTime(2000, 7, 15));
            student.AddCourseGrade("Math", 'A');
            student.AddCourseGrade("History", 'B');
            Console.WriteLine($"Student: {student.GetDetails()}");
            Console.WriteLine($"GPA: {student.CalculateGPA()}");
        }

        private static void RunBallAndColorExample()
        {
            Ball ball1 = new Ball(new Color(255, 0, 0), 10);
            ball1.Throw();
            ball1.Throw();
            ball1.Pop();
            ball1.Throw();

            Console.WriteLine($"Ball 1 has been thrown {ball1.GetThrowCount()} times.");

            Ball ball2 = new Ball(new Color(0, 255, 0, 200), 15);
            ball2.Throw();
            Console.WriteLine($"Ball 2 has been thrown {ball2.GetThrowCount()} times.");
        }
    }
}
