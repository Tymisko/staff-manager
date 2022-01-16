using System;

namespace StaffManager
{ 
    public class Employee : Person
    {
        private const int _minimumEmployeeAge = 16;
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
            EmploymentDate = (IsOldEnoughToBeEmployed()) ? employmentDate : throw new Exception("This person is too young to be employed."); 
            Salary = Math.Round(salary, 2);
            Comments = comments;
            _age = CalculateEmployeeAge();
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
                    throw new Exception($"The employee with id {Id} has already been fired");
                _dismissalDate = value;
            }
        }

        private readonly int _age;
        public int Age
        {
            get
            {
                return _age;
            }
        }

        public string Comments { get; }
        public decimal Salary { get; }

        private DateTime? _dismissalDate;


        private bool IsOldEnoughToBeEmployed() => _age >= _minimumEmployeeAge;

        private int CalculateEmployeeAge() => DateTime.Now.Year - BirthDate.Year - (DateTime.Now.DayOfYear > BirthDate.DayOfYear ? 0 : 1);
    }
}
