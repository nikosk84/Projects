﻿using System.Windows.Forms;
using System.Net;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace FileDownloader
{
    public partial class FileDownloaderForm : Form
    {
        public FileDownloaderForm()
        {
            InitializeComponent();
            textUrl.Focus();
        }

        /// <summary>
        /// Error message for blank text boxes using the error provider
        /// </summary>
        private String errorMessage = "Check fields";

        /// <summary>
        /// Stopwatch to be used to calculate transfer rate of download
        /// </summary>
        Stopwatch stopWatch = new Stopwatch();

        /// <summary>
        /// When the Download File button is clicked the user is asked to name the file 
        /// to be downloaded and to choose a save location for it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            //If a text box is empty, do not perform download and tell user
            if (string.IsNullOrEmpty(textUserName.Text))
            {
                errorProvider.SetError(textUserName, errorMessage);
            }
            else if (string.IsNullOrEmpty(textPassword.Text))
            {
                errorProvider.SetError(textPassword, errorMessage);
            }
            else if (string.IsNullOrEmpty(textUrl.Text))
            {
                errorProvider.SetError(textUrl, errorMessage);
            }
            else
            {
                //Since no text box is empty, clear errors and start process
                UserModel user = new UserModel();
                SaveFileDialog saveFile = new SaveFileDialog();

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    errorProvider.Clear();
                    stopWatch.Start();
                    
                    WebClient webClient = new WebClient();
                    webClient.Credentials = new NetworkCredential(user.GetUserName(textUserName.Text), user.GetPassword(textPassword.Text));
                    webClient.DownloadFileAsync(new Uri(textUrl.Text), saveFile.FileName);
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_DownloadFileCompleted);
                    webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged);
                }
            }
        }

        /// <summary>
        /// Processes while the download is happening
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            showPercentage.Text = e.ProgressPercentage.ToString() + "%";
            progressBar.Value = e.ProgressPercentage;
            showBytesReceived.Text = e.BytesReceived.ToString();
            showTransferRate.Text = string.Format("{0} bytes/s", (e.BytesReceived / 1024d / stopWatch.Elapsed.TotalSeconds).ToString("0.00"));
        }

        /// <summary>
        /// When download completes, tell the user and release all resources used by WebClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ((WebClient)sender).Dispose();
        }
    }
}