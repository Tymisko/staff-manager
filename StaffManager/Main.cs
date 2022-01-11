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
        }        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.ShowDialog();
            addEditEmployee.FormClosed += AddEditEmployee_FormClosed;
        }

        private void AddEditEmployee_FormClosed(object? sender, FormClosedEventArgs e)
        {
            LoadStaff();
        }

        private void LoadStaff() => dgvDiary.DataSource = _fileHelper.DeserializeFromJson();
    }
}