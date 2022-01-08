﻿namespace StaffManager
{ 
    internal class Employee : Person
    {
        public Employee
            (
                int id, 
                string firstName, 
                string lastName, 
                DateTime birthDate, 
                DateTime employmentDate, 
                decimal salary
            ) : base(firstName, lastName, birthDate)
        {
            Id = id;
            EmploymentDate = employmentDate;
            Salary = Math.Round(salary, 2);
        }

        public int Id { get; }
        public DateTime EmploymentDate { get; }
        public DateTime? DismissalDate { get; }
        public string? Comments { get; }
        public decimal Salary { get; }
    }
}