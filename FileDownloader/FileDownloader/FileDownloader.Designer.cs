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
            this.LabelMain = new System.Windows.Forms.Label();
            this.UrlLbl = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.showDownloadedPercent = new System.Windows.Forms.Label();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.showTransferRate = new System.Windows.Forms.Label();
            this.showRemainingTime = new System.Windows.Forms.Label();
            this.showDownloadedBytes = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelDownload = new System.Windows.Forms.Label();
            this.labelBytesDownloaded = new System.Windows.Forms.Label();
            this.labelTransferRate = new System.Windows.Forms.Label();
            this.labelTimeLeft = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
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
            this.DownloadButton.Size = new System.Drawing.Size(106, 52);
            this.DownloadButton.TabIndex = 4;
            this.DownloadButton.Text = "&Start";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // showDownloadedPercent
            // 
            this.showDownloadedPercent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.showDownloadedPercent.Location = new System.Drawing.Point(416, 239);
            this.showDownloadedPercent.Name = "showDownloadedPercent";
            this.showDownloadedPercent.Size = new System.Drawing.Size(67, 17);
            this.showDownloadedPercent.TabIndex = 5;
            this.showDownloadedPercent.Text = "0%";
            this.showDownloadedPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(175, 152);
            this.textUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUrl.Multiline = true;
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(308, 32);
            this.textUrl.TabIndex = 6;
            // 
            // showTransferRate
            // 
            this.showTransferRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.showTransferRate.Location = new System.Drawing.Point(416, 300);
            this.showTransferRate.Name = "showTransferRate";
            this.showTransferRate.Size = new System.Drawing.Size(67, 17);
            this.showTransferRate.TabIndex = 7;
            this.showTransferRate.Text = "0.00";
            this.showTransferRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // showRemainingTime
            // 
            this.showRemainingTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.showRemainingTime.Location = new System.Drawing.Point(416, 327);
            this.showRemainingTime.Name = "showRemainingTime";
            this.showRemainingTime.Size = new System.Drawing.Size(67, 17);
            this.showRemainingTime.TabIndex = 8;
            this.showRemainingTime.Text = "00:00";
            this.showRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // showDownloadedBytes
            // 
            this.showDownloadedBytes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.showDownloadedBytes.Location = new System.Drawing.Point(416, 269);
            this.showDownloadedBytes.Name = "showDownloadedBytes";
            this.showDownloadedBytes.Size = new System.Drawing.Size(67, 17);
            this.showDownloadedBytes.TabIndex = 9;
            this.showDownloadedBytes.Text = "0";
            this.showDownloadedBytes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(175, 118);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(306, 30);
            this.textPassword.TabIndex = 10;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(175, 80);
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
            this.labelPassword.Location = new System.Drawing.Point(53, 118);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(99, 30);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // labelDownload
            // 
            this.labelDownload.AutoSize = true;
            this.labelDownload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelDownload.Location = new System.Drawing.Point(319, 239);
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Size = new System.Drawing.Size(85, 17);
            this.labelDownload.TabIndex = 14;
            this.labelDownload.Text = "Downloaded:";
            // 
            // labelBytesDownloaded
            // 
            this.labelBytesDownloaded.AutoSize = true;
            this.labelBytesDownloaded.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelBytesDownloaded.Location = new System.Drawing.Point(285, 269);
            this.labelBytesDownloaded.Name = "labelBytesDownloaded";
            this.labelBytesDownloaded.Size = new System.Drawing.Size(119, 17);
            this.labelBytesDownloaded.TabIndex = 15;
            this.labelBytesDownloaded.Text = "Bytes Downloaded:";
            // 
            // labelTransferRate
            // 
            this.labelTransferRate.AutoSize = true;
            this.labelTransferRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTransferRate.Location = new System.Drawing.Point(316, 300);
            this.labelTransferRate.Name = "labelTransferRate";
            this.labelTransferRate.Size = new System.Drawing.Size(88, 17);
            this.labelTransferRate.TabIndex = 16;
            this.labelTransferRate.Text = "Transfer Rate:";
            // 
            // labelTimeLeft
            // 
            this.labelTimeLeft.AutoSize = true;
            this.labelTimeLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelTimeLeft.Location = new System.Drawing.Point(340, 327);
            this.labelTimeLeft.Name = "labelTimeLeft";
            this.labelTimeLeft.Size = new System.Drawing.Size(64, 17);
            this.labelTimeLeft.TabIndex = 17;
            this.labelTimeLeft.Text = "Time Left:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(58, 205);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(425, 29);
            this.progressBar.TabIndex = 19;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // FileDownloaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 363);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelTimeLeft);
            this.Controls.Add(this.labelTransferRate);
            this.Controls.Add(this.labelBytesDownloaded);
            this.Controls.Add(this.labelDownload);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.showDownloadedBytes);
            this.Controls.Add(this.showRemainingTime);
            this.Controls.Add(this.showTransferRate);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.showDownloadedPercent);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.UrlLbl);
            this.Controls.Add(this.LabelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FileDownloaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Downloader";
            this.Load += new System.EventHandler(this.FileDownloaderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelMain;
        private System.Windows.Forms.Label UrlLbl;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Label showDownloadedPercent;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Label showTransferRate;
        private System.Windows.Forms.Label showRemainingTime;
        private System.Windows.Forms.Label showDownloadedBytes;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelDownload;
        private System.Windows.Forms.Label labelBytesDownloaded;
        private System.Windows.Forms.Label labelTransferRate;
        private System.Windows.Forms.Label labelTimeLeft;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

