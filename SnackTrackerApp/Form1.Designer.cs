namespace SnackTrackerApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.btnAddSnacks = new System.Windows.Forms.Button();
            this.btnViewSnacks = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnViewCalories = new System.Windows.Forms.Button();
            this.lblComingSoon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 35F);
            this.lblTitle.Location = new System.Drawing.Point(206, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Snack Tracker";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSlogan
            // 
            this.lblSlogan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSlogan.Font = new System.Drawing.Font("Consolas", 20F);
            this.lblSlogan.Location = new System.Drawing.Point(253, 64);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(254, 32);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "Track Yo Snacks!";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddSnacks
            // 
            this.btnAddSnacks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddSnacks.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddSnacks.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnAddSnacks.Location = new System.Drawing.Point(286, 146);
            this.btnAddSnacks.Name = "btnAddSnacks";
            this.btnAddSnacks.Size = new System.Drawing.Size(131, 44);
            this.btnAddSnacks.TabIndex = 2;
            this.btnAddSnacks.Text = "Add Snacks";
            this.btnAddSnacks.UseVisualStyleBackColor = false;
            this.btnAddSnacks.Click += new System.EventHandler(this.btnAddSnacks_Click);
            // 
            // btnViewSnacks
            // 
            this.btnViewSnacks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewSnacks.BackColor = System.Drawing.SystemColors.Info;
            this.btnViewSnacks.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnViewSnacks.Location = new System.Drawing.Point(286, 247);
            this.btnViewSnacks.Name = "btnViewSnacks";
            this.btnViewSnacks.Size = new System.Drawing.Size(131, 44);
            this.btnViewSnacks.TabIndex = 4;
            this.btnViewSnacks.Text = "View Snacks";
            this.btnViewSnacks.UseVisualStyleBackColor = false;
            this.btnViewSnacks.Click += new System.EventHandler(this.btnViewSnacks_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblVersion.Location = new System.Drawing.Point(308, 96);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(96, 17);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version 1.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnViewCalories
            // 
            this.btnViewCalories.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewCalories.Enabled = false;
            this.btnViewCalories.Font = new System.Drawing.Font("Consolas", 12F);
            this.btnViewCalories.ForeColor = System.Drawing.Color.Black;
            this.btnViewCalories.Location = new System.Drawing.Point(286, 300);
            this.btnViewCalories.Name = "btnViewCalories";
            this.btnViewCalories.Size = new System.Drawing.Size(134, 44);
            this.btnViewCalories.TabIndex = 6;
            this.btnViewCalories.Text = "View Calories";
            this.btnViewCalories.UseVisualStyleBackColor = true;
            // 
            // lblComingSoon
            // 
            this.lblComingSoon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblComingSoon.AutoSize = true;
            this.lblComingSoon.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblComingSoon.Location = new System.Drawing.Point(300, 340);
            this.lblComingSoon.Name = "lblComingSoon";
            this.lblComingSoon.Size = new System.Drawing.Size(104, 17);
            this.lblComingSoon.TabIndex = 7;
            this.lblComingSoon.Text = "Coming Soon!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 561);
            this.Controls.Add(this.lblComingSoon);
            this.Controls.Add(this.btnViewCalories);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnViewSnacks);
            this.Controls.Add(this.btnAddSnacks);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Button btnAddSnacks;
        private System.Windows.Forms.Button btnViewSnacks;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnViewCalories;
        private System.Windows.Forms.Label lblComingSoon;
    }
}

