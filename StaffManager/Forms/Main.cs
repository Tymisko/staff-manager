using StaffManager.Helpers;
using StaffManager.Properties;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace StaffManager
{
    public partial class Main : Form
    {
        public static BindingList<Employee> Employees { get; set; } = System.IO.File.Exists(Program.StaffDiaryPath) ?
            Program.FileHelper.DeserializeFromJson() : new BindingList<Employee>();

        public static bool IsMaximize
        {
            get
            {
                return Settings.Default.IsMaximize;
            }
            set
            {
                Settings.Default.IsMaximize = value;
            }
        }

        public Main()
        {
            InitializeComponent();
            InitFiltersCombobox();

            LoadStaff();
            InitColumnsHeaders();
            SetProperColumnsOrder();

            LoadUserSettings();

            HideColumns();
        }

        private void HideColumns()
        {
            dgvDiary.Columns[nameof(Employee.Age)].Visible = false;
        }

        private void LoadUserSettings()
        {
            if(IsMaximize) 
                WindowState = FormWindowState.Maximized;
        }

        private void CmbEmploymentFilters_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Filter selectedFilter = cmbEmploymentFilters.SelectedItem as Filter;
            dgvDiary.DataSource = selectedFilter!.ApplyFilter(Employees);
        }

        private void InitFiltersCombobox()
        {
            cmbEmploymentFilters.DataSource = FilterHelper.GetFilters();
            cmbEmploymentFilters.ValueMember = "Name";
            cmbEmploymentFilters.DisplayMember = "Name";
            cmbEmploymentFilters.SelectedIndexChanged += CmbEmploymentFilters_SelectedIndexChanged;
        }

        private void LoadStaff()
        {
            if (dgvDiary.DataSource == Employees)
            {
                dgvDiary.Refresh();
            }
            else
                dgvDiary.DataSource = Employees;
        }

        private void SetProperColumnsOrder()
        {
            dgvDiary.Columns[nameof(Employee.Id)].DisplayIndex = 0;
            dgvDiary.Columns[nameof(Employee.FirstName)].DisplayIndex = 1;
            dgvDiary.Columns[nameof(Employee.LastName)].DisplayIndex = 2;
            dgvDiary.Columns[nameof(Employee.BirthDate)].DisplayIndex = 3;
            dgvDiary.Columns[nameof(Employee.Email)].DisplayIndex = 4;
            dgvDiary.Columns[nameof(Employee.PhoneNumber)].DisplayIndex = 5;
            dgvDiary.Columns[nameof(Employee.Salary)].DisplayIndex = 6;
            dgvDiary.Columns[nameof(Employee.Comments)].DisplayIndex = 7;
            dgvDiary.Columns[nameof(Employee.EmploymentDate)].DisplayIndex = 8;
            dgvDiary.Columns[nameof(Employee.DismissalDate)].DisplayIndex = 9;
        }

        private void InitColumnsHeaders()
        {
            dgvDiary.Columns[nameof(Employee.Id)].HeaderText = "Id";
            dgvDiary.Columns[nameof(Employee.FirstName)].HeaderText = "First Name";
            dgvDiary.Columns[nameof(Employee.LastName)].HeaderText = "Last Name";
            dgvDiary.Columns[nameof(Employee.BirthDate)].HeaderText = "Birth date";
            dgvDiary.Columns[nameof(Employee.Email)].HeaderText = "Email";
            dgvDiary.Columns[nameof(Employee.PhoneNumber)].HeaderText = "Phone number";
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
            {
                MessageBox.Show("You have to select an employee to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var addEditEmployee = new AddEditEmployee(selectedEmployeeId);
            addEditEmployee.FormClosed += AddEditEmployee_FormClosed;
            addEditEmployee.ShowDialog();
        }
        private void BtnDismiss_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedEmployeeId(out int selectedEmployeeId))
            {
                MessageBox.Show("You have to select an employee to dismiss", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsMaximize = (WindowState == FormWindowState.Maximized);
            Settings.Default.Save();
        }
    }
}