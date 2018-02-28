namespace HospitalSystemUI
{
    partial class FindPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindPatient));
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.searchPatientMainLbl = new System.Windows.Forms.Label();
            this.SearchLastNameBtn = new System.Windows.Forms.Button();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.PatientsFoundLb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.Location = new System.Drawing.Point(100, 327);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(82, 32);
            this.ReturnBtn.TabIndex = 50;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(12, 72);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(89, 13);
            this.lastNameLbl.TabIndex = 49;
            this.lastNameLbl.Text = "Enter Last Name";
            // 
            // searchPatientMainLbl
            // 
            this.searchPatientMainLbl.AutoSize = true;
            this.searchPatientMainLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientMainLbl.Location = new System.Drawing.Point(136, 9);
            this.searchPatientMainLbl.Name = "searchPatientMainLbl";
            this.searchPatientMainLbl.Size = new System.Drawing.Size(423, 45);
            this.searchPatientMainLbl.TabIndex = 48;
            this.searchPatientMainLbl.Text = "Search Patient by Last Name";
            // 
            // SearchLastNameBtn
            // 
            this.SearchLastNameBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLastNameBtn.Location = new System.Drawing.Point(12, 327);
            this.SearchLastNameBtn.Name = "SearchLastNameBtn";
            this.SearchLastNameBtn.Size = new System.Drawing.Size(82, 32);
            this.SearchLastNameBtn.TabIndex = 47;
            this.SearchLastNameBtn.Text = "Search";
            this.SearchLastNameBtn.UseVisualStyleBackColor = true;
            this.SearchLastNameBtn.Click += new System.EventHandler(this.SearchLastNameBtn_Click);
            // 
            // lastNameTb
            // 
            this.lastNameTb.Location = new System.Drawing.Point(12, 88);
            this.lastNameTb.Multiline = true;
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(152, 28);
            this.lastNameTb.TabIndex = 46;
            // 
            // PatientsFoundLb
            // 
            this.PatientsFoundLb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsFoundLb.FormattingEnabled = true;
            this.PatientsFoundLb.Location = new System.Drawing.Point(12, 135);
            this.PatientsFoundLb.Name = "PatientsFoundLb";
            this.PatientsFoundLb.Size = new System.Drawing.Size(670, 186);
            this.PatientsFoundLb.TabIndex = 45;
            // 
            // FindPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 397);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.searchPatientMainLbl);
            this.Controls.Add(this.SearchLastNameBtn);
            this.Controls.Add(this.lastNameTb);
            this.Controls.Add(this.PatientsFoundLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindPatient";
            this.Text = "Find Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label searchPatientMainLbl;
        private System.Windows.Forms.Button SearchLastNameBtn;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.ListBox PatientsFoundLb;
    }
}