using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StaffManager
{
    // TODO: Implement employee id assigment. Generate when form is opening. Static field in Employee class
    public partial class AddEditEmployee : Form
    {
        private readonly FileHelper<List<Employee>> _fileHelper;
        public AddEditEmployee()
        {
            InitializeComponent();
            _fileHelper = new FileHelper<List<Employee>>(Program.StaffDiaryPath);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromJson();
            employees.Add(GetNewEmployeeData());
            _fileHelper.SerializeToJson(employees);
            this.Close();
        }

        private Employee GetNewEmployeeData()
        {
            return new Employee(
                tbId.Text,
                tbFirstName.Text,
                tbLastName.Text,
                dtpBirthDate.Value.Date,
                dtpEmploymentDate.Value.Date,
                nupSalary.Value
                );
        }
    }
}
