using System.ComponentModel;

namespace StaffManager
{
    internal class Filter
    {
        public delegate BindingList<Employee> FilterConditionHandler(in BindingList<Employee> employees);

        private readonly string _name;
        private readonly FilterConditionHandler _filterCondition;

        public Filter(string name, FilterConditionHandler filterCondition)
        {
            _name = name;
            _filterCondition = filterCondition;
        }

        public string Name => _name; 

        public BindingList<Employee> ApplyFilter(BindingList<Employee> employeeList)
        {
            return _filterCondition(employeeList);
        }
    }
}
