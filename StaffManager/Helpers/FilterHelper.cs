using System.ComponentModel;
using System.Linq;

namespace StaffManager.Helpers
{
    internal static class FilterHelper
    {
        public static BindingList<Filter> GetFilters()
        {
            return new BindingList<Filter>
            {
                new Filter("All", AllFilter),
                new Filter("Employeed", EmployeedFilter),
                new Filter("Dismissed", DismissedFilter),
            };
        }

        private static BindingList<Employee> AllFilter(in BindingList<Employee> employees) => employees;

        private static BindingList<Employee> EmployeedFilter(in BindingList<Employee> employees)
        {
            var filteredEmployeesList = employees.Where(e => e.DismissalDate is null).ToList();
            return new BindingList<Employee>(filteredEmployeesList);
        }

        private static BindingList<Employee> DismissedFilter(in BindingList<Employee> employees)
        {
            var filteredEmployeesList = employees.Where(e => e.DismissalDate is not null).ToList();
            return new BindingList<Employee>(filteredEmployeesList);
        }
    }
}
