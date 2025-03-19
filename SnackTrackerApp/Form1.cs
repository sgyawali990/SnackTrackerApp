using System;
using System.Windows.Forms;

namespace SnackTrackerApp
{
    public partial class Form1 : Form
    {
        public static bool isFullScreen = false; // Tracks whether the app is in fullscreen mode

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Initializes the main menu form and applies fullscreen if needed
        {
            CenterControls();
            lblComingSoon.Left = btnViewCalories.Left + (btnViewCalories.Width - lblComingSoon.Width) / 2;
            lblComingSoon.Top = btnViewCalories.Bottom + 5;
        }

        private void CenterControls()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            lblSlogan.Left = (this.ClientSize.Width - lblSlogan.Width) / 2;
            lblVersion.Left = (this.ClientSize.Width - lblVersion.Width) / 2;
            lblComingSoon.Left = (this.ClientSize.Width - lblComingSoon.Width) / 2;
            lblComingSoon.Top = btnViewCalories.Bottom + 14;

            int buttonSpacing = 20;
            int buttonWidth = btnAddSnacks.Width;
            int centerX = (this.ClientSize.Width - buttonWidth) / 2;

            btnAddSnacks.Left = centerX;
            btnViewSnacks.Left = centerX;
            btnViewCalories.Left = centerX;

            btnAddSnacks.Top = lblSlogan.Bottom + 40;
            btnViewSnacks.Top = btnAddSnacks.Bottom + buttonSpacing;
            btnViewCalories.Top = btnViewSnacks.Bottom + buttonSpacing;
        }

        private void Form1_Resize(object sender, EventArgs e) // Tracks when the main menu is resized and updates fullscreen state
        {
            isFullScreen = (this.WindowState == FormWindowState.Maximized);
            CenterControls();

            lblComingSoon.Left = btnViewCalories.Left + (btnViewCalories.Width - lblComingSoon.Width) / 2;
            lblComingSoon.Top = btnViewCalories.Bottom + 5;
        }

        private void btnAddSnacks_Click(object sender, EventArgs e) // Opens the Add Snacks form
        {
            AddSnacksForm addSnacksForm = new AddSnacksForm();

            if (isFullScreen)
            {
                addSnacksForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                addSnacksForm.StartPosition = FormStartPosition.Manual;
                addSnacksForm.Location = this.Location;
                addSnacksForm.Size = this.Size;
            }

            addSnacksForm.Show();
            this.Hide();
        }

        private void btnViewSnacks_Click(object sender, EventArgs e) // Opens the View Snacks form
        {
            ViewSnacksForm viewSnacksForm = new ViewSnacksForm();

            if (isFullScreen)
            {
                viewSnacksForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                viewSnacksForm.StartPosition = FormStartPosition.Manual;
                viewSnacksForm.Location = this.Location;
                viewSnacksForm.Size = this.Size;
            }

            viewSnacksForm.Show();
            this.Hide();
        }

        private void btnViewCalories_Click(object sender, EventArgs e) // Future feature
        {
            MessageBox.Show("Calorie tracking feature coming soon!", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

