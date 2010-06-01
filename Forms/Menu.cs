using System;
using System.Drawing;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

using LcogClient.Model;
using LcogClient.Utility;

namespace LcogClient.Forms
{
    public partial class Menu : Base
    {
        private BackgroundWorker workerThread;
        private bool downloading = false;

        public Menu()
        {
            InitializeComponent();

            ListViewItem item = new ListViewItem("Welcome!");
            this.listView.Items.Add(item);

            this.workerThread = new BackgroundWorker();
            this.workerThread.DoWork += new DoWorkEventHandler(workerThread_DoWork);
            this.workerThread.RunWorkerCompleted += new RunWorkerCompletedEventHandler(workerThread_RunWorkerCompleted);
            this.workerThread.ProgressChanged += new ProgressChangedEventHandler(workerThread_ProgressChanged);
            this.workerThread.WorkerReportsProgress = true;
            this.UpdateView();

            this.textBoxFactionId.Text = LcogConfig.FactionID.ToString();
            this.textBoxPassword.Text = LcogConfig.Password.ToString();
            ToolTip tp = new ToolTip();
            tp.ToolTipTitle = "Update Settings";
            tp.SetToolTip(this.buttonUpdate, "Save the above settings - note that security may stop this working on Windows Vista/7.");
            
        }

        void workerThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
        }


        void workerThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.downloading = false;
            this.listView.Items.Add(new ListViewItem("Playerfile updated"));
            this.listView.Items.Add(new ListViewItem("Report downloaded " + DateTime.Now.ToString()));
            this.listView.Items[this.listView.Items.Count - 1].EnsureVisible();
            LcogIO.UnzipReport();
            this.progressBar.Value = 0;
            this.UpdateView();
        }

        Stream responseStream;
        Stream fileStream;

        HttpWebRequest request;
        HttpWebResponse response;

        void workerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    string url = LcogConfig.ReportURL + "report" + LcogConfig.FactionID + ".zip";

                    request = (HttpWebRequest)WebRequest.Create(url);
                    request.Credentials = CredentialCache.DefaultCredentials;

                    response = (HttpWebResponse)request.GetResponse();
                    Int64 fileSize = response.ContentLength;

                    this.responseStream = webClient.OpenRead(url);
                    this.fileStream = new FileStream("report" + LcogConfig.FactionID + ".zip", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);

                    int byteSize = 0;

                    byte[] downloadBuffer = new byte[2048];

                    while ((byteSize = this.responseStream.Read(downloadBuffer, 0, downloadBuffer.Length)) > 0)
                    {
                        this.fileStream.Write(downloadBuffer, 0, byteSize);

                        int progress = Convert.ToInt32((fileStream.Length * 100) / fileSize);
                        this.workerThread.ReportProgress(progress);
                    }
                }
                catch
                {
                    // do something
                }
                finally
                {
                    this.responseStream.Close();
                    this.fileStream.Close();
                    this.request.Abort();
                    this.response.Close();
                }
            }
        }

        void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (LcogIO.UploadOrders())
                {
                    this.listView.Items.Add(new ListViewItem("Order Upload SUCCESS! " + DateTime.Now.ToString()));
                }
                else
                {
                    this.listView.Items.Add(new ListViewItem("Order Upload FAILED! " + DateTime.Now.ToString()));
                }
                this.listView.Items[this.listView.Items.Count - 1].EnsureVisible();
            }
            catch
            {
                this.listView.Items.Add(new ListViewItem("orders" + LcogConfig.FactionID + ".xml not found!"));
                this.listView.Items[this.listView.Items.Count - 1].EnsureVisible();
            }
        }

        void buttonDownload_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("Contacting the host server...");
            this.listView.Items.Add(item);
            this.listView.Items[this.listView.Items.Count - 1].EnsureVisible();
            if (!this.downloading)
            {
                this.downloading = true;
                LcogIO.DownloadPlayerFile();
                this.workerThread.RunWorkerAsync();
            }
            else
            {
                // do nothing
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {


            Play form = new Play();
            // hide this 
            this.Hide();
            // show main play form
            form.ShowDialog();
            // play form has closed so show this again
            this.Show();
            ListViewItem item2 = new ListViewItem("Remember to upload any saved orders!");
            this.listView.Items.Add(item2);
            this.listView.Items[this.listView.Items.Count - 1].EnsureVisible();
        }

        private void buttonVCR_Click(object sender, EventArgs e)
        {
            //VCR form = new VCR();
            VCRUniversal form = new VCRUniversal();

            // hide this 
            this.Hide();
            // show main play form
            form.ShowDialog();
            // play form has closed so show this again
            this.Show();
        }

        public override void UpdateView()
        {
            try
            {
                LcogIO.LoadGameData("playerfile.xml");
                //this.labelGameName.Text = LcogClient.Instance.GameName;
            }
            catch
            {
                ListViewItem item = new ListViewItem("playerfile.xml not found!");
                this.listView.Items.Add(item);
               // this.labelGameName.Text = "playerfile.xml not found!";
            }

            try
            {
                LcogIO.LoadReport("report" + LcogConfig.FactionID + ".xml");
            }
            catch
            {
                ListViewItem item = new ListViewItem("Report for faction " + LcogConfig.FactionID.ToString() + " not found!");
                this.listView.Items.Add(item);
                this.listView.Items[this.listView.Items.Count - 1].EnsureVisible();
            }
            try
            {
                XmlDocument xml = LcogIO.LoadXml("orders" + LcogConfig.FactionID + ".xml");
                XmlNodeList orderNodes = xml.SelectSingleNode("//orders").ChildNodes;
                //this.labelOrders.Text = orderNodes.Count.ToString() + " orders in file for upload";
            }
            catch
            {
                //this.labelOrders.Text = "No order file found!";
            }

            try
            {
                int count = 0;
                FileInfo filei = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
                DirectoryInfo directory = filei.Directory;
                foreach (FileInfo file in directory.GetFiles())
                {
                    if (file.Extension == ".avi")
                    {
                        if (this.GetTurn(file.Name.Substring(0, file.Name.Length - 4)) == Client.Instance.Player.Turn)
                        {
                            count++;
                        }
                    }
                }
                if (count > 0)
                {
                    this.buttonVCR.ForeColor = Color.Red;
                    this.buttonVCR.Text = "VCR (" + count.ToString() + ")";
                }
                else
                {
                    this.buttonVCR.ForeColor = Color.Black;
                    this.buttonVCR.Text = "VCR";
                }
            }
            catch (Exception ex)
            {
                string tep = "tep";
            }
        }

        private int GetTurn(string fileName)
        {
            try
            {
                string[] s = fileName.Split(new char[] { '_' });

                string t = s[1];
                return int.Parse(t);
            }
            catch
            {
                return 0;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LcogConfig.FactionID = this.textBoxFactionId.Text;
            LcogConfig.Password = this.textBoxPassword.Text;
        }
    }
}
