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
            textUrl.Text = "";

            textUrl.Focus();
        }

        /// <summary>
        /// Gets start time to be used for calculating remaining download time
        /// </summary>
        private DateTime start = DateTime.Now;

        /// <summary>
        /// Error message for blank text boxes using the error provider
        /// </summary>
        private String errorMessage = "Check fields";

        /// <summary>
        /// When the Download File button is clicked the user is asked to name the file 
        /// to be downloaded and to choose a save location for it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            WebClient webClient = new WebClient();

            if (useCredsCheck.Checked)
            {
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
        /// Kills download process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelDownload_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Processes while the download is happening
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

                //If remaining time is more than an hour (3600 seconds) update view
                if (remainingTimeInSeconds > 3600)
                {
                    remainingTimeDisplay += ((int)(remainingTimeInSeconds) / 3600).ToString(" 0 ") + "hours, ";
                    remainingTimeInSeconds %= 3600;
                }

                //If remaining time is more than a minute (60 seconds) update view
                if (remainingTimeInSeconds > 60)
                {
                    remainingTimeDisplay += ((int)(remainingTimeInSeconds) / 60).ToString(" 0 ") + "minutes, ";
                    remainingTimeInSeconds %= 60;
                }

                //If remaining time is less than an hour and less than a minute, update view
                remainingTimeDisplay += ((int)remainingTimeInSeconds).ToString(" 0 ") + "seconds remaining ";

                //Update view with all values accordingly
                Text = (e.BytesReceived / 1000).ToString(" 0 ") 
                    + "bytes received of "
                    + (e.TotalBytesToReceive / 1000).ToString(" 0 ") 
                    + " : " + e.ProgressPercentage.ToString() + " % at " + kbPerSecond.ToString(" 0 ") 
                    + " Kb/s " + remainingTimeDisplay;
            }
        }

        /// <summary>
        /// When download completes, tell the user and release all resources used by WebClient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File downloaded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar.Value = 0;
            ((WebClient)sender).Dispose();
        }

        /// <summary>
        /// Use log on credentials depending on user selection
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
                textUserName.Enabled = false;
                textPassword.Enabled = false;
            }
        }
    }
}