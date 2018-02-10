using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System;
using System.ComponentModel;

namespace FileDownloader
{
    public partial class FileDownloaderForm : Form
    {
         /* Incomplete Tasks
         * A progress bar with the state of the transfer
         * Estimated time left
         */

        public FileDownloaderForm()
        {
            InitializeComponent();
            //Put cursor into the URL text box when the program runs
            textUrl.Focus();
        }

        /// <summary>
        /// Private variables
        /// </summary>
        private WebClient webClient;
        private Stopwatch stopWatch = new Stopwatch();
        private string savePath = @"MySavePath";

        /// <summary>
        /// On-Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileDownloaderForm_Load(object sender, EventArgs e)
        {
            webClient = new WebClient();
            //Handles DownloadProgressChanged event
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged);
            //Handles event of async operation
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_DownloadFileCompleted);
        }

        /// <summary>
        /// Download button on-click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            //Username and password strings
            string userName = textUserName.Text;
            string password = textPassword.Text;

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                if (!backgroundWorker.IsBusy)
                {
                    //Execute background worker
                    backgroundWorker.RunWorkerAsync();
                }
            }
            else
            {
                //If Username and Password haven't been entered
                MessageBox.Show("Check credentials and try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Background Worker executes the thread which connects to a server, gets a file, and saves it to a location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!backgroundWorker.CancellationPending)
            {
                //URL
                string url = textUrl.Text;
                if (!string.IsNullOrEmpty(url))
                {
                    webClient.Credentials = new NetworkCredential(textUserName.Text, textPassword.Text);

                    Thread thread = new Thread(() =>
                    {
                        stopWatch.Start();
                        Uri uri = new Uri(url);
                        string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                        webClient.DownloadFileAsync(uri, savePath);
                    });
                    //Fires the Thread start delegate and invokes method
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Check URL", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// What we want happening during the download. Update labels, counts etc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //Executes delegate
            Invoke(new MethodInvoker(delegate ()
            {
                showTransferRate.Text = string.Format("{0} bytes/s", (e.BytesReceived / 1024d / stopWatch.Elapsed.TotalSeconds).ToString("0.00##"));
                showDownloadedBytes.Text = e.BytesReceived.ToString(); 
            })); 
        }

        /// <summary>
        /// Download completed. Closing doors. Stopping clocks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            stopWatch.Stop();
            ((WebClient)sender).Dispose();
            backgroundWorker.CancelAsync();
            MessageBox.Show("File downloaded to " + savePath, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}