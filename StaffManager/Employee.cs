using System;
using System.Globalization;
using System.Linq;
using System.Net.Mail;

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
                string email,
                string phoneNumber,
                DateTime employmentDate,
                decimal salary,
                string comments = ""
            ) : base(firstName, lastName, birthDate)
        {
            Id = id;
            _age = CalculateEmployeeAge();
            EmploymentDate = (IsOldEnoughToBeEmployed()) ? employmentDate : throw new Exception("This person is too young to be employed.");
            Salary = Math.Round(salary, 2);
            Comments = comments;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return GetValidFormattedPhoneNumber(_phoneNumber);
            }
            private set
            {
                if (IsValidPhoneNumber(value))
                    _phoneNumber = value;
                else
                    throw new Exception("Invalid phone number");
            }
        }
        private static bool IsValidPhoneNumber(string phoneNum)
        {
            phoneNum = phoneNum.Trim();
            if (phoneNum.Length != 9) return false;
            return phoneNum.All(d => char.IsDigit(d));
        }

        private string GetValidFormattedPhoneNumber(string phoneNumber)
        {
            var phoneNumberDigitsList = phoneNumber.ToList();
            for (var i = 3; i < _phoneNumber.Length; i += 4)
                phoneNumberDigitsList.Insert(i, '-');
            return string.Join("", phoneNumberDigitsList);
        }

        private MailAddress _email;
        public string Email
        {
            get
            {
                return _email.Address;
            }
            private set
            {
                if (!IsValidEmail(value))
                    throw new Exception("Invalid email address");
                try
                {                    
                    _email = new MailAddress(value);
                }
                catch (FormatException)
                {
                    throw new Exception("Invalid email address");
                }
            }
        }

        private static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (string.IsNullOrEmpty(trimmedEmail)) return false;
            if (!trimmedEmail.Contains('.') || trimmedEmail.EndsWith(".")) return false;

            return email == trimmedEmail;
        }

        public int Id { get; }
        public DateTime EmploymentDate { get; }
        public DateTime? DismissalDate
        {
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

        private const int _minimumEmployeeAge = 16;
        private bool IsOldEnoughToBeEmployed() => _age >= _minimumEmployeeAge;

        private int CalculateEmployeeAge() => DateTime.Now.Year - BirthDate.Year - (DateTime.Now.DayOfYear > BirthDate.DayOfYear ? 0 : 1);
    }
}
