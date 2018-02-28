namespace HospitalSystemUI
{
    partial class FindStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindStaffForm));
            this.EmployeesFoundListBox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.SearchLastNameButton = new System.Windows.Forms.Button();
            this.FindStaffTitle = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeesFoundListBox
            // 
            this.EmployeesFoundListBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesFoundListBox.FormattingEnabled = true;
            this.EmployeesFoundListBox.Location = new System.Drawing.Point(14, 135);
            this.EmployeesFoundListBox.Name = "EmployeesFoundListBox";
            this.EmployeesFoundListBox.Size = new System.Drawing.Size(652, 186);
            this.EmployeesFoundListBox.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(14, 88);
            this.LastNameText.Multiline = true;
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(152, 28);
            this.LastNameText.TabIndex = 1;
            // 
            // SearchLastNameButton
            // 
            this.SearchLastNameButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLastNameButton.Location = new System.Drawing.Point(15, 327);
            this.SearchLastNameButton.Name = "SearchLastNameButton";
            this.SearchLastNameButton.Size = new System.Drawing.Size(82, 32);
            this.SearchLastNameButton.TabIndex = 2;
            this.SearchLastNameButton.Text = "Search";
            this.SearchLastNameButton.UseVisualStyleBackColor = true;
            this.SearchLastNameButton.Click += new System.EventHandler(this.SearchLastNameBtn_Click);
            // 
            // FindStaffTitle
            // 
            this.FindStaffTitle.AutoSize = true;
            this.FindStaffTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindStaffTitle.Location = new System.Drawing.Point(145, 9);
            this.FindStaffTitle.Name = "FindStaffTitle";
            this.FindStaffTitle.Size = new System.Drawing.Size(388, 45);
            this.FindStaffTitle.TabIndex = 4;
            this.FindStaffTitle.Text = "Search Staff by Last Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(12, 72);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(89, 13);
            this.LastNameLabel.TabIndex = 5;
            this.LastNameLabel.Text = "Enter Last Name";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(103, 327);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(82, 32);
            this.ReturnButton.TabIndex = 44;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // FindStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 380);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FindStaffTitle);
            this.Controls.Add(this.SearchLastNameButton);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.EmployeesFoundListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindStaffForm";
            this.Text = "Find Staff Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmployeesFoundListBox;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Button SearchLastNameButton;
        private System.Windows.Forms.Label FindStaffTitle;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button ReturnButton;
    }
}