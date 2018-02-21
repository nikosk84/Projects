using System.Windows.Forms;
using System.Net;
using System;
using System.ComponentModel;

namespace FileDownloader
{
    public partial class FileDownloaderForm : Form
    {
        public FileDownloaderForm()
        {
            InitializeComponent();

            textUserName.Enabled = false;
            textPassword.Enabled = false;
            progressBar.Value = 0;
            textUrl.Text = "";

            textUrl.Focus();
        }

        /// <summary>
        /// Gets start time for calculating remaining download time
        /// </summary>
        private DateTime start = DateTime.Now;

        /// <summary>
        /// Message for error provider used on text fields
        /// </summary>
        private String errorMessage = "Check fields";

        /// <summary>
        /// Web Client responsible for connecting
        /// to given URL and for executing a download process
        /// </summary>
        WebClient webClient = new WebClient();

        /// <summary>
        /// Monitors state of credentials check box and enables or disables user name and password
        /// text fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useCredsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (useCredsCheck.Checked)
            {
                errorProvider.Clear();
                textUserName.Enabled = true;
                textPassword.Enabled = true;
            }
            else
            {
                errorProvider.Clear();
                textUserName.Clear();
                textPassword.Clear();
                textUserName.Enabled = false;
                textPassword.Enabled = false;
            }
        }

        /// <summary>
        /// Web client starts and executes the download process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            DownloadButton.Enabled = false;
            useCredsCheck.Enabled = false;

            progressBar.Value = e.ProgressPercentage;

            if ((DateTime.Now - start).Seconds > 0)
            {
                //Variables to store download time calculations
                double kbPerSecond = (e.BytesReceived / 1000) / (DateTime.Now - start).Seconds;
                double remainingTimeInSeconds = (((e.TotalBytesToReceive - e.BytesReceived) / 1000) / kbPerSecond);
                string remainingTimeDisplay = string.Empty;

                //If remaining time is more than an hour (3600 seconds)
                if (remainingTimeInSeconds > 3600)
                {
                    remainingTimeDisplay += ((int)(remainingTimeInSeconds) / 3600).ToString(" 0 ") + "hours, ";
                    remainingTimeInSeconds %= 3600;
                }

                //If remaining time is more than a minute (60 seconds)
                if (remainingTimeInSeconds > 60)
                {
                    remainingTimeDisplay += ((int)(remainingTimeInSeconds) / 60).ToString(" 0 ") + "minutes, ";
                    remainingTimeInSeconds %= 60;
                }

                //If remaining time is less than an hour and less than a minute
                remainingTimeDisplay += ((int)remainingTimeInSeconds).ToString(" 0 ") + "seconds remaining ";

                //Update window view and show values as the download progresses
                Text = (e.BytesReceived / 1000).ToString(" 0 ")
                    + "bytes received of "
                    + (e.TotalBytesToReceive / 1000).ToString(" 0 ")
                    + " : " + e.ProgressPercentage.ToString() + " % at " + kbPerSecond.ToString(" 0 ")
                    + " Kb/s " + remainingTimeDisplay;
            }
        }

        /// <summary>
        /// When download process ends the below method fires depending on if 
        /// a download cancellation existed or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                MessageBox.Show("File downloaded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar.Value = 0;
                ((WebClient)sender).Dispose();
                useCredsCheck.Enabled = true;
                DownloadButton.Enabled = true; 
            }
            else
            {
                MessageBox.Show("Process cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((WebClient)sender).Dispose();
                useCredsCheck.Enabled = true;
                DownloadButton.Enabled = true;
                progressBar.Value = 0;
                Text = string.Empty;
            }
        }

        /// <summary>
        /// When the Download File button is clicked the user is asked to name the file 
        /// to be downloaded and to choose a save location for it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if (useCredsCheck.Checked)
            {
                if (string.IsNullOrEmpty(textUserName.Text))
                {
                    errorProvider.Clear();
                    errorProvider.SetError(textUserName, errorMessage);
                }
                else if (string.IsNullOrEmpty(textPassword.Text))
                {
                    errorProvider.Clear();
                    errorProvider.SetError(textPassword, errorMessage);
                }
                else if (string.IsNullOrEmpty(textUrl.Text))
                {
                    errorProvider.Clear();
                    errorProvider.SetError(textUrl, errorMessage);
                }
                else
                {
                    UserModel user = new UserModel { UserName = textUserName.Text, Password = textPassword.Text };

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        errorProvider.Clear();

                        webClient.Credentials = new NetworkCredential(user.UserName, user.Password);
                        webClient.DownloadFileAsync(new Uri(textUrl.Text), saveFile.FileName);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_DownloadFileCompleted);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged);
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(textUrl.Text))
                {
                    errorProvider.SetError(textUrl, errorMessage);
                }
                else
                {
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        errorProvider.Clear();

                        webClient.DownloadFileAsync(new Uri(textUrl.Text), saveFile.FileName);
                        webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_DownloadFileCompleted);
                        webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged);
                    }
                }
            }
        }

        /// <summary>
        /// Kills download process and fires DownloadCompleted event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelDownload_Click(object sender, EventArgs e)
        {
            webClient.CancelAsync();

            textUserName.Enabled = false;
            textPassword.Enabled = false;
            useCredsCheck.Enabled = true;
            textUrl.Text = "";
            textUrl.Focus();
        }
    }
}