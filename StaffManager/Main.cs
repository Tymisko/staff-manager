using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StaffManager
{
    public partial class Main : Form
    {
        private readonly FileHelper<List<Employee>> _fileHelper;
        public Main()
        {
            _fileHelper = new FileHelper<List<Employee>>(Program.StaffDiaryPath);
            InitializeComponent();
            LoadStaff();
            SetColumnsHeaders();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.FormClosed += AddEditEmployee_FormClosed;
            addEditEmployee.ShowDialog();
        }

        private void AddEditEmployee_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadStaff();
        }

        private void LoadStaff() => dgvDiary.DataSource = _fileHelper.DeserializeFromJson();
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select employee to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedEmployeeId = Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[nameof(Employee.Id)].Value);
            var addEditEmployee = new AddEditEmployee(selectedEmployeeId);
            addEditEmployee.FormClosed += AddEditEmployee_FormClosed;
            addEditEmployee.ShowDialog();
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

    }
}