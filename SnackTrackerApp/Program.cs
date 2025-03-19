using SnackTrackerApp.Models;
using System;
using System.Windows.Forms;

namespace SnackTrackerApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the Snack Tracker application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.ApplicationExit += (sender, e) => Environment.Exit(0);
        }
    }
}
