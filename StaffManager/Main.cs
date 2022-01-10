using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StaffManager
{
    public partial class Main : Form
    { 
        public Main()
        {
            InitializeComponent();

            var employees = new List<Employee>()
            {
                new Employee(0, "Jan", "Urbaœ", new DateTime(2001,04,19), new DateTime(2020, 12, 19), 2500),
                new Employee(0, "Anna", "Moska³a", new DateTime(2002,07,20), new DateTime(2020, 12, 19), 3500),
                new Employee(0, "Kamil", "Fudala", new DateTime(2001,01,12), new DateTime(2020, 12, 19), 1500),
                new Employee(0, "Mariusz", "Gluza", new DateTime(2001,08,03), new DateTime(2022, 1, 1), 5500)
            };

            SerializeToFile(employees);
            dgvDiary.DataSource = DeserializeFromFile();
        }

        private void SerializeToFile(List<Employee> employees)
        {
            File.WriteAllText(Program.StaffDiaryPath, JsonConvert.SerializeObject(employees));
        }

        private List<Employee> DeserializeFromFile()
        {
            if (File.Exists(Program.StaffDiaryPath))
                return JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(Program.StaffDiaryPath));
            else
                return new List<Employee>();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var addEditEmployee = new AddEditEmployee();
            addEditEmployee.ShowDialog();
        }
    }
}