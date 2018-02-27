namespace HospitalSystemUI
{
    partial class CreatePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePatient));
            this.addNewPatientLbl = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.consultingDoctor = new System.Windows.Forms.TextBox();
            this.ward = new System.Windows.Forms.TextBox();
            this.roomNo = new System.Windows.Forms.TextBox();
            this.bedNo = new System.Windows.Forms.TextBox();
            this.patientFNameLbl = new System.Windows.Forms.Label();
            this.patientLNameLbl = new System.Windows.Forms.Label();
            this.patientAddressLbl = new System.Windows.Forms.Label();
            this.patientGenderLbl = new System.Windows.Forms.Label();
            this.consDocLbl = new System.Windows.Forms.Label();
            this.wardLbl = new System.Windows.Forms.Label();
            this.roomNoLbl = new System.Windows.Forms.Label();
            this.bedNoLbl = new System.Windows.Forms.Label();
            this.hasHealthCardLbl = new System.Windows.Forms.Label();
            this.yesCheckBox = new System.Windows.Forms.CheckBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.savePatientBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.patientFormValidator = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patientFormValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewPatientLbl
            // 
            this.addNewPatientLbl.AutoSize = true;
            this.addNewPatientLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPatientLbl.Location = new System.Drawing.Point(206, 11);
            this.addNewPatientLbl.Name = "addNewPatientLbl";
            this.addNewPatientLbl.Size = new System.Drawing.Size(186, 45);
            this.addNewPatientLbl.TabIndex = 3;
            this.addNewPatientLbl.Text = "Add Patient";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(236, 72);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(234, 20);
            this.firstName.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(236, 98);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(234, 20);
            this.lastName.TabIndex = 5;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(236, 124);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(234, 20);
            this.address.TabIndex = 6;
            // 
            // consultingDoctor
            // 
            this.consultingDoctor.Location = new System.Drawing.Point(236, 176);
            this.consultingDoctor.Multiline = true;
            this.consultingDoctor.Name = "consultingDoctor";
            this.consultingDoctor.Size = new System.Drawing.Size(234, 20);
            this.consultingDoctor.TabIndex = 8;
            // 
            // ward
            // 
            this.ward.Location = new System.Drawing.Point(236, 202);
            this.ward.Multiline = true;
            this.ward.Name = "ward";
            this.ward.Size = new System.Drawing.Size(234, 20);
            this.ward.TabIndex = 9;
            // 
            // roomNo
            // 
            this.roomNo.Location = new System.Drawing.Point(236, 228);
            this.roomNo.Multiline = true;
            this.roomNo.Name = "roomNo";
            this.roomNo.Size = new System.Drawing.Size(60, 20);
            this.roomNo.TabIndex = 10;
            // 
            // bedNo
            // 
            this.bedNo.Location = new System.Drawing.Point(236, 254);
            this.bedNo.Multiline = true;
            this.bedNo.Name = "bedNo";
            this.bedNo.Size = new System.Drawing.Size(60, 20);
            this.bedNo.TabIndex = 11;
            // 
            // patientFNameLbl
            // 
            this.patientFNameLbl.AutoSize = true;
            this.patientFNameLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFNameLbl.Location = new System.Drawing.Point(128, 75);
            this.patientFNameLbl.Name = "patientFNameLbl";
            this.patientFNameLbl.Size = new System.Drawing.Size(61, 13);
            this.patientFNameLbl.TabIndex = 14;
            this.patientFNameLbl.Text = "First Name";
            // 
            // patientLNameLbl
            // 
            this.patientLNameLbl.AutoSize = true;
            this.patientLNameLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLNameLbl.Location = new System.Drawing.Point(128, 101);
            this.patientLNameLbl.Name = "patientLNameLbl";
            this.patientLNameLbl.Size = new System.Drawing.Size(59, 13);
            this.patientLNameLbl.TabIndex = 15;
            this.patientLNameLbl.Text = "Last Name";
            // 
            // patientAddressLbl
            // 
            this.patientAddressLbl.AutoSize = true;
            this.patientAddressLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAddressLbl.Location = new System.Drawing.Point(128, 127);
            this.patientAddressLbl.Name = "patientAddressLbl";
            this.patientAddressLbl.Size = new System.Drawing.Size(81, 13);
            this.patientAddressLbl.TabIndex = 16;
            this.patientAddressLbl.Text = "Home Address";
            // 
            // patientGenderLbl
            // 
            this.patientGenderLbl.AutoSize = true;
            this.patientGenderLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientGenderLbl.Location = new System.Drawing.Point(128, 153);
            this.patientGenderLbl.Name = "patientGenderLbl";
            this.patientGenderLbl.Size = new System.Drawing.Size(45, 13);
            this.patientGenderLbl.TabIndex = 17;
            this.patientGenderLbl.Text = "Gender";
            // 
            // consDocLbl
            // 
            this.consDocLbl.AutoSize = true;
            this.consDocLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consDocLbl.Location = new System.Drawing.Point(128, 179);
            this.consDocLbl.Name = "consDocLbl";
            this.consDocLbl.Size = new System.Drawing.Size(102, 13);
            this.consDocLbl.TabIndex = 18;
            this.consDocLbl.Text = "Consulting Doctor";
            // 
            // wardLbl
            // 
            this.wardLbl.AutoSize = true;
            this.wardLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wardLbl.Location = new System.Drawing.Point(128, 205);
            this.wardLbl.Name = "wardLbl";
            this.wardLbl.Size = new System.Drawing.Size(35, 13);
            this.wardLbl.TabIndex = 19;
            this.wardLbl.Text = "Ward";
            // 
            // roomNoLbl
            // 
            this.roomNoLbl.AutoSize = true;
            this.roomNoLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoLbl.Location = new System.Drawing.Point(128, 231);
            this.roomNoLbl.Name = "roomNoLbl";
            this.roomNoLbl.Size = new System.Drawing.Size(58, 13);
            this.roomNoLbl.TabIndex = 20;
            this.roomNoLbl.Text = "Room No.";
            // 
            // bedNoLbl
            // 
            this.bedNoLbl.AutoSize = true;
            this.bedNoLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedNoLbl.Location = new System.Drawing.Point(128, 257);
            this.bedNoLbl.Name = "bedNoLbl";
            this.bedNoLbl.Size = new System.Drawing.Size(48, 13);
            this.bedNoLbl.TabIndex = 21;
            this.bedNoLbl.Text = "Bed No.";
            // 
            // hasHealthCardLbl
            // 
            this.hasHealthCardLbl.AutoSize = true;
            this.hasHealthCardLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasHealthCardLbl.Location = new System.Drawing.Point(128, 283);
            this.hasHealthCardLbl.Name = "hasHealthCardLbl";
            this.hasHealthCardLbl.Size = new System.Drawing.Size(90, 13);
            this.hasHealthCardLbl.TabIndex = 22;
            this.hasHealthCardLbl.Text = "Has Health Card";
            // 
            // yesCheckBox
            // 
            this.yesCheckBox.AutoSize = true;
            this.yesCheckBox.Location = new System.Drawing.Point(236, 282);
            this.yesCheckBox.Name = "yesCheckBox";
            this.yesCheckBox.Size = new System.Drawing.Size(41, 17);
            this.yesCheckBox.TabIndex = 24;
            this.yesCheckBox.Text = "Yes";
            this.yesCheckBox.UseVisualStyleBackColor = true;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(236, 149);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 21);
            this.genderComboBox.TabIndex = 26;
            // 
            // savePatientBtn
            // 
            this.savePatientBtn.Location = new System.Drawing.Point(141, 315);
            this.savePatientBtn.Name = "savePatientBtn";
            this.savePatientBtn.Size = new System.Drawing.Size(99, 35);
            this.savePatientBtn.TabIndex = 27;
            this.savePatientBtn.Text = "Save";
            this.savePatientBtn.UseVisualStyleBackColor = true;
            this.savePatientBtn.Click += new System.EventHandler(this.SavePatientBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(381, 315);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(99, 35);
            this.returnBtn.TabIndex = 28;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(258, 315);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(99, 35);
            this.ClearAll.TabIndex = 29;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // patientFormValidator
            // 
            this.patientFormValidator.ContainerControl = this;
            // 
            // CreatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 366);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.savePatientBtn);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.yesCheckBox);
            this.Controls.Add(this.hasHealthCardLbl);
            this.Controls.Add(this.bedNoLbl);
            this.Controls.Add(this.roomNoLbl);
            this.Controls.Add(this.wardLbl);
            this.Controls.Add(this.consDocLbl);
            this.Controls.Add(this.patientGenderLbl);
            this.Controls.Add(this.patientAddressLbl);
            this.Controls.Add(this.patientLNameLbl);
            this.Controls.Add(this.patientFNameLbl);
            this.Controls.Add(this.bedNo);
            this.Controls.Add(this.roomNo);
            this.Controls.Add(this.ward);
            this.Controls.Add(this.consultingDoctor);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.addNewPatientLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePatient";
            this.Text = "Add New Patient";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.CreatePatient_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.patientFormValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewPatientLbl;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox consultingDoctor;
        private System.Windows.Forms.TextBox ward;
        private System.Windows.Forms.TextBox roomNo;
        private System.Windows.Forms.TextBox bedNo;
        private System.Windows.Forms.Label patientFNameLbl;
        private System.Windows.Forms.Label patientLNameLbl;
        private System.Windows.Forms.Label patientAddressLbl;
        private System.Windows.Forms.Label patientGenderLbl;
        private System.Windows.Forms.Label consDocLbl;
        private System.Windows.Forms.Label wardLbl;
        private System.Windows.Forms.Label roomNoLbl;
        private System.Windows.Forms.Label bedNoLbl;
        private System.Windows.Forms.Label hasHealthCardLbl;
        private System.Windows.Forms.CheckBox yesCheckBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Button savePatientBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.ErrorProvider patientFormValidator;
    }
}