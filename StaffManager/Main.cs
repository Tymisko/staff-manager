using System;
using System.Collections.Generic;
using System.Linq;
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
        private void LoadStaff() => dgvDiary.DataSource = _fileHelper.DeserializeFromJson();

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
            try
            {
                var addEditEmployee = new AddEditEmployee(GetSelectedEmployeeId());
                addEditEmployee.FormClosed += AddEditEmployee_FormClosed;
                addEditEmployee.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void BtnDismiss_Click(object sender, EventArgs e)
        {
            try
            {
                var employees = _fileHelper.DeserializeFromJson();
                employees.First(e => e.Id == GetSelectedEmployeeId()).DismissalDate = DateTime.Now.Date;
                _fileHelper.SerializeToJson(employees);
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEditEmployee_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadStaff();
        }
        private int GetSelectedEmployeeId()
        {
            if (dgvDiary.SelectedRows.Count != 0)
                return Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[nameof(Employee.Id)].Value);
            throw new Exception("No employee were selected.");
        }
    }
}