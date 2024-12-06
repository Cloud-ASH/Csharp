using System;

namespace ObjectOrientedProgramming
{
    public class Instructor : Person
    {
        public DateTime JoinDate { get; private set; }
        public decimal BaseSalary { get; private set; } = 50000;

        public Instructor(string name, DateTime birthDate, DateTime joinDate) : base(name, birthDate)
        {
            JoinDate = joinDate;
        }

        public override decimal CalculateSalary()
        {
            int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
            return BaseSalary + (yearsOfExperience * 1000);
        }
    }
}