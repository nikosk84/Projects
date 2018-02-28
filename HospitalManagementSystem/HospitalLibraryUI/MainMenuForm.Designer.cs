namespace HospitalSystemUI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.mainMenuLbl = new System.Windows.Forms.Label();
            this.createPatientBtn = new System.Windows.Forms.Button();
            this.CreateEmployeeBtn = new System.Windows.Forms.Button();
            this.findStaffMenuBtn = new System.Windows.Forms.Button();
            this.logOffBtn = new System.Windows.Forms.Button();
            this.updateRecordBtn = new System.Windows.Forms.Button();
            this.GetEmployeeListBtn = new System.Windows.Forms.Button();
            this.UpdatePatientBtn = new System.Windows.Forms.Button();
            this.GetPatientListBtn = new System.Windows.Forms.Button();
            this.FindPatientBtn = new System.Windows.Forms.Button();
            this.staffLbl = new System.Windows.Forms.Label();
            this.patientsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuLbl
            // 
            this.mainMenuLbl.AutoSize = true;
            this.mainMenuLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLbl.Location = new System.Drawing.Point(164, 20);
            this.mainMenuLbl.Name = "mainMenuLbl";
            this.mainMenuLbl.Size = new System.Drawing.Size(182, 45);
            this.mainMenuLbl.TabIndex = 1;
            this.mainMenuLbl.Text = "Main Menu";
            // 
            // createPatientBtn
            // 
            this.createPatientBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPatientBtn.Location = new System.Drawing.Point(255, 124);
            this.createPatientBtn.Name = "createPatientBtn";
            this.createPatientBtn.Size = new System.Drawing.Size(126, 36);
            this.createPatientBtn.TabIndex = 11;
            this.createPatientBtn.Text = "Create Patient";
            this.createPatientBtn.UseVisualStyleBackColor = true;
            this.createPatientBtn.Click += new System.EventHandler(this.CreatePatientBtn_Click);
            // 
            // CreateEmployeeBtn
            // 
            this.CreateEmployeeBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEmployeeBtn.Location = new System.Drawing.Point(123, 124);
            this.CreateEmployeeBtn.Name = "CreateEmployeeBtn";
            this.CreateEmployeeBtn.Size = new System.Drawing.Size(126, 36);
            this.CreateEmployeeBtn.TabIndex = 13;
            this.CreateEmployeeBtn.Text = "Create Employee";
            this.CreateEmployeeBtn.UseVisualStyleBackColor = true;
            this.CreateEmployeeBtn.Click += new System.EventHandler(this.CreateRecordBtn_Click);
            // 
            // findStaffMenuBtn
            // 
            this.findStaffMenuBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findStaffMenuBtn.Location = new System.Drawing.Point(123, 250);
            this.findStaffMenuBtn.Name = "findStaffMenuBtn";
            this.findStaffMenuBtn.Size = new System.Drawing.Size(126, 36);
            this.findStaffMenuBtn.TabIndex = 18;
            this.findStaffMenuBtn.Text = "Find Staff";
            this.findStaffMenuBtn.UseVisualStyleBackColor = true;
            this.findStaffMenuBtn.Click += new System.EventHandler(this.FindStaffMenuBtn_Click);
            // 
            // logOffBtn
            // 
            this.logOffBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOffBtn.Location = new System.Drawing.Point(193, 325);
            this.logOffBtn.Name = "logOffBtn";
            this.logOffBtn.Size = new System.Drawing.Size(118, 36);
            this.logOffBtn.TabIndex = 20;
            this.logOffBtn.Text = "Log Off";
            this.logOffBtn.UseVisualStyleBackColor = true;
            this.logOffBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // updateRecordBtn
            // 
            this.updateRecordBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRecordBtn.Location = new System.Drawing.Point(123, 166);
            this.updateRecordBtn.Name = "updateRecordBtn";
            this.updateRecordBtn.Size = new System.Drawing.Size(126, 36);
            this.updateRecordBtn.TabIndex = 21;
            this.updateRecordBtn.Text = "Update Record";
            this.updateRecordBtn.UseVisualStyleBackColor = true;
            this.updateRecordBtn.Click += new System.EventHandler(this.UpdateRecordBtn_Click);
            // 
            // GetEmployeeListBtn
            // 
            this.GetEmployeeListBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetEmployeeListBtn.Location = new System.Drawing.Point(123, 208);
            this.GetEmployeeListBtn.Name = "GetEmployeeListBtn";
            this.GetEmployeeListBtn.Size = new System.Drawing.Size(126, 36);
            this.GetEmployeeListBtn.TabIndex = 23;
            this.GetEmployeeListBtn.Text = "Get Employee List";
            this.GetEmployeeListBtn.UseVisualStyleBackColor = true;
            this.GetEmployeeListBtn.Click += new System.EventHandler(this.GetEmployeeListBtn_Click);
            // 
            // UpdatePatientBtn
            // 
            this.UpdatePatientBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePatientBtn.Location = new System.Drawing.Point(255, 166);
            this.UpdatePatientBtn.Name = "UpdatePatientBtn";
            this.UpdatePatientBtn.Size = new System.Drawing.Size(126, 36);
            this.UpdatePatientBtn.TabIndex = 24;
            this.UpdatePatientBtn.Text = "Update Record";
            this.UpdatePatientBtn.UseVisualStyleBackColor = true;
            this.UpdatePatientBtn.Click += new System.EventHandler(this.UpdatePatientBtn_Click);
            // 
            // GetPatientListBtn
            // 
            this.GetPatientListBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPatientListBtn.Location = new System.Drawing.Point(255, 208);
            this.GetPatientListBtn.Name = "GetPatientListBtn";
            this.GetPatientListBtn.Size = new System.Drawing.Size(126, 36);
            this.GetPatientListBtn.TabIndex = 25;
            this.GetPatientListBtn.Text = "Get Patient List";
            this.GetPatientListBtn.UseVisualStyleBackColor = true;
            this.GetPatientListBtn.Click += new System.EventHandler(this.GetPatientListBtn_Click);
            // 
            // FindPatientBtn
            // 
            this.FindPatientBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindPatientBtn.Location = new System.Drawing.Point(255, 250);
            this.FindPatientBtn.Name = "FindPatientBtn";
            this.FindPatientBtn.Size = new System.Drawing.Size(126, 36);
            this.FindPatientBtn.TabIndex = 26;
            this.FindPatientBtn.Text = "Find Patient";
            this.FindPatientBtn.UseVisualStyleBackColor = true;
            this.FindPatientBtn.Click += new System.EventHandler(this.FindPatientBtn_Click);
            // 
            // staffLbl
            // 
            this.staffLbl.AutoSize = true;
            this.staffLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLbl.Location = new System.Drawing.Point(165, 90);
            this.staffLbl.Name = "staffLbl";
            this.staffLbl.Size = new System.Drawing.Size(43, 20);
            this.staffLbl.TabIndex = 27;
            this.staffLbl.Text = "Staff";
            // 
            // patientsLbl
            // 
            this.patientsLbl.AutoSize = true;
            this.patientsLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsLbl.Location = new System.Drawing.Point(287, 90);
            this.patientsLbl.Name = "patientsLbl";
            this.patientsLbl.Size = new System.Drawing.Size(66, 20);
            this.patientsLbl.TabIndex = 28;
            this.patientsLbl.Text = "Patients";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 387);
            this.Controls.Add(this.patientsLbl);
            this.Controls.Add(this.staffLbl);
            this.Controls.Add(this.FindPatientBtn);
            this.Controls.Add(this.GetPatientListBtn);
            this.Controls.Add(this.UpdatePatientBtn);
            this.Controls.Add(this.GetEmployeeListBtn);
            this.Controls.Add(this.updateRecordBtn);
            this.Controls.Add(this.logOffBtn);
            this.Controls.Add(this.findStaffMenuBtn);
            this.Controls.Add(this.CreateEmployeeBtn);
            this.Controls.Add(this.createPatientBtn);
            this.Controls.Add(this.mainMenuLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuLbl;
        private System.Windows.Forms.Button createPatientBtn;
        private System.Windows.Forms.Button CreateEmployeeBtn;
        private System.Windows.Forms.Button findStaffMenuBtn;
        private System.Windows.Forms.Button logOffBtn;
        private System.Windows.Forms.Button updateRecordBtn;
        private System.Windows.Forms.Button GetEmployeeListBtn;
        private System.Windows.Forms.Button UpdatePatientBtn;
        private System.Windows.Forms.Button GetPatientListBtn;
        private System.Windows.Forms.Button FindPatientBtn;
        private System.Windows.Forms.Label staffLbl;
        private System.Windows.Forms.Label patientsLbl;
    }
}