namespace HospitalSystemUI
{
    partial class CreateEmployeeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEmployeeForm));
            this.AddEmployeeLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CellNoLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.CellNoText = new System.Windows.Forms.TextBox();
            this.PositionText = new System.Windows.Forms.TextBox();
            this.SaveRecordButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ClearFieldsButton = new System.Windows.Forms.Button();
            this.PositionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.MakeChoiceEmpPosLabel = new System.Windows.Forms.Label();
            this.EmployeeFormValidator = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeFormValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEmployeeLabel
            // 
            this.AddEmployeeLabel.AutoSize = true;
            this.AddEmployeeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeLabel.Location = new System.Drawing.Point(155, 17);
            this.AddEmployeeLabel.Name = "AddEmployeeLabel";
            this.AddEmployeeLabel.Size = new System.Drawing.Size(227, 45);
            this.AddEmployeeLabel.TabIndex = 2;
            this.AddEmployeeLabel.Text = "Add Employee";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(236, 104);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(62, 13);
            this.FirstNameLabel.TabIndex = 12;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(236, 137);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(60, 13);
            this.LastNameLabel.TabIndex = 13;
            this.LastNameLabel.Text = "Last Name";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(236, 170);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 14;
            this.AddressLabel.Text = "Address";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(236, 209);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(39, 13);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "E-mail";
            // 
            // CellNoLabel
            // 
            this.CellNoLabel.AutoSize = true;
            this.CellNoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellNoLabel.Location = new System.Drawing.Point(236, 242);
            this.CellNoLabel.Name = "CellNoLabel";
            this.CellNoLabel.Size = new System.Drawing.Size(70, 13);
            this.CellNoLabel.TabIndex = 16;
            this.CellNoLabel.Text = "Cell Number";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.Location = new System.Drawing.Point(236, 275);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(48, 13);
            this.PositionLabel.TabIndex = 17;
            this.PositionLabel.Text = "Position";
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(312, 101);
            this.FirstNameText.Multiline = true;
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(157, 27);
            this.FirstNameText.TabIndex = 21;
            this.FirstNameText.Validating += new System.ComponentModel.CancelEventHandler(this.FirstName_Validating);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(312, 134);
            this.LastNameText.Multiline = true;
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(157, 27);
            this.LastNameText.TabIndex = 22;
            this.LastNameText.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(312, 167);
            this.AddressText.Multiline = true;
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(157, 27);
            this.AddressText.TabIndex = 23;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(312, 200);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(157, 27);
            this.EmailText.TabIndex = 24;
            // 
            // CellNoText
            // 
            this.CellNoText.Location = new System.Drawing.Point(312, 236);
            this.CellNoText.Multiline = true;
            this.CellNoText.Name = "CellNoText";
            this.CellNoText.Size = new System.Drawing.Size(157, 27);
            this.CellNoText.TabIndex = 25;
            // 
            // PositionText
            // 
            this.PositionText.Location = new System.Drawing.Point(312, 269);
            this.PositionText.Multiline = true;
            this.PositionText.Name = "PositionText";
            this.PositionText.ReadOnly = true;
            this.PositionText.Size = new System.Drawing.Size(157, 27);
            this.PositionText.TabIndex = 26;
            // 
            // SaveRecordButton
            // 
            this.SaveRecordButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveRecordButton.Location = new System.Drawing.Point(114, 326);
            this.SaveRecordButton.Name = "SaveRecordButton";
            this.SaveRecordButton.Size = new System.Drawing.Size(99, 36);
            this.SaveRecordButton.TabIndex = 33;
            this.SaveRecordButton.Text = "Save Record";
            this.SaveRecordButton.UseVisualStyleBackColor = true;
            this.SaveRecordButton.Click += new System.EventHandler(this.SaveRecordBtn_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(324, 326);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(99, 36);
            this.ReturnButton.TabIndex = 34;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnToMainBtn_Click);
            // 
            // ClearFieldsButton
            // 
            this.ClearFieldsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFieldsButton.Location = new System.Drawing.Point(219, 326);
            this.ClearFieldsButton.Name = "ClearFieldsButton";
            this.ClearFieldsButton.Size = new System.Drawing.Size(99, 36);
            this.ClearFieldsButton.TabIndex = 35;
            this.ClearFieldsButton.Text = "Clear";
            this.ClearFieldsButton.UseVisualStyleBackColor = true;
            this.ClearFieldsButton.Click += new System.EventHandler(this.ClearFieldsBtn_Click);
            // 
            // PositionsCheckedListBox
            // 
            this.PositionsCheckedListBox.CheckOnClick = true;
            this.PositionsCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionsCheckedListBox.FormattingEnabled = true;
            this.PositionsCheckedListBox.Items.AddRange(new object[] {
            "Manager",
            "Administration",
            "Security",
            "Driver",
            "Cleaner",
            "Surgeon",
            "Canteen",
            "Maintenance",
            "Doctor",
            "Nurse",
            "System Administrator"});
            this.PositionsCheckedListBox.Location = new System.Drawing.Point(71, 105);
            this.PositionsCheckedListBox.Name = "PositionsCheckedListBox";
            this.PositionsCheckedListBox.Size = new System.Drawing.Size(133, 191);
            this.PositionsCheckedListBox.TabIndex = 36;
            this.PositionsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.PositionsCheckedLb_SelectedIndexChanged);
            // 
            // MakeChoiceEmpPosLabel
            // 
            this.MakeChoiceEmpPosLabel.AutoSize = true;
            this.MakeChoiceEmpPosLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeChoiceEmpPosLabel.Location = new System.Drawing.Point(68, 87);
            this.MakeChoiceEmpPosLabel.Name = "MakeChoiceEmpPosLabel";
            this.MakeChoiceEmpPosLabel.Size = new System.Drawing.Size(101, 15);
            this.MakeChoiceEmpPosLabel.TabIndex = 37;
            this.MakeChoiceEmpPosLabel.Text = "Make one choice";
            // 
            // EmployeeFormValidator
            // 
            this.EmployeeFormValidator.ContainerControl = this;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 404);
            this.Controls.Add(this.MakeChoiceEmpPosLabel);
            this.Controls.Add(this.PositionsCheckedListBox);
            this.Controls.Add(this.ClearFieldsButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SaveRecordButton);
            this.Controls.Add(this.PositionText);
            this.Controls.Add(this.CellNoText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.CellNoLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.AddEmployeeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateEmployeeForm";
            this.Text = "Add New Employee";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeFormValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddEmployeeLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CellNoLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Button SaveRecordButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button ClearFieldsButton;
        private System.Windows.Forms.Label MakeChoiceEmpPosLabel;
        public System.Windows.Forms.TextBox FirstNameText;
        public System.Windows.Forms.TextBox LastNameText;
        public System.Windows.Forms.TextBox AddressText;
        public System.Windows.Forms.TextBox EmailText;
        public System.Windows.Forms.TextBox CellNoText;
        public System.Windows.Forms.TextBox PositionText;
        private System.Windows.Forms.ErrorProvider EmployeeFormValidator;
        public System.Windows.Forms.CheckedListBox PositionsCheckedListBox;
    }
}