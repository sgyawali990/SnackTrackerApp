namespace SnackTrackerApp
{
    partial class AddSnacksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSnacksForm));
            this.selectSnackTitle = new System.Windows.Forms.Label();
            this.btnSaveSnacks = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.snackPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // selectSnackTitle
            // 
            this.selectSnackTitle.AutoSize = true;
            this.selectSnackTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.selectSnackTitle.Font = new System.Drawing.Font("Consolas", 20F);
            this.selectSnackTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectSnackTitle.Location = new System.Drawing.Point(286, 9);
            this.selectSnackTitle.Name = "selectSnackTitle";
            this.selectSnackTitle.Size = new System.Drawing.Size(224, 32);
            this.selectSnackTitle.TabIndex = 0;
            this.selectSnackTitle.Text = "Select a Snack";
            this.selectSnackTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectSnackTitle.Click += new System.EventHandler(this.selectSnackTitle_Click);
            // 
            // btnSaveSnacks
            // 
            this.btnSaveSnacks.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnSaveSnacks.Location = new System.Drawing.Point(335, 400);
            this.btnSaveSnacks.Name = "btnSaveSnacks";
            this.btnSaveSnacks.Size = new System.Drawing.Size(107, 47);
            this.btnSaveSnacks.TabIndex = 2;
            this.btnSaveSnacks.Text = "Save ";
            this.btnSaveSnacks.UseVisualStyleBackColor = true;
            this.btnSaveSnacks.Click += new System.EventHandler(this.btnSaveSnacks_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnBack.Location = new System.Drawing.Point(55, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 38);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // snackPanel
            // 
            this.snackPanel.ColumnCount = 2;
            this.snackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.snackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.snackPanel.Location = new System.Drawing.Point(231, 44);
            this.snackPanel.Name = "snackPanel";
            this.snackPanel.RowCount = 5;
            this.snackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.snackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.snackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.snackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.snackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.snackPanel.Size = new System.Drawing.Size(317, 350);
            this.snackPanel.TabIndex = 5;
            // 
            // AddSnacksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.snackPanel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveSnacks);
            this.Controls.Add(this.selectSnackTitle);
            this.Name = "AddSnacksForm";
            this.Text = "AddSnacksForm";
            this.Load += new System.EventHandler(this.AddSnacksForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSnacksForm_FormClosing);

        }

        #endregion

        private System.Windows.Forms.Label selectSnackTitle;
        private System.Windows.Forms.Button btnSaveSnacks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel snackPanel;
    }
}