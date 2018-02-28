namespace HospitalSystemUI
{
    partial class FindStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindStaff));
            this.employeesFoundLb = new System.Windows.Forms.ListBox();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.searchLastNameBtn = new System.Windows.Forms.Button();
            this.searchStaffMainLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeesFoundLb
            // 
            this.employeesFoundLb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesFoundLb.FormattingEnabled = true;
            this.employeesFoundLb.Location = new System.Drawing.Point(14, 135);
            this.employeesFoundLb.Name = "employeesFoundLb";
            this.employeesFoundLb.Size = new System.Drawing.Size(652, 186);
            this.employeesFoundLb.TabIndex = 0;
            // 
            // lastNameTb
            // 
            this.lastNameTb.Location = new System.Drawing.Point(14, 88);
            this.lastNameTb.Multiline = true;
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(152, 28);
            this.lastNameTb.TabIndex = 1;
            // 
            // searchLastNameBtn
            // 
            this.searchLastNameBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLastNameBtn.Location = new System.Drawing.Point(15, 327);
            this.searchLastNameBtn.Name = "searchLastNameBtn";
            this.searchLastNameBtn.Size = new System.Drawing.Size(82, 32);
            this.searchLastNameBtn.TabIndex = 2;
            this.searchLastNameBtn.Text = "Search";
            this.searchLastNameBtn.UseVisualStyleBackColor = true;
            this.searchLastNameBtn.Click += new System.EventHandler(this.SearchLastNameBtn_Click);
            // 
            // searchStaffMainLbl
            // 
            this.searchStaffMainLbl.AutoSize = true;
            this.searchStaffMainLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStaffMainLbl.Location = new System.Drawing.Point(145, 9);
            this.searchStaffMainLbl.Name = "searchStaffMainLbl";
            this.searchStaffMainLbl.Size = new System.Drawing.Size(388, 45);
            this.searchStaffMainLbl.TabIndex = 4;
            this.searchStaffMainLbl.Text = "Search Staff by Last Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(12, 72);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(89, 13);
            this.lastNameLbl.TabIndex = 5;
            this.lastNameLbl.Text = "Enter Last Name";
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(103, 327);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(82, 32);
            this.returnBtn.TabIndex = 44;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // FindStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 380);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.searchStaffMainLbl);
            this.Controls.Add(this.searchLastNameBtn);
            this.Controls.Add(this.lastNameTb);
            this.Controls.Add(this.employeesFoundLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindStaff";
            this.Text = "Find Staff Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeesFoundLb;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.Button searchLastNameBtn;
        private System.Windows.Forms.Label searchStaffMainLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Button returnBtn;
    }
}