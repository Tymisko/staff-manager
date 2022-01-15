using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManager
{
    public abstract class Person
    {
        protected Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; }
    }
}
