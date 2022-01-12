using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StaffManager
{
    public partial class AddEditEmployee : Form
    {
        private readonly FileHelper<List<Employee>> _fileHelper;
        public AddEditEmployee()
        {
            InitializeComponent();
            _fileHelper = new FileHelper<List<Employee>>(Program.StaffDiaryPath);

            tbId.Text = GetEmployeeId().ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromJson();
            
            employees.Add(GetNewEmployeeData());

            _fileHelper.SerializeToJson(employees);
            this.Close();
        }

        private int GetEmployeeId()
        {
            var employees = _fileHelper.DeserializeFromJson();
            var lastAddedEmployee = employees.OrderByDescending(e => e.Id).FirstOrDefault();
            
            if (lastAddedEmployee == null)
                return 1;

            return lastAddedEmployee.Id + 1;
        }

        private Employee GetNewEmployeeData()
        {
            
            return new Employee(
                int.Parse(tbId.Text),
                tbFirstName.Text,
                tbLastName.Text,
                dtpBirthDate.Value.Date,
                dtpEmploymentDate.Value.Date,
                nupSalary.Value,
                rtbComments.Text
                );
        }
    }
}
