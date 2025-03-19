namespace SnackTrackerApp
{
    partial class ViewSnacksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSnacksForm));
            this.tableSnacks = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblViewSnacksTitle = new System.Windows.Forms.Label();
            this.cmbSortOptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tableSnacks
            // 
            this.tableSnacks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableSnacks.ColumnCount = 3;
            this.tableSnacks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSnacks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSnacks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSnacks.Location = new System.Drawing.Point(170, 81);
            this.tableSnacks.Name = "tableSnacks";
            this.tableSnacks.RowCount = 2;
            this.tableSnacks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSnacks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSnacks.Size = new System.Drawing.Size(403, 313);
            this.tableSnacks.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnBack.Location = new System.Drawing.Point(55, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Consolas", 15F);
            this.btnSave.Location = new System.Drawing.Point(316, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblViewSnacksTitle
            // 
            this.lblViewSnacksTitle.AutoSize = true;
            this.lblViewSnacksTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblViewSnacksTitle.Font = new System.Drawing.Font("Consolas", 20F);
            this.lblViewSnacksTitle.Location = new System.Drawing.Point(286, 9);
            this.lblViewSnacksTitle.Name = "lblViewSnacksTitle";
            this.lblViewSnacksTitle.Size = new System.Drawing.Size(224, 32);
            this.lblViewSnacksTitle.TabIndex = 3;
            this.lblViewSnacksTitle.Text = "View Yo Snacks";
            // 
            // cmbSortOptions
            // 
            this.cmbSortOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSortOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortOptions.DropDownWidth = 220;
            this.cmbSortOptions.Font = new System.Drawing.Font("Consolas", 15F);
            this.cmbSortOptions.FormattingEnabled = true;
            this.cmbSortOptions.Items.AddRange(new object[] {
            "Sort By Name",
            "Sort By Quantity",
            "Sort By Date"});
            this.cmbSortOptions.Location = new System.Drawing.Point(584, 44);
            this.cmbSortOptions.Name = "cmbSortOptions";
            this.cmbSortOptions.Size = new System.Drawing.Size(139, 31);
            this.cmbSortOptions.TabIndex = 4;
            this.cmbSortOptions.SelectedIndexChanged += new System.EventHandler(this.cmbSortOptions_SelectedIndexChanged);
            // 
            // ViewSnacksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(843, 462);
            this.Controls.Add(this.cmbSortOptions);
            this.Controls.Add(this.lblViewSnacksTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tableSnacks);
            this.Name = "ViewSnacksForm";
            this.Text = "ViewSnacksForm";
            this.Load += new System.EventHandler(this.ViewSnacksForm_Load);
            this.Resize += new System.EventHandler(this.ViewSnacksForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewSnacksForm_FormClosing);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSnacks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblViewSnacksTitle;
        private System.Windows.Forms.ComboBox cmbSortOptions;
    }
}