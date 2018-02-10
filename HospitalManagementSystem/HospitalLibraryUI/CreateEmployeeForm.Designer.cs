namespace HospitalSystemUI
{
    partial class CreateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEmployee));
            this.addNewRecordLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.emailAddressLbl = new System.Windows.Forms.Label();
            this.cellNumberLbl = new System.Windows.Forms.Label();
            this.positionLbl = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.cellNo = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.saveRecordBtn = new System.Windows.Forms.Button();
            this.returnToMainBtn = new System.Windows.Forms.Button();
            this.clearFieldsBtn = new System.Windows.Forms.Button();
            this.PositionsCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.formValidator = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.formValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewRecordLbl
            // 
            this.addNewRecordLbl.AutoSize = true;
            this.addNewRecordLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewRecordLbl.Location = new System.Drawing.Point(155, 17);
            this.addNewRecordLbl.Name = "addNewRecordLbl";
            this.addNewRecordLbl.Size = new System.Drawing.Size(227, 45);
            this.addNewRecordLbl.TabIndex = 2;
            this.addNewRecordLbl.Text = "Add Employee";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(236, 104);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(62, 13);
            this.firstNameLbl.TabIndex = 12;
            this.firstNameLbl.Text = "First Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(236, 137);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(60, 13);
            this.lastNameLbl.TabIndex = 13;
            this.lastNameLbl.Text = "Last Name";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(236, 170);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(48, 13);
            this.addressLbl.TabIndex = 14;
            this.addressLbl.Text = "Address";
            // 
            // emailAddressLbl
            // 
            this.emailAddressLbl.AutoSize = true;
            this.emailAddressLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLbl.Location = new System.Drawing.Point(236, 209);
            this.emailAddressLbl.Name = "emailAddressLbl";
            this.emailAddressLbl.Size = new System.Drawing.Size(39, 13);
            this.emailAddressLbl.TabIndex = 15;
            this.emailAddressLbl.Text = "E-mail";
            // 
            // cellNumberLbl
            // 
            this.cellNumberLbl.AutoSize = true;
            this.cellNumberLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellNumberLbl.Location = new System.Drawing.Point(236, 242);
            this.cellNumberLbl.Name = "cellNumberLbl";
            this.cellNumberLbl.Size = new System.Drawing.Size(70, 13);
            this.cellNumberLbl.TabIndex = 16;
            this.cellNumberLbl.Text = "Cell Number";
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLbl.Location = new System.Drawing.Point(236, 275);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(48, 13);
            this.positionLbl.TabIndex = 17;
            this.positionLbl.Text = "Position";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(312, 101);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(157, 27);
            this.firstName.TabIndex = 21;
            this.firstName.Validating += new System.ComponentModel.CancelEventHandler(this.FirstName_Validating);
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(312, 134);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(157, 27);
            this.lastName.TabIndex = 22;
            this.lastName.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(312, 167);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(157, 27);
            this.address.TabIndex = 23;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(312, 200);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(157, 27);
            this.email.TabIndex = 24;
            // 
            // cellNo
            // 
            this.cellNo.Location = new System.Drawing.Point(312, 236);
            this.cellNo.Multiline = true;
            this.cellNo.Name = "cellNo";
            this.cellNo.Size = new System.Drawing.Size(157, 27);
            this.cellNo.TabIndex = 25;
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(312, 269);
            this.position.Multiline = true;
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Size = new System.Drawing.Size(157, 27);
            this.position.TabIndex = 26;
            // 
            // saveRecordBtn
            // 
            this.saveRecordBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRecordBtn.Location = new System.Drawing.Point(114, 326);
            this.saveRecordBtn.Name = "saveRecordBtn";
            this.saveRecordBtn.Size = new System.Drawing.Size(99, 36);
            this.saveRecordBtn.TabIndex = 33;
            this.saveRecordBtn.Text = "Save Record";
            this.saveRecordBtn.UseVisualStyleBackColor = true;
            this.saveRecordBtn.Click += new System.EventHandler(this.SaveRecordBtn_Click);
            // 
            // returnToMainBtn
            // 
            this.returnToMainBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainBtn.Location = new System.Drawing.Point(324, 326);
            this.returnToMainBtn.Name = "returnToMainBtn";
            this.returnToMainBtn.Size = new System.Drawing.Size(99, 36);
            this.returnToMainBtn.TabIndex = 34;
            this.returnToMainBtn.Text = "Return";
            this.returnToMainBtn.UseVisualStyleBackColor = true;
            this.returnToMainBtn.Click += new System.EventHandler(this.ReturnToMainBtn_Click);
            // 
            // clearFieldsBtn
            // 
            this.clearFieldsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFieldsBtn.Location = new System.Drawing.Point(219, 326);
            this.clearFieldsBtn.Name = "clearFieldsBtn";
            this.clearFieldsBtn.Size = new System.Drawing.Size(99, 36);
            this.clearFieldsBtn.TabIndex = 35;
            this.clearFieldsBtn.Text = "Clear";
            this.clearFieldsBtn.UseVisualStyleBackColor = true;
            this.clearFieldsBtn.Click += new System.EventHandler(this.ClearFieldsBtn_Click);
            // 
            // PositionsCheckedBox
            // 
            this.PositionsCheckedBox.CheckOnClick = true;
            this.PositionsCheckedBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionsCheckedBox.FormattingEnabled = true;
            this.PositionsCheckedBox.Items.AddRange(new object[] {
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
            this.PositionsCheckedBox.Location = new System.Drawing.Point(71, 105);
            this.PositionsCheckedBox.Name = "PositionsCheckedBox";
            this.PositionsCheckedBox.Size = new System.Drawing.Size(133, 191);
            this.PositionsCheckedBox.TabIndex = 36;
            this.PositionsCheckedBox.SelectedIndexChanged += new System.EventHandler(this.PositionsCheckedLb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Make one choice";
            // 
            // formValidator
            // 
            this.formValidator.ContainerControl = this;
            // 
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PositionsCheckedBox);
            this.Controls.Add(this.clearFieldsBtn);
            this.Controls.Add(this.returnToMainBtn);
            this.Controls.Add(this.saveRecordBtn);
            this.Controls.Add(this.position);
            this.Controls.Add(this.cellNo);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.cellNumberLbl);
            this.Controls.Add(this.emailAddressLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.addNewRecordLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateEmployee";
            this.Text = "Add New Employee";
            ((System.ComponentModel.ISupportInitialize)(this.formValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewRecordLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label emailAddressLbl;
        private System.Windows.Forms.Label cellNumberLbl;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.Button saveRecordBtn;
        private System.Windows.Forms.Button returnToMainBtn;
        private System.Windows.Forms.Button clearFieldsBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox firstName;
        public System.Windows.Forms.TextBox lastName;
        public System.Windows.Forms.TextBox address;
        public System.Windows.Forms.TextBox email;
        public System.Windows.Forms.TextBox cellNo;
        public System.Windows.Forms.TextBox position;
        private System.Windows.Forms.ErrorProvider formValidator;
        public System.Windows.Forms.CheckedListBox PositionsCheckedBox;
    }
}