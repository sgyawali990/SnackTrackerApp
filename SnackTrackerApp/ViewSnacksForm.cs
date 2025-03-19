using SnackTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnackTrackerApp
{
    public partial class ViewSnacksForm : Form
    {
        private List<Snack> sortedSnacks; // Holds the currently sorted snack list

        public ViewSnacksForm()
        {
            InitializeComponent();
            this.Resize += ViewSnacksForm_Resize;
        }

        private void ViewSnacksForm_Load(object sender, EventArgs e) // Initializes the view snacks form and positions controls
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1000, 700);

            if (Application.OpenForms["Form1"] is Form1 mainForm && Form1.isFullScreen)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            cmbSortOptions.SelectedIndex = 0;
            cmbSortOptions.Items[0] = "Sort by Name";
            cmbSortOptions.Visible = true;

            btnBack.Size = new Size(101, 38);
            cmbSortOptions.Size = new Size(200, 38);

            btnBack.Left = 55;
            btnBack.Top = 20;

            cmbSortOptions.Left = this.ClientSize.Width - cmbSortOptions.Width - 55;
            cmbSortOptions.Top = btnBack.Top;

            tableSnacks.Width = this.ClientSize.Width - 100;
            tableSnacks.Left = (this.ClientSize.Width - tableSnacks.Width) / 2;
            tableSnacks.Top = btnBack.Bottom + 10;

            btnSave.Left = (this.ClientSize.Width - btnSave.Width) / 2;
            btnSave.Top = tableSnacks.Bottom + 20;

            LoadSnacks();
        }

        private void ViewSnacksForm_Resize(object sender, EventArgs e) // Repositions controls dynamically when the window is resized
        {
            lblViewSnacksTitle.Left = (this.ClientSize.Width - lblViewSnacksTitle.Width) / 2;
            lblViewSnacksTitle.Top = 15;

            btnBack.Left = 55;
            btnBack.Top = 20;

            if (cmbSortOptions != null)
            {
                cmbSortOptions.Width = 200;
                cmbSortOptions.Left = tableSnacks.Right - cmbSortOptions.Width;
                cmbSortOptions.Top = btnBack.Top;
            }

            tableSnacks.Width = this.ClientSize.Width - 100;
            tableSnacks.Left = (this.ClientSize.Width - tableSnacks.Width) / 2;

            if (cmbSortOptions != null)
            {
                tableSnacks.Top = cmbSortOptions.Bottom + 10;
            }
            else
            {
                tableSnacks.Top = lblViewSnacksTitle.Bottom + 20;
            }

            btnSave.Left = (this.ClientSize.Width - btnSave.Width) / 2;
            btnSave.Top = tableSnacks.Bottom + 20;
        }

        private void cmbSortOptions_SelectedIndexChanged(object sender, EventArgs e) // Handles sorting logic when sort option is changed
        {
            using (var db = new SnackDbContext())
            {
                switch (cmbSortOptions.SelectedIndex)
                {
                    case 1:
                        sortedSnacks = db.Snacks.OrderByDescending(s => s.Quantity).ToList();
                        break;
                    case 2:
                        sortedSnacks = db.Snacks.OrderByDescending(s => s.DateAdded).ToList();
                        break;
                    default:
                        sortedSnacks = db.Snacks.OrderBy(s => s.Name).ToList();
                        break;
                }
            }

            LoadSnacks(sortedSnacks);
        }

        private void LoadSnacks(List<Snack> snacks = null) // Loads snack data into the table (optionally sorted)
        {
            tableSnacks.Controls.Clear();
            tableSnacks.RowCount = 1;
            tableSnacks.ColumnCount = 3;

            tableSnacks.ColumnStyles.Clear();
            tableSnacks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            tableSnacks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tableSnacks.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));

            AddTableHeaders();

            using (var db = new SnackDbContext())
            {
                var displaySnacks = snacks ?? db.Snacks.Where(s => s.Quantity > 0).ToList();

                foreach (var snack in displaySnacks)
                {
                    int rowIndex = tableSnacks.RowCount++;
                    tableSnacks.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

                    AddSnackRow(snack, rowIndex);
                }
            }
        }

        private void AddTableHeaders() // Adds column headers for the snack table
        {
            tableSnacks.Controls.Add(CreateHeaderLabel("Snack"), 0, 0);
            tableSnacks.Controls.Add(CreateHeaderLabel("Quantity"), 1, 0);
            tableSnacks.Controls.Add(CreateHeaderLabel("Date Added"), 2, 0);
        }

        private Label CreateHeaderLabel(string text)
        {
            return new Label()
            {
                Text = text,
                Font = new Font("Consolas", 14F, FontStyle.Bold),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Padding = new Padding(5)
            };
        }

        private void AddSnackRow(Snack snack, int rowIndex) // Adds a row for each snack with name, quantity, and date
        {
            Label lblSnackName = new Label()
            {
                Text = snack.Name,
                Font = new Font("Consolas", 12F, FontStyle.Bold),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Padding = new Padding(5),
                BackColor = snack.Quantity <= snack.WarningThreshold ? Color.Yellow : Color.White
            };

            NumericUpDown numQuantity = new NumericUpDown()
            {
                Minimum = 0,
                Maximum = snack.Quantity,
                Value = snack.Quantity,
                Font = new Font("Consolas", 12F),
                TextAlign = HorizontalAlignment.Center,
                Dock = DockStyle.Fill,
                Tag = snack.Name
            };

            Label lblDateAdded = new Label()
            {
                Text = snack.DateAdded == default(DateTime) ? "N/A" : snack.DateAdded.ToShortDateString(),
                Font = new Font("Consolas", 12F),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Padding = new Padding(5)
            };

            tableSnacks.Controls.Add(lblSnackName, 0, rowIndex);
            tableSnacks.Controls.Add(numQuantity, 1, rowIndex);
            tableSnacks.Controls.Add(lblDateAdded, 2, rowIndex);
        }

        private void btnSave_Click(object sender, EventArgs e) // Save changes made to snacks
        {
            using (var db = new SnackDbContext())
            {
                foreach (Control control in tableSnacks.Controls)
                {
                    if (control is NumericUpDown numControl && numControl.Tag is string snackName)
                    {
                        var snack = db.Snacks.FirstOrDefault(s => s.Name == snackName);

                        if (snack != null)
                        {
                            snack.Quantity = (int)numControl.Value;
                            if (snack.Quantity <= 0)
                            {
                                db.Snacks.Remove(snack);
                            }
                        }
                    }
                }
                db.SaveChanges();
            }

            LoadSnacks();
            MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e) // Return to menu
        {
            Form1 mainMenu;

            if (Application.OpenForms["Form1"] is Form1 openMenu)
            {
                mainMenu = openMenu;
            }
            else
            {
                mainMenu = new Form1();
            }

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

            mainMenu.Show();
            this.Close();
        }

        private void ViewSnacksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

