using System;

namespace ObjectOrientedProgramming
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public abstract decimal CalculateSalary();

        public virtual string GetDetails()
        {
            return $"{Name}, born on {BirthDate.ToShortDateString()}";
        }
    }
}