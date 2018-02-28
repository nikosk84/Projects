namespace HospitalSystemUI
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.MainMenuTitle = new System.Windows.Forms.Label();
            this.CreatePatientButton = new System.Windows.Forms.Button();
            this.CreateEmployeeButton = new System.Windows.Forms.Button();
            this.FindStaffButton = new System.Windows.Forms.Button();
            this.LogOffButton = new System.Windows.Forms.Button();
            this.UpdateRecordButton = new System.Windows.Forms.Button();
            this.GetEmployeeListButton = new System.Windows.Forms.Button();
            this.UpdatePatientRecordButton = new System.Windows.Forms.Button();
            this.GetPatientListButton = new System.Windows.Forms.Button();
            this.FindPatientButton = new System.Windows.Forms.Button();
            this.StaffLabel = new System.Windows.Forms.Label();
            this.PatientsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenuTitle
            // 
            this.MainMenuTitle.AutoSize = true;
            this.MainMenuTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuTitle.Location = new System.Drawing.Point(164, 20);
            this.MainMenuTitle.Name = "MainMenuTitle";
            this.MainMenuTitle.Size = new System.Drawing.Size(182, 45);
            this.MainMenuTitle.TabIndex = 1;
            this.MainMenuTitle.Text = "Main Menu";
            // 
            // CreatePatientButton
            // 
            this.CreatePatientButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePatientButton.Location = new System.Drawing.Point(255, 124);
            this.CreatePatientButton.Name = "CreatePatientButton";
            this.CreatePatientButton.Size = new System.Drawing.Size(126, 36);
            this.CreatePatientButton.TabIndex = 11;
            this.CreatePatientButton.Text = "Create Patient";
            this.CreatePatientButton.UseVisualStyleBackColor = true;
            this.CreatePatientButton.Click += new System.EventHandler(this.CreatePatientBtn_Click);
            // 
            // CreateEmployeeButton
            // 
            this.CreateEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEmployeeButton.Location = new System.Drawing.Point(123, 124);
            this.CreateEmployeeButton.Name = "CreateEmployeeButton";
            this.CreateEmployeeButton.Size = new System.Drawing.Size(126, 36);
            this.CreateEmployeeButton.TabIndex = 13;
            this.CreateEmployeeButton.Text = "Create Employee";
            this.CreateEmployeeButton.UseVisualStyleBackColor = true;
            this.CreateEmployeeButton.Click += new System.EventHandler(this.CreateRecordBtn_Click);
            // 
            // FindStaffButton
            // 
            this.FindStaffButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindStaffButton.Location = new System.Drawing.Point(123, 250);
            this.FindStaffButton.Name = "FindStaffButton";
            this.FindStaffButton.Size = new System.Drawing.Size(126, 36);
            this.FindStaffButton.TabIndex = 18;
            this.FindStaffButton.Text = "Find Staff";
            this.FindStaffButton.UseVisualStyleBackColor = true;
            this.FindStaffButton.Click += new System.EventHandler(this.FindStaffMenuBtn_Click);
            // 
            // LogOffButton
            // 
            this.LogOffButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOffButton.Location = new System.Drawing.Point(193, 325);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.Size = new System.Drawing.Size(118, 36);
            this.LogOffButton.TabIndex = 20;
            this.LogOffButton.Text = "Log Off";
            this.LogOffButton.UseVisualStyleBackColor = true;
            this.LogOffButton.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // UpdateRecordButton
            // 
            this.UpdateRecordButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRecordButton.Location = new System.Drawing.Point(123, 166);
            this.UpdateRecordButton.Name = "UpdateRecordButton";
            this.UpdateRecordButton.Size = new System.Drawing.Size(126, 36);
            this.UpdateRecordButton.TabIndex = 21;
            this.UpdateRecordButton.Text = "Update Record";
            this.UpdateRecordButton.UseVisualStyleBackColor = true;
            this.UpdateRecordButton.Click += new System.EventHandler(this.UpdateRecordBtn_Click);
            // 
            // GetEmployeeListButton
            // 
            this.GetEmployeeListButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetEmployeeListButton.Location = new System.Drawing.Point(123, 208);
            this.GetEmployeeListButton.Name = "GetEmployeeListButton";
            this.GetEmployeeListButton.Size = new System.Drawing.Size(126, 36);
            this.GetEmployeeListButton.TabIndex = 23;
            this.GetEmployeeListButton.Text = "Get Employee List";
            this.GetEmployeeListButton.UseVisualStyleBackColor = true;
            this.GetEmployeeListButton.Click += new System.EventHandler(this.GetEmployeeListBtn_Click);
            // 
            // UpdatePatientRecordButton
            // 
            this.UpdatePatientRecordButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePatientRecordButton.Location = new System.Drawing.Point(255, 166);
            this.UpdatePatientRecordButton.Name = "UpdatePatientRecordButton";
            this.UpdatePatientRecordButton.Size = new System.Drawing.Size(126, 36);
            this.UpdatePatientRecordButton.TabIndex = 24;
            this.UpdatePatientRecordButton.Text = "Update Record";
            this.UpdatePatientRecordButton.UseVisualStyleBackColor = true;
            this.UpdatePatientRecordButton.Click += new System.EventHandler(this.UpdatePatientBtn_Click);
            // 
            // GetPatientListButton
            // 
            this.GetPatientListButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPatientListButton.Location = new System.Drawing.Point(255, 208);
            this.GetPatientListButton.Name = "GetPatientListButton";
            this.GetPatientListButton.Size = new System.Drawing.Size(126, 36);
            this.GetPatientListButton.TabIndex = 25;
            this.GetPatientListButton.Text = "Get Patient List";
            this.GetPatientListButton.UseVisualStyleBackColor = true;
            this.GetPatientListButton.Click += new System.EventHandler(this.GetPatientListBtn_Click);
            // 
            // FindPatientButton
            // 
            this.FindPatientButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindPatientButton.Location = new System.Drawing.Point(255, 250);
            this.FindPatientButton.Name = "FindPatientButton";
            this.FindPatientButton.Size = new System.Drawing.Size(126, 36);
            this.FindPatientButton.TabIndex = 26;
            this.FindPatientButton.Text = "Find Patient";
            this.FindPatientButton.UseVisualStyleBackColor = true;
            this.FindPatientButton.Click += new System.EventHandler(this.FindPatientBtn_Click);
            // 
            // StaffLabel
            // 
            this.StaffLabel.AutoSize = true;
            this.StaffLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffLabel.Location = new System.Drawing.Point(165, 90);
            this.StaffLabel.Name = "StaffLabel";
            this.StaffLabel.Size = new System.Drawing.Size(43, 20);
            this.StaffLabel.TabIndex = 27;
            this.StaffLabel.Text = "Staff";
            // 
            // PatientsLabel
            // 
            this.PatientsLabel.AutoSize = true;
            this.PatientsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsLabel.Location = new System.Drawing.Point(287, 90);
            this.PatientsLabel.Name = "PatientsLabel";
            this.PatientsLabel.Size = new System.Drawing.Size(66, 20);
            this.PatientsLabel.TabIndex = 28;
            this.PatientsLabel.Text = "Patients";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 380);
            this.Controls.Add(this.PatientsLabel);
            this.Controls.Add(this.StaffLabel);
            this.Controls.Add(this.FindPatientButton);
            this.Controls.Add(this.GetPatientListButton);
            this.Controls.Add(this.UpdatePatientRecordButton);
            this.Controls.Add(this.GetEmployeeListButton);
            this.Controls.Add(this.UpdateRecordButton);
            this.Controls.Add(this.LogOffButton);
            this.Controls.Add(this.FindStaffButton);
            this.Controls.Add(this.CreateEmployeeButton);
            this.Controls.Add(this.CreatePatientButton);
            this.Controls.Add(this.MainMenuTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenuTitle;
        private System.Windows.Forms.Button CreatePatientButton;
        private System.Windows.Forms.Button CreateEmployeeButton;
        private System.Windows.Forms.Button FindStaffButton;
        private System.Windows.Forms.Button LogOffButton;
        private System.Windows.Forms.Button UpdateRecordButton;
        private System.Windows.Forms.Button GetEmployeeListButton;
        private System.Windows.Forms.Button UpdatePatientRecordButton;
        private System.Windows.Forms.Button GetPatientListButton;
        private System.Windows.Forms.Button FindPatientButton;
        private System.Windows.Forms.Label StaffLabel;
        private System.Windows.Forms.Label PatientsLabel;
    }
}