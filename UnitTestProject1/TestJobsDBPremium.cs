using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using InfoGawean.Models;
using InfoGawean.Business;
using System.Diagnostics;
using System.Net;

namespace UnitTestProject1
{
    [TestClass]
    public class TestJobsDBPremium
    {
        JobsDBPremium jobsDBPremium = new JobsDBPremium();
        JobModel jobModel = new JobModel();

        [TestMethod]
        public void GetJobs()
        {
            String url = "http://id.jobsdb.com/id/en/search/Findjobs?JSRV=1&AccNums=8996&JSSRC=PMEP";
            String html = new WebClient().DownloadString(url);
            List<JobModel> result = jobsDBPremium.GetJobs(html);

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count);
        }
    }
}
