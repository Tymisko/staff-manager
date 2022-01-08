using System;
using System.IO;
using System.Windows.Forms;

namespace StaffManager
{
    internal static class Program
    {
        public static readonly string StaffDiaryPath = Path.Combine(
            Path.GetDirectoryName(Application.ExecutablePath), "staff.json");
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}