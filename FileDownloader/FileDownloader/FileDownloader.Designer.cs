namespace FileDownloader
{
    partial class FileDownloaderForm
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
            this.LabelMain = new System.Windows.Forms.Label();
            this.UrlLbl = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.useCredsCheck = new System.Windows.Forms.CheckBox();
            this.CancelDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMain.Location = new System.Drawing.Point(250, 12);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(162, 30);
            this.LabelMain.TabIndex = 1;
            this.LabelMain.Text = "File Downloader";
            // 
            // UrlLbl
            // 
            this.UrlLbl.AutoSize = true;
            this.UrlLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UrlLbl.Location = new System.Drawing.Point(177, 172);
            this.UrlLbl.Name = "UrlLbl";
            this.UrlLbl.Size = new System.Drawing.Size(42, 21);
            this.UrlLbl.TabIndex = 2;
            this.UrlLbl.Text = "URL:";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DownloadButton.Location = new System.Drawing.Point(119, 236);
            this.DownloadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(119, 41);
            this.DownloadButton.TabIndex = 4;
            this.DownloadButton.Text = "&Download File";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(238, 161);
            this.textUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUrl.Multiline = true;
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(308, 32);
            this.textUrl.TabIndex = 6;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(238, 123);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(306, 30);
            this.textPassword.TabIndex = 10;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(238, 89);
            this.textUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUserName.Multiline = true;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(306, 30);
            this.textUserName.TabIndex = 11;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(116, 89);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(116, 30);
            this.labelUserName.TabIndex = 12;
            this.labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(120, 123);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(99, 30);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(119, 200);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(427, 29);
            this.progressBar.TabIndex = 19;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // useCredsCheck
            // 
            this.useCredsCheck.AutoSize = true;
            this.useCredsCheck.Location = new System.Drawing.Point(238, 61);
            this.useCredsCheck.Name = "useCredsCheck";
            this.useCredsCheck.Size = new System.Drawing.Size(118, 21);
            this.useCredsCheck.TabIndex = 20;
            this.useCredsCheck.Text = "Use Credentials";
            this.useCredsCheck.UseVisualStyleBackColor = true;
            this.useCredsCheck.CheckedChanged += new System.EventHandler(this.useCredsCheck_CheckedChanged);
            // 
            // CancelDownload
            // 
            this.CancelDownload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CancelDownload.Location = new System.Drawing.Point(427, 236);
            this.CancelDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelDownload.Name = "CancelDownload";
            this.CancelDownload.Size = new System.Drawing.Size(119, 41);
            this.CancelDownload.TabIndex = 21;
            this.CancelDownload.Text = "&Cancel";
            this.CancelDownload.UseVisualStyleBackColor = true;
            this.CancelDownload.Click += new System.EventHandler(this.CancelDownload_Click);
            // 
            // FileDownloaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 298);
            this.Controls.Add(this.CancelDownload);
            this.Controls.Add(this.useCredsCheck);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.UrlLbl);
            this.Controls.Add(this.LabelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FileDownloaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.Label UrlLbl;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox useCredsCheck;
        private System.Windows.Forms.Button CancelDownload;
    }
}

