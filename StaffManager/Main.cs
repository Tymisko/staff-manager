using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StaffManager
{
    public partial class Main : Form
    {
        private readonly FileHelper<List<Employee>> _fileHelper;
        public Main()
        {
            InitializeComponent();
            _fileHelper = new FileHelper<List<Employee>>(Program.StaffDiaryPath)
        }        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.ShowDialog();
        }
    }
}