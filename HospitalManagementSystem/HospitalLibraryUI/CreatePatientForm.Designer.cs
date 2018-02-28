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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.ConsultingDoctor = new System.Windows.Forms.TextBox();
            this.Ward = new System.Windows.Forms.TextBox();
            this.RoomNo = new System.Windows.Forms.TextBox();
            this.BedNo = new System.Windows.Forms.TextBox();
            this.patientFNameLabel = new System.Windows.Forms.Label();
            this.patientLNameLabel = new System.Windows.Forms.Label();
            this.patientAddressLabel = new System.Windows.Forms.Label();
            this.patientGenderLabel = new System.Windows.Forms.Label();
            this.consDocLabel = new System.Windows.Forms.Label();
            this.wardLabel = new System.Windows.Forms.Label();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.bedNoLabel = new System.Windows.Forms.Label();
            this.hasHealthCardLabel = new System.Windows.Forms.Label();
            this.YesCheckBox = new System.Windows.Forms.CheckBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.savePatientBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.patientFormValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.healthCardLabel = new System.Windows.Forms.Label();
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
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(236, 72);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(234, 20);
            this.FirstName.TabIndex = 4;
            this.FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.FirstName_Validating);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(236, 98);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(234, 20);
            this.LastName.TabIndex = 5;
            this.LastName.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(236, 124);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(234, 20);
            this.Address.TabIndex = 6;
            this.Address.Validating += new System.ComponentModel.CancelEventHandler(this.Address_Validating);
            // 
            // ConsultingDoctor
            // 
            this.ConsultingDoctor.Location = new System.Drawing.Point(236, 176);
            this.ConsultingDoctor.Multiline = true;
            this.ConsultingDoctor.Name = "ConsultingDoctor";
            this.ConsultingDoctor.Size = new System.Drawing.Size(234, 20);
            this.ConsultingDoctor.TabIndex = 8;
            this.ConsultingDoctor.Validating += new System.ComponentModel.CancelEventHandler(this.ConsultingDoctor_Validating);
            // 
            // Ward
            // 
            this.Ward.Location = new System.Drawing.Point(236, 202);
            this.Ward.Multiline = true;
            this.Ward.Name = "Ward";
            this.Ward.Size = new System.Drawing.Size(234, 20);
            this.Ward.TabIndex = 9;
            this.Ward.Validating += new System.ComponentModel.CancelEventHandler(this.Ward_Validating);
            // 
            // RoomNo
            // 
            this.RoomNo.Location = new System.Drawing.Point(236, 228);
            this.RoomNo.Multiline = true;
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Size = new System.Drawing.Size(60, 20);
            this.RoomNo.TabIndex = 10;
            this.RoomNo.Validating += new System.ComponentModel.CancelEventHandler(this.RoomNo_Validating);
            // 
            // BedNo
            // 
            this.BedNo.Location = new System.Drawing.Point(236, 254);
            this.BedNo.Multiline = true;
            this.BedNo.Name = "BedNo";
            this.BedNo.Size = new System.Drawing.Size(60, 20);
            this.BedNo.TabIndex = 11;
            this.BedNo.Validating += new System.ComponentModel.CancelEventHandler(this.BedNo_Validating);
            // 
            // patientFNameLabel
            // 
            this.patientFNameLabel.AutoSize = true;
            this.patientFNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientFNameLabel.Location = new System.Drawing.Point(128, 75);
            this.patientFNameLabel.Name = "patientFNameLabel";
            this.patientFNameLabel.Size = new System.Drawing.Size(61, 13);
            this.patientFNameLabel.TabIndex = 14;
            this.patientFNameLabel.Text = "First Name";
            // 
            // patientLNameLabel
            // 
            this.patientLNameLabel.AutoSize = true;
            this.patientLNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLNameLabel.Location = new System.Drawing.Point(128, 101);
            this.patientLNameLabel.Name = "patientLNameLabel";
            this.patientLNameLabel.Size = new System.Drawing.Size(59, 13);
            this.patientLNameLabel.TabIndex = 15;
            this.patientLNameLabel.Text = "Last Name";
            // 
            // patientAddressLabel
            // 
            this.patientAddressLabel.AutoSize = true;
            this.patientAddressLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAddressLabel.Location = new System.Drawing.Point(128, 127);
            this.patientAddressLabel.Name = "patientAddressLabel";
            this.patientAddressLabel.Size = new System.Drawing.Size(81, 13);
            this.patientAddressLabel.TabIndex = 16;
            this.patientAddressLabel.Text = "Home Address";
            // 
            // patientGenderLabel
            // 
            this.patientGenderLabel.AutoSize = true;
            this.patientGenderLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientGenderLabel.Location = new System.Drawing.Point(128, 153);
            this.patientGenderLabel.Name = "patientGenderLabel";
            this.patientGenderLabel.Size = new System.Drawing.Size(45, 13);
            this.patientGenderLabel.TabIndex = 17;
            this.patientGenderLabel.Text = "Gender";
            // 
            // consDocLabel
            // 
            this.consDocLabel.AutoSize = true;
            this.consDocLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consDocLabel.Location = new System.Drawing.Point(128, 179);
            this.consDocLabel.Name = "consDocLabel";
            this.consDocLabel.Size = new System.Drawing.Size(102, 13);
            this.consDocLabel.TabIndex = 18;
            this.consDocLabel.Text = "Consulting Doctor";
            // 
            // wardLabel
            // 
            this.wardLabel.AutoSize = true;
            this.wardLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wardLabel.Location = new System.Drawing.Point(128, 205);
            this.wardLabel.Name = "wardLabel";
            this.wardLabel.Size = new System.Drawing.Size(35, 13);
            this.wardLabel.TabIndex = 19;
            this.wardLabel.Text = "Ward";
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoLabel.Location = new System.Drawing.Point(128, 231);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(58, 13);
            this.roomNoLabel.TabIndex = 20;
            this.roomNoLabel.Text = "Room No.";
            // 
            // bedNoLabel
            // 
            this.bedNoLabel.AutoSize = true;
            this.bedNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedNoLabel.Location = new System.Drawing.Point(128, 257);
            this.bedNoLabel.Name = "bedNoLabel";
            this.bedNoLabel.Size = new System.Drawing.Size(48, 13);
            this.bedNoLabel.TabIndex = 21;
            this.bedNoLabel.Text = "Bed No.";
            // 
            // hasHealthCardLabel
            // 
            this.hasHealthCardLabel.AutoSize = true;
            this.hasHealthCardLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasHealthCardLabel.Location = new System.Drawing.Point(128, 283);
            this.hasHealthCardLabel.Name = "hasHealthCardLabel";
            this.hasHealthCardLabel.Size = new System.Drawing.Size(90, 13);
            this.hasHealthCardLabel.TabIndex = 22;
            this.hasHealthCardLabel.Text = "Has Health Card";
            // 
            // YesCheckBox
            // 
            this.YesCheckBox.AutoSize = true;
            this.YesCheckBox.Location = new System.Drawing.Point(236, 282);
            this.YesCheckBox.Name = "YesCheckBox";
            this.YesCheckBox.Size = new System.Drawing.Size(41, 17);
            this.YesCheckBox.TabIndex = 24;
            this.YesCheckBox.Text = "Yes";
            this.YesCheckBox.UseVisualStyleBackColor = true;
            this.YesCheckBox.CheckedChanged += new System.EventHandler(this.YesCheckBox_CheckedChanged);
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(236, 149);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 21);
            this.GenderComboBox.TabIndex = 26;
            this.GenderComboBox.SelectedIndexChanged += new System.EventHandler(this.GenderComboBox_SelectedIndexChanged);
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
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(381, 315);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(99, 35);
            this.ReturnBtn.TabIndex = 28;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
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
            // healthCardLabel
            // 
            this.healthCardLabel.AutoSize = true;
            this.healthCardLabel.Location = new System.Drawing.Point(283, 283);
            this.healthCardLabel.Name = "healthCardLabel";
            this.healthCardLabel.Size = new System.Drawing.Size(11, 13);
            this.healthCardLabel.TabIndex = 30;
            this.healthCardLabel.Text = "-";
            // 
            // CreatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 366);
            this.Controls.Add(this.healthCardLabel);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.savePatientBtn);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.YesCheckBox);
            this.Controls.Add(this.hasHealthCardLabel);
            this.Controls.Add(this.bedNoLabel);
            this.Controls.Add(this.roomNoLabel);
            this.Controls.Add(this.wardLabel);
            this.Controls.Add(this.consDocLabel);
            this.Controls.Add(this.patientGenderLabel);
            this.Controls.Add(this.patientAddressLabel);
            this.Controls.Add(this.patientLNameLabel);
            this.Controls.Add(this.patientFNameLabel);
            this.Controls.Add(this.BedNo);
            this.Controls.Add(this.RoomNo);
            this.Controls.Add(this.Ward);
            this.Controls.Add(this.ConsultingDoctor);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.addNewPatientLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePatient";
            this.Text = "Add New Patient";
            ((System.ComponentModel.ISupportInitialize)(this.patientFormValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewPatientLbl;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox ConsultingDoctor;
        private System.Windows.Forms.TextBox Ward;
        private System.Windows.Forms.TextBox RoomNo;
        private System.Windows.Forms.TextBox BedNo;
        private System.Windows.Forms.Label patientFNameLabel;
        private System.Windows.Forms.Label patientLNameLabel;
        private System.Windows.Forms.Label patientAddressLabel;
        private System.Windows.Forms.Label patientGenderLabel;
        private System.Windows.Forms.Label consDocLabel;
        private System.Windows.Forms.Label wardLabel;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.Label bedNoLabel;
        private System.Windows.Forms.Label hasHealthCardLabel;
        private System.Windows.Forms.CheckBox YesCheckBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Button savePatientBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.ErrorProvider patientFormValidator;
        private System.Windows.Forms.Label healthCardLabel;
    }
}