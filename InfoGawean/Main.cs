using InfoGawean.Business;
using InfoGawean.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoGawean
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        private List<JobModel> tempListJobs = new List<JobModel>();
        private String selectedType = "";

        private void btnScan_Click(object sender, EventArgs e)
        {
            selectedType = cbJobType.SelectedItem.ToString();

            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerAsync();
        }

        private String SetListText(String JobName, String JobText)
        {
            String formatName = String.Format("] {0} - Di publikasikan", JobName);
            List<string> listJobs = lbLowongan.Items.Cast<String>().ToList().Where(o => o.Contains(formatName)).ToList();

            if (listJobs.Count > 0)
                JobText += string.Format(" ({0})", listJobs.Count.ToString());

            return JobText;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            object[] userState = (object[])e.UserState;
            string userState0 = (string)userState[0];

            switch (userState0)
            {
                case "listbox":
                    string[] data = (string[])userState[1];
                    string job = SetListText(data[0], data[1]);
                    lbLowongan.Items.Insert(0, job);

                    tempListJobs.Add(new JobModel() { JobText = job, JobLink = data[2] });

                    lblTotalLowongan.Text = "Total lowongan " + lbLowongan.Items.Count.ToString();

                    break;
                case "status":
                    lblStatus.Text = (string)userState[1];
                    break;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (selectedType)
            {
                case "Perusahaan premium khusus IT":
                    backgroundWorker.ReportProgress(0, new string[] { "status", "Scanning jobsdb.co.id" });

                    JobsDBPremium jobsDBPremium = new JobsDBPremium();
                    jobsDBPremium.ScanProgress += jobsDBPremium_ScanProgress;
                    jobsDBPremium.ScanJobsDBPremium();

                    break;
            }

            backgroundWorker.ReportProgress(0, new string[] { "status", "Done." });
        }

        private void jobsDBPremium_ScanProgress(JobModel data, String state)
        {
            switch (state)
            {
                case "CheckJobAvailability":
                    backgroundWorker.ReportProgress(0, new object[] { "status", "Scanning " + data.JobName });
                    break;
                case "JobAvailable":
                    backgroundWorker.ReportProgress(0, new object[] { "listbox", new string[] { data.JobName, data.JobText, data.JobLink } });
                    break;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (cbJobType.Items.Count > 0)
                cbJobType.SelectedIndex = 0;

            btnScan.Select();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lbLowongan.Items.Count > 0 && lbLowongan.SelectedIndex > -1)
                lbLowongan.Items.RemoveAt(lbLowongan.SelectedIndex);
        }

        public JobModel GetDataDataBySelectedType(ListBox listBox)
        {
            return tempListJobs.Where(o => o.JobText == listBox.SelectedItem.ToString()).FirstOrDefault();
        }

        private void btnCopyLink_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabLowongan && lbLowongan.Items.Count > 0 && lbLowongan.SelectedIndex > -1)
                Clipboard.SetText(GetDataDataBySelectedType(lbLowongan).JobLink);
            else if (tabControl1.SelectedTab == tabLowonganFavorit && lbLowonganFavorit.Items.Count > 0 && lbLowonganFavorit.SelectedIndex > -1)
                Clipboard.SetText(GetDataDataBySelectedType(lbLowonganFavorit).JobLink);
        }

        private void btnShareFB_Click(object sender, EventArgs e)
        {
            String fb = "https://www.facebook.com/sharer/sharer.php?u=";

            if (tabControl1.SelectedTab == tabLowongan && lbLowongan.Items.Count > 0 && lbLowongan.SelectedIndex > -1)
                System.Diagnostics.Process.Start(fb + GetDataDataBySelectedType(lbLowongan).JobLink);
            else if (tabControl1.SelectedTab == tabLowonganFavorit && lbLowonganFavorit.Items.Count > 0 && lbLowonganFavorit.SelectedIndex > -1)
                System.Diagnostics.Process.Start(fb + GetDataDataBySelectedType(lbLowonganFavorit).JobLink);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void btnFavorit_Click(object sender, EventArgs e)
        {
            if (lbLowongan.Items.Count > 0 && lbLowongan.SelectedIndex > -1 && tabControl1.SelectedTab == tabLowongan)
            {
                String temp = lbLowongan.SelectedItem.ToString();
                lbLowonganFavorit.Items.Insert(0, temp);

                lbLowongan.Items.RemoveAt(lbLowongan.SelectedIndex);
                lblTotalLowongan.Text = "Total lowongan " + lbLowongan.Items.Count.ToString();
            }
        }

        private void lbLowongan_DoubleClick(object sender, EventArgs e)
        {
            if (lbLowongan.Items.Count > 0 && lbLowongan.SelectedIndex > -1 && tabControl1.SelectedTab == tabLowongan)
                System.Diagnostics.Process.Start(GetDataDataBySelectedType(lbLowongan).JobLink);
        }

        private void lbLowonganFavorit_DoubleClick(object sender, EventArgs e)
        {
            if (lbLowonganFavorit.Items.Count > 0 && lbLowonganFavorit.SelectedIndex > -1 && tabControl1.SelectedTab == tabLowonganFavorit)
                System.Diagnostics.Process.Start(GetDataDataBySelectedType(lbLowonganFavorit).JobLink);
        }
    }
}
