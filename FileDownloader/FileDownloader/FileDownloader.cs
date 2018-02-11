using System.Windows.Forms;
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
        private String errorMessage = "Please check that all fields are filled in";

        /// <summary>
        /// Stopwatch to be used to calculate transfer rate of download
        /// </summary>
        Stopwatch stopWatch = new Stopwatch();

        /// <summary>
        /// When the Download File button is clicked the user is prompted to name the file to be downloaded and to choose a save location for it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                stopWatch.Start();
                WebClient webClient = new WebClient();
                webClient.UseDefaultCredentials = true;
                webClient.Credentials = new NetworkCredential(textUserName.Text, textPassword.Text);
                webClient.DownloadFileAsync(new Uri(textUrl.Text), saveFile.FileName);
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_DownloadFileCompleted);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged);
            }  
        }

        /// <summary>
        /// Processes while the download is happening
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            showPercentage.Text = "Downloading..." + e.ProgressPercentage.ToString();
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
            MessageBox.Show("File downloaded", "Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((WebClient)sender).Dispose();
        }

        /// <summary>
        /// Text Box Validations. Not allowing empty boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textUserName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textUserName, errorMessage);
            }
        }

        private void textPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textPassword, errorMessage);
            }

        }

        private void textUrl_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textUrl.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textUrl, errorMessage);
            }
        }
    }
}