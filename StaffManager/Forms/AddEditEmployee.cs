﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StaffManager
{
    public partial class AddEditEmployee : Form
    {
        private readonly bool _editingEmployee;

        public AddEditEmployee(int selectedEmployeeId = 0)
        {
            InitializeComponent();

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
            Employee selectedEmployee = Main.Employees.First(e => e.Id == id);

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
            if (!AreBoxesFilled(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }                

            if (_editingEmployee)
                Main.Employees.Remove(Main.Employees.First(e => e.Id == Convert.ToInt32(tbId.Text)));

            Main.Employees.Add(GetEmployeeData());

            Program.FileHelper.SerializeToJson(Main.Employees);
            this.Close();         
        }

        private bool AreBoxesFilled(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(tbId.Text)) errorMessage = "Id wasn't assigned.";
            if (string.IsNullOrEmpty(tbFirstName.Text)) errorMessage = "First name wasn't assigned";
            if (string.IsNullOrEmpty(tbLastName.Text)) errorMessage = "Last name wasn't assigned.";
            if (dtpBirthDate.Value >= DateTime.Now.Date) errorMessage = "Invalid birth date!";
            if (dtpEmploymentDate.Value > DateTime.Now.Date) errorMessage = "Invalid employment date!";

            return string.IsNullOrEmpty(errorMessage);
        }

        private static int SetNewEmployeeId()
        {
            Employee lastAddedEmployee = Main.Employees.OrderByDescending(e => e.Id).FirstOrDefault();
            
            if (lastAddedEmployee is null)
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

        private void BtnCancel_Click(object sender, EventArgs e) => this.Close();
    }
}
