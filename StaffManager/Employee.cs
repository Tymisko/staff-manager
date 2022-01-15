﻿using System;

namespace StaffManager
{ 
    public class Employee : Person
    {
        public Employee
            (
                int id, 
                string firstName, 
                string lastName, 
                DateTime birthDate, 
                DateTime employmentDate, 
                decimal salary,
                string comments = ""
            ) : base(firstName, lastName, birthDate)
        {
            Id = id;
            EmploymentDate = employmentDate;
            Salary = Math.Round(salary, 2);
            Comments = comments;
        }

        public int Id { get; }
        public DateTime EmploymentDate { get; }
        public DateTime? DismissalDate {
            get
            {
                return _dismissalDate;
            }
            set
            {
                if (_dismissalDate is not null)
                    throw new Exception("Employee already dissmissed.");
                _dismissalDate = value;
            }
        }
        public string Comments { get; }
        public decimal Salary { get; }

        private DateTime? _dismissalDate;
    }
}
