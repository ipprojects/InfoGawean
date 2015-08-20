using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using InfoGawean.Models;
using InfoGawean.Business;
using System.Diagnostics;
using System.Windows.Forms;


namespace UnitTestProject1
{
    [TestClass]
    public class TestMainForm
    {
        JobsDBPremium jobsDBPremium = new JobsDBPremium();
        JobModel jobModel = new JobModel();
        InfoGawean.Main main = new InfoGawean.Main();

        [TestMethod]
        public void TestMethod1()
        {
            jobsDBPremium.ScanProgress += jobsDBPremium_ScanProgress;
            jobsDBPremium.ScanJobsDBPremium();
        }

        private void jobsDBPremium_ScanProgress(JobModel data, string state)
        {
            //main.SetListText(data.JobName, data.JobText);
        }
    }
}
