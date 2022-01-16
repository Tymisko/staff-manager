using System.Collections.Generic;

namespace StaffManager.Helpers
{
    internal static class FilterHelper
    {
        public static List<Filter> GetFilters()
        {
            return new List<Filter>
            {
                new Filter("All", AllFilter),
                new Filter("Employeed", EmployeedFilter),
                new Filter("Dismissed", DismissedFilter),
            };
        }

        private static List<Employee> AllFilter(in List<Employee> employees) => employees;

        private static List<Employee> EmployeedFilter(in List<Employee> employees)
        {
            List<Employee> filteredEmployeesList = new(employees);
            filteredEmployeesList.RemoveAll(e => e.DismissalDate is not null);
            return filteredEmployeesList;
        }

        private static List<Employee> DismissedFilter(in List<Employee> employees)
        {
            List<Employee> filteredEmployeesList = new(employees);
            filteredEmployeesList.RemoveAll(e => e.DismissalDate is null);
            return filteredEmployeesList;
        }
    }
}
