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
            this.showPercentage = new System.Windows.Forms.Label();
            this.showBytesReceived = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.showTransferRate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMain
            // 
            this.LabelMain.AutoSize = true;
            this.LabelMain.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMain.Location = new System.Drawing.Point(178, 12);
            this.LabelMain.Name = "LabelMain";
            this.LabelMain.Size = new System.Drawing.Size(162, 30);
            this.LabelMain.TabIndex = 1;
            this.LabelMain.Text = "File Downloader";
            // 
            // UrlLbl
            // 
            this.UrlLbl.AutoSize = true;
            this.UrlLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UrlLbl.Location = new System.Drawing.Point(110, 163);
            this.UrlLbl.Name = "UrlLbl";
            this.UrlLbl.Size = new System.Drawing.Size(42, 21);
            this.UrlLbl.TabIndex = 2;
            this.UrlLbl.Text = "URL:";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DownloadButton.Location = new System.Drawing.Point(58, 246);
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
            this.textUrl.Location = new System.Drawing.Point(175, 152);
            this.textUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUrl.Multiline = true;
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(308, 32);
            this.textUrl.TabIndex = 6;
            this.textUrl.Validating += new System.ComponentModel.CancelEventHandler(this.textUrl_Validating);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(175, 114);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(306, 30);
            this.textPassword.TabIndex = 10;
            this.textPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textPassword_Validating);
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(175, 80);
            this.textUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUserName.Multiline = true;
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(306, 30);
            this.textUserName.TabIndex = 11;
            this.textUserName.Validating += new System.ComponentModel.CancelEventHandler(this.textUserName_Validating);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(53, 80);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(116, 30);
            this.labelUserName.TabIndex = 12;
            this.labelUserName.Text = "User Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(53, 114);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(99, 30);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(58, 205);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(425, 29);
            this.progressBar.TabIndex = 19;
            // 
            // showPercentage
            // 
            this.showPercentage.Location = new System.Drawing.Point(331, 237);
            this.showPercentage.Name = "showPercentage";
            this.showPercentage.Size = new System.Drawing.Size(152, 25);
            this.showPercentage.TabIndex = 20;
            this.showPercentage.Text = "0%";
            this.showPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // showBytesReceived
            // 
            this.showBytesReceived.Location = new System.Drawing.Point(336, 262);
            this.showBytesReceived.Name = "showBytesReceived";
            this.showBytesReceived.Size = new System.Drawing.Size(147, 25);
            this.showBytesReceived.TabIndex = 21;
            this.showBytesReceived.Text = "Bytes Received";
            this.showBytesReceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // showTransferRate
            // 
            this.showTransferRate.Location = new System.Drawing.Point(336, 287);
            this.showTransferRate.Name = "showTransferRate";
            this.showTransferRate.Size = new System.Drawing.Size(147, 25);
            this.showTransferRate.TabIndex = 22;
            this.showTransferRate.Text = "Transfer Rate";
            this.showTransferRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FileDownloaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 326);
            this.Controls.Add(this.showTransferRate);
            this.Controls.Add(this.showBytesReceived);
            this.Controls.Add(this.showPercentage);
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
        private System.Windows.Forms.Label showPercentage;
        private System.Windows.Forms.Label showBytesReceived;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label showTransferRate;
    }
}

