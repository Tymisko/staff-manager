using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StaffManager
{
    public partial class Main : Form
    {
        public static List<Employee> Employees { get; set; } = System.IO.File.Exists(Program.StaffDiaryPath) ?
            Program.FileHelper.DeserializeFromJson() : new List<Employee>();

        public Main()
        {
            InitializeComponent();
            LoadStaff();
            SetColumnsHeaders();
        }
        private void LoadStaff()
        {
            if (dgvDiary.DataSource == Employees)
                dgvDiary.Refresh();
            else
                dgvDiary.DataSource = Employees;
        }

        private void SetColumnsHeaders()
        {
            dgvDiary.Columns[nameof(Employee.Id)].HeaderText = "Id";
            dgvDiary.Columns[nameof(Employee.FirstName)].HeaderText = "First Name";
            dgvDiary.Columns[nameof(Employee.LastName)].HeaderText = "Last Name";
            dgvDiary.Columns[nameof(Employee.BirthDate)].HeaderText = "Birth date";
            dgvDiary.Columns[nameof(Employee.Salary)].HeaderText = "Salary";
            dgvDiary.Columns[nameof(Employee.Comments)].HeaderText = "Comments";
            dgvDiary.Columns[nameof(Employee.EmploymentDate)].HeaderText = "Employment Date";
            dgvDiary.Columns[nameof(Employee.DismissalDate)].HeaderText = "Dismissal Date";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.FormClosed += AddEditEmployee_FormClosed;
            addEditEmployee.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedEmployeeId(out int selectedEmployeeId))
                MessageBox.Show("You have to select an employee to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var addEditEmployee = new AddEditEmployee(selectedEmployeeId);
            addEditEmployee.FormClosed += AddEditEmployee_FormClosed;
            addEditEmployee.ShowDialog();
        }
        private void BtnDismiss_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedEmployeeId(out int selectedEmployeeId))
                MessageBox.Show("You have to select an employee to dismiss", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Employee selectedEmployee = Employees.First(e => e.Id == selectedEmployeeId);

            if (selectedEmployee.DismissalDate is not null)
            {
                MessageBox.Show($"The employee with id {selectedEmployee.Id} has already been fired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedEmployee.DismissalDate = DateTime.Now.Date;

            Program.FileHelper.SerializeToJson(Employees);
            LoadStaff();
        }

        private void AddEditEmployee_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadStaff();
        }

        private bool TryGetSelectedEmployeeId(out int employeId)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                employeId = 0;
                return false;
            }
            employeId = Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[nameof(Employee.Id)].Value);
            return true;
        }
    }
}