using SnackTrackerApp.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnackTrackerApp
{
    public partial class AddSnacksForm : Form
    {
        private bool isSaved = false; // Tracks if the current changes have been saved

        public AddSnacksForm()
        {
            InitializeComponent();
        }

        private void AddSnacksForm_Load(object sender, EventArgs e) // Sets up the add snack form on load and applies fullscreen if needed
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(850, 600);

            // Maintain fullscreen if menu is fullscreen
            if (Application.OpenForms["Form1"] is Form1 mainForm && Form1.isFullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            InitializeSnackPanel();
        }

        private void InitializeSnackPanel() // Dynamically creates snack labels and input fields on the panel
        {
            string[] snackNames = { "Chips", "Cookies", "Soda", "Popcorn", "Candy", "Crackers", "Cereal Bars", "Pretzels", "Nuts", "Gum" };
            snackPanel.Controls.Clear();

            foreach (var snack in snackNames)
            {
                Label snackLabel = new Label
                {
                    Text = snack,
                    Font = new Font("Consolas", 12F, FontStyle.Bold),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                NumericUpDown snackQuantity = new NumericUpDown
                {
                    Minimum = 0,
                    Maximum = 100,
                    Font = new Font("Consolas", 12F),
                    Tag = snack,
                    Dock = DockStyle.Fill
                };

                snackPanel.Controls.Add(snackLabel);
                snackPanel.Controls.Add(snackQuantity);
            }
        }

        private void btnSaveSnacks_Click(object sender, EventArgs e) // Saves entered snack quantities to the database
        {
            using (var db = new SnackDbContext())
            {
                foreach (Control control in snackPanel.Controls)
                {
                    if (control is NumericUpDown numUpDown && numUpDown.Value > 0)
                    {
                        string snackName = (string)numUpDown.Tag;
                        var existingSnack = db.Snacks.FirstOrDefault(s => s.Name == snackName);

                        if (existingSnack != null)
                        {
                            existingSnack.Quantity += (int)numUpDown.Value;
                            existingSnack.DateAdded = DateTime.Now;
                        }
                        else
                        {
                            db.Snacks.Add(new Snack
                            {
                                Name = snackName,
                                Quantity = (int)numUpDown.Value,
                                DateAdded = DateTime.Now
                            });
                        }
                    }
                }

                db.SaveChanges();
            }

            isSaved = true;
            MessageBox.Show("Snacks saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e) // Returns to the main menu, shows warning if needed
        {
            Form1 mainMenu = Application.OpenForms["Form1"] as Form1 ?? new Form1();

            if (Form1.isFullScreen)
            {
                mainMenu.WindowState = FormWindowState.Maximized;
            }
            else
            {
                mainMenu.StartPosition = FormStartPosition.Manual;
                mainMenu.Location = this.Location;
                mainMenu.Size = this.Size;
            }

            if (!isSaved)
            {
                bool unsavedChanges = snackPanel.Controls.OfType<NumericUpDown>().Any(n => n.Value > 0);

                if (unsavedChanges)
                {
                    DialogResult result = MessageBox.Show(
                        "You have unsaved changes. Exit anyway?",
                        "Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.No)
                        return;
                }
            }

            mainMenu.Show();
            this.Close();
        }

        private void selectSnackTitle_Click(object sender, EventArgs e)
        {

        }

        private void AddSnacksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}