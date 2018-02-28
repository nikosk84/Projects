namespace HospitalSystemUI
{
    partial class CreatePatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePatientForm));
            this.AddPatientTitle = new System.Windows.Forms.Label();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.ConsultingDoctorText = new System.Windows.Forms.TextBox();
            this.WardText = new System.Windows.Forms.TextBox();
            this.RoomNoText = new System.Windows.Forms.TextBox();
            this.BedNoText = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.ConsultingDocLabel = new System.Windows.Forms.Label();
            this.WardLabel = new System.Windows.Forms.Label();
            this.RoomNoLabel = new System.Windows.Forms.Label();
            this.BedNoLabel = new System.Windows.Forms.Label();
            this.HasHealthCardLabel = new System.Windows.Forms.Label();
            this.YesCheckBox = new System.Windows.Forms.CheckBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.SavePatientButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.PatientFormValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.HealthCardLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PatientFormValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPatientTitle
            // 
            this.AddPatientTitle.AutoSize = true;
            this.AddPatientTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientTitle.Location = new System.Drawing.Point(206, 11);
            this.AddPatientTitle.Name = "AddPatientTitle";
            this.AddPatientTitle.Size = new System.Drawing.Size(186, 45);
            this.AddPatientTitle.TabIndex = 3;
            this.AddPatientTitle.Text = "Add Patient";
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(236, 72);
            this.FirstNameText.Multiline = true;
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(234, 20);
            this.FirstNameText.TabIndex = 4;
            this.FirstNameText.Validating += new System.ComponentModel.CancelEventHandler(this.FirstName_Validating);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(236, 98);
            this.LastNameText.Multiline = true;
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(234, 20);
            this.LastNameText.TabIndex = 5;
            this.LastNameText.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(236, 124);
            this.AddressText.Multiline = true;
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(234, 20);
            this.AddressText.TabIndex = 6;
            this.AddressText.Validating += new System.ComponentModel.CancelEventHandler(this.Address_Validating);
            // 
            // ConsultingDoctorText
            // 
            this.ConsultingDoctorText.Location = new System.Drawing.Point(236, 176);
            this.ConsultingDoctorText.Multiline = true;
            this.ConsultingDoctorText.Name = "ConsultingDoctorText";
            this.ConsultingDoctorText.Size = new System.Drawing.Size(234, 20);
            this.ConsultingDoctorText.TabIndex = 8;
            this.ConsultingDoctorText.Validating += new System.ComponentModel.CancelEventHandler(this.ConsultingDoctor_Validating);
            // 
            // WardText
            // 
            this.WardText.Location = new System.Drawing.Point(236, 202);
            this.WardText.Multiline = true;
            this.WardText.Name = "WardText";
            this.WardText.Size = new System.Drawing.Size(234, 20);
            this.WardText.TabIndex = 9;
            this.WardText.Validating += new System.ComponentModel.CancelEventHandler(this.Ward_Validating);
            // 
            // RoomNoText
            // 
            this.RoomNoText.Location = new System.Drawing.Point(236, 228);
            this.RoomNoText.Multiline = true;
            this.RoomNoText.Name = "RoomNoText";
            this.RoomNoText.Size = new System.Drawing.Size(60, 20);
            this.RoomNoText.TabIndex = 10;
            this.RoomNoText.Validating += new System.ComponentModel.CancelEventHandler(this.RoomNo_Validating);
            // 
            // BedNoText
            // 
            this.BedNoText.Location = new System.Drawing.Point(236, 254);
            this.BedNoText.Multiline = true;
            this.BedNoText.Name = "BedNoText";
            this.BedNoText.Size = new System.Drawing.Size(60, 20);
            this.BedNoText.TabIndex = 11;
            this.BedNoText.Validating += new System.ComponentModel.CancelEventHandler(this.BedNo_Validating);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(128, 75);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(61, 13);
            this.FirstNameLabel.TabIndex = 14;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(128, 101);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.LastNameLabel.TabIndex = 15;
            this.LastNameLabel.Text = "Last Name";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(128, 127);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(81, 13);
            this.AddressLabel.TabIndex = 16;
            this.AddressLabel.Text = "Home Address";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(128, 153);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(45, 13);
            this.GenderLabel.TabIndex = 17;
            this.GenderLabel.Text = "Gender";
            // 
            // ConsultingDocLabel
            // 
            this.ConsultingDocLabel.AutoSize = true;
            this.ConsultingDocLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultingDocLabel.Location = new System.Drawing.Point(128, 179);
            this.ConsultingDocLabel.Name = "ConsultingDocLabel";
            this.ConsultingDocLabel.Size = new System.Drawing.Size(102, 13);
            this.ConsultingDocLabel.TabIndex = 18;
            this.ConsultingDocLabel.Text = "Consulting Doctor";
            // 
            // WardLabel
            // 
            this.WardLabel.AutoSize = true;
            this.WardLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WardLabel.Location = new System.Drawing.Point(128, 205);
            this.WardLabel.Name = "WardLabel";
            this.WardLabel.Size = new System.Drawing.Size(35, 13);
            this.WardLabel.TabIndex = 19;
            this.WardLabel.Text = "Ward";
            // 
            // RoomNoLabel
            // 
            this.RoomNoLabel.AutoSize = true;
            this.RoomNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoLabel.Location = new System.Drawing.Point(128, 231);
            this.RoomNoLabel.Name = "RoomNoLabel";
            this.RoomNoLabel.Size = new System.Drawing.Size(58, 13);
            this.RoomNoLabel.TabIndex = 20;
            this.RoomNoLabel.Text = "Room No.";
            // 
            // BedNoLabel
            // 
            this.BedNoLabel.AutoSize = true;
            this.BedNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedNoLabel.Location = new System.Drawing.Point(128, 257);
            this.BedNoLabel.Name = "BedNoLabel";
            this.BedNoLabel.Size = new System.Drawing.Size(48, 13);
            this.BedNoLabel.TabIndex = 21;
            this.BedNoLabel.Text = "Bed No.";
            // 
            // HasHealthCardLabel
            // 
            this.HasHealthCardLabel.AutoSize = true;
            this.HasHealthCardLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HasHealthCardLabel.Location = new System.Drawing.Point(128, 283);
            this.HasHealthCardLabel.Name = "HasHealthCardLabel";
            this.HasHealthCardLabel.Size = new System.Drawing.Size(90, 13);
            this.HasHealthCardLabel.TabIndex = 22;
            this.HasHealthCardLabel.Text = "Has Health Card";
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
            // SavePatientButton
            // 
            this.SavePatientButton.Location = new System.Drawing.Point(153, 315);
            this.SavePatientButton.Name = "SavePatientButton";
            this.SavePatientButton.Size = new System.Drawing.Size(99, 35);
            this.SavePatientButton.TabIndex = 27;
            this.SavePatientButton.Text = "Save";
            this.SavePatientButton.UseVisualStyleBackColor = true;
            this.SavePatientButton.Click += new System.EventHandler(this.SavePatientBtn_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(363, 315);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(99, 35);
            this.ReturnButton.TabIndex = 28;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(258, 315);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(99, 35);
            this.ClearAllButton.TabIndex = 29;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // PatientFormValidator
            // 
            this.PatientFormValidator.ContainerControl = this;
            // 
            // HealthCardLabel
            // 
            this.HealthCardLabel.AutoSize = true;
            this.HealthCardLabel.Location = new System.Drawing.Point(283, 283);
            this.HealthCardLabel.Name = "HealthCardLabel";
            this.HealthCardLabel.Size = new System.Drawing.Size(11, 13);
            this.HealthCardLabel.TabIndex = 30;
            this.HealthCardLabel.Text = "-";
            // 
            // CreatePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 366);
            this.Controls.Add(this.HealthCardLabel);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SavePatientButton);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.YesCheckBox);
            this.Controls.Add(this.HasHealthCardLabel);
            this.Controls.Add(this.BedNoLabel);
            this.Controls.Add(this.RoomNoLabel);
            this.Controls.Add(this.WardLabel);
            this.Controls.Add(this.ConsultingDocLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.BedNoText);
            this.Controls.Add(this.RoomNoText);
            this.Controls.Add(this.WardText);
            this.Controls.Add(this.ConsultingDoctorText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.AddPatientTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePatientForm";
            this.Text = "Add New Patient";
            ((System.ComponentModel.ISupportInitialize)(this.PatientFormValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPatientTitle;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox ConsultingDoctorText;
        private System.Windows.Forms.TextBox WardText;
        private System.Windows.Forms.TextBox RoomNoText;
        private System.Windows.Forms.TextBox BedNoText;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label ConsultingDocLabel;
        private System.Windows.Forms.Label WardLabel;
        private System.Windows.Forms.Label RoomNoLabel;
        private System.Windows.Forms.Label BedNoLabel;
        private System.Windows.Forms.Label HasHealthCardLabel;
        private System.Windows.Forms.CheckBox YesCheckBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Button SavePatientButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.ErrorProvider PatientFormValidator;
        private System.Windows.Forms.Label HealthCardLabel;
    }
}