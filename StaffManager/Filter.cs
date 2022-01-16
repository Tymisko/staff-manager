using System.Collections.Generic;

namespace StaffManager
{
    internal class Filter
    {
        public delegate List<Employee> FilterConditionHandler(in List<Employee> employees);

        private readonly string _name;
        private readonly FilterConditionHandler _filterCondition;

        public Filter(string name, FilterConditionHandler filterCondition)
        {
            _name = name;
            _filterCondition = filterCondition;
        }

        public string Name => _name; 

        public List<Employee> ApplyFilter(List<Employee> employeeList)
        {
            return _filterCondition(employeeList);
        }
    }
}
