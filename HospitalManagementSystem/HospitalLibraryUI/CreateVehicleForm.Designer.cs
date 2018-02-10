namespace HospitalSystemUI
{
    partial class CreateVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateVehicle));
            this.createNewLbl = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.nextServiceLbl = new System.Windows.Forms.Label();
            this.lastServiceLbl = new System.Windows.Forms.Label();
            this.licencePlateLbl = new System.Windows.Forms.Label();
            this.vehicleMakeLbl = new System.Windows.Forms.Label();
            this.saveVehicleBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createNewLbl
            // 
            this.createNewLbl.AutoSize = true;
            this.createNewLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewLbl.Location = new System.Drawing.Point(162, 9);
            this.createNewLbl.Name = "createNewLbl";
            this.createNewLbl.Size = new System.Drawing.Size(222, 45);
            this.createNewLbl.TabIndex = 2;
            this.createNewLbl.Text = "Create Vehicle";
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(227, 179);
            this.emailTb.Multiline = true;
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(157, 20);
            this.emailTb.TabIndex = 34;
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(227, 153);
            this.addressTb.Multiline = true;
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(157, 20);
            this.addressTb.TabIndex = 33;
            // 
            // lastNameTb
            // 
            this.lastNameTb.Location = new System.Drawing.Point(227, 127);
            this.lastNameTb.Multiline = true;
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(157, 20);
            this.lastNameTb.TabIndex = 32;
            // 
            // firstNameTb
            // 
            this.firstNameTb.Location = new System.Drawing.Point(227, 99);
            this.firstNameTb.Multiline = true;
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(157, 20);
            this.firstNameTb.TabIndex = 31;
            // 
            // nextServiceLbl
            // 
            this.nextServiceLbl.AutoSize = true;
            this.nextServiceLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextServiceLbl.Location = new System.Drawing.Point(149, 179);
            this.nextServiceLbl.Name = "nextServiceLbl";
            this.nextServiceLbl.Size = new System.Drawing.Size(70, 13);
            this.nextServiceLbl.TabIndex = 29;
            this.nextServiceLbl.Text = "Next Service";
            // 
            // lastServiceLbl
            // 
            this.lastServiceLbl.AutoSize = true;
            this.lastServiceLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastServiceLbl.Location = new System.Drawing.Point(149, 153);
            this.lastServiceLbl.Name = "lastServiceLbl";
            this.lastServiceLbl.Size = new System.Drawing.Size(66, 13);
            this.lastServiceLbl.TabIndex = 28;
            this.lastServiceLbl.Text = "Last Service";
            // 
            // licencePlateLbl
            // 
            this.licencePlateLbl.AutoSize = true;
            this.licencePlateLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licencePlateLbl.Location = new System.Drawing.Point(149, 127);
            this.licencePlateLbl.Name = "licencePlateLbl";
            this.licencePlateLbl.Size = new System.Drawing.Size(71, 13);
            this.licencePlateLbl.TabIndex = 27;
            this.licencePlateLbl.Text = "Licence Plate";
            // 
            // vehicleMakeLbl
            // 
            this.vehicleMakeLbl.AutoSize = true;
            this.vehicleMakeLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleMakeLbl.Location = new System.Drawing.Point(149, 99);
            this.vehicleMakeLbl.Name = "vehicleMakeLbl";
            this.vehicleMakeLbl.Size = new System.Drawing.Size(35, 13);
            this.vehicleMakeLbl.TabIndex = 26;
            this.vehicleMakeLbl.Text = "Make";
            // 
            // saveVehicleBtn
            // 
            this.saveVehicleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveVehicleBtn.Location = new System.Drawing.Point(227, 218);
            this.saveVehicleBtn.Name = "saveVehicleBtn";
            this.saveVehicleBtn.Size = new System.Drawing.Size(91, 40);
            this.saveVehicleBtn.TabIndex = 35;
            this.saveVehicleBtn.Text = "Save Vehicle";
            this.saveVehicleBtn.UseVisualStyleBackColor = true;
            this.saveVehicleBtn.Click += new System.EventHandler(this.SaveVehicleBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.Location = new System.Drawing.Point(438, 274);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(91, 40);
            this.returnBtn.TabIndex = 36;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CreateVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 326);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.saveVehicleBtn);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.addressTb);
            this.Controls.Add(this.lastNameTb);
            this.Controls.Add(this.firstNameTb);
            this.Controls.Add(this.nextServiceLbl);
            this.Controls.Add(this.lastServiceLbl);
            this.Controls.Add(this.licencePlateLbl);
            this.Controls.Add(this.vehicleMakeLbl);
            this.Controls.Add(this.createNewLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateVehicle";
            this.Text = "Create Vehicle";
            this.Load += new System.EventHandler(this.CreateVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createNewLbl;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.Label nextServiceLbl;
        private System.Windows.Forms.Label lastServiceLbl;
        private System.Windows.Forms.Label licencePlateLbl;
        private System.Windows.Forms.Label vehicleMakeLbl;
        private System.Windows.Forms.Button saveVehicleBtn;
        private System.Windows.Forms.Button returnBtn;
    }
}