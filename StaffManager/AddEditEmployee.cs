using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StaffManager
{
    public partial class AddEditEmployee : Form
    {
        private readonly bool _editingEmployee;

        private readonly FileHelper<List<Employee>> _fileHelper;
        public AddEditEmployee(int selectedEmployeeId = 0)
        {
            InitializeComponent();
            _fileHelper = new FileHelper<List<Employee>>(Program.StaffDiaryPath);

            _editingEmployee = selectedEmployeeId != 0;

            if (_editingEmployee)
                EditingEmployee(selectedEmployeeId);
            else
                AddingNewEmployee();            
        }

        private void AddingNewEmployee()
        {
            this.Text = "Adding New Employee";
            tbId.Text = SetNewEmployeeId().ToString();
        }
        private void EditingEmployee(int employeeId)
        {
            this.Text = "Editing Employee Data";
            LoadEmployeeData(employeeId);
        }

        private void LoadEmployeeData(int id)
        {
            var employees = _fileHelper.DeserializeFromJson();
            var selectedEmployee = employees.FirstOrDefault(e => e.Id == id) as Employee;

            tbId.Text = selectedEmployee!.Id.ToString();
            tbFirstName.Text = selectedEmployee.FirstName;
            tbLastName.Text = selectedEmployee.LastName;
            dtpBirthDate.Value = selectedEmployee.BirthDate.Date;
            dtpEmploymentDate.Value = selectedEmployee.EmploymentDate.Date;
            nupSalary.Value = selectedEmployee.Salary;
            rtbComments.Text = selectedEmployee.Comments;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                CheckIfBoxesAreFilled();

                var employees = _fileHelper.DeserializeFromJson();

                if (_editingEmployee)
                    employees.RemoveAll(e => e.Id == Convert.ToInt32(tbId.Text));

                employees.Add(GetEmployeeData());

                _fileHelper.SerializeToJson(employees);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
        }

        private void CheckIfBoxesAreFilled()
        {
            if (String.IsNullOrEmpty(tbId.Text)) throw new Exception("Id wasn't assigned.");
            if (String.IsNullOrEmpty(tbFirstName.Text)) throw new Exception("First name wasn't assigned");
            if (String.IsNullOrEmpty(tbLastName.Text)) throw new Exception("Last name wasn't assigned.");
            if (dtpBirthDate.Value >= DateTime.Now.Date) throw new Exception("Invalid birth date!");
            if (dtpEmploymentDate.Value > DateTime.Now.Date) throw new Exception("Invalid employment date!");
            //if (nupSalary.Value <= 0) throw new Exception("Salary cannot be negative"); // unnecessary, NumericUpDown minimum set to 0
        }

        private int SetNewEmployeeId()
        {
            var employees = _fileHelper.DeserializeFromJson();
            var lastAddedEmployee = employees.OrderByDescending(e => e.Id).FirstOrDefault();
            
            if (lastAddedEmployee == null)
                return 1;

            return lastAddedEmployee.Id + 1;
        }

        private Employee GetEmployeeData()
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
