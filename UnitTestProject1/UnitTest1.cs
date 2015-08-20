using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using InfoGawean.Business;
using InfoGawean.Models;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private WebClient webClient = new WebClient();
        private String html = "";
        private MatchCollection mainMatchCollection;

        private JobsDBPremium cJobsDBPremium = new JobsDBPremium();
        private JobModel jobModel = new JobModel();

        private List<String> resultGetListOfCompany = new List<string>();
        private List<String> resultCheckJobAvailability = new List<String>();
        private String resultGetUrlContent = "";

        [TestMethod]
        public void TestMain()
        {
            List<JobModel> result = new List<JobModel>();

            jobModel.JobURL = "http://id.jobsdb.com/ID/id/Home/PremiumCompanies";

            html = cJobsDBPremium.GetUrlContent(jobModel.JobURL);

            List<String> listPremiumCompany = cJobsDBPremium.GetListOfCompany(html);

            if (listPremiumCompany.Count > 0)
            {
                if (cJobsDBPremium.CheckJobAvailability(listPremiumCompany).Count > 0)
                    result = cJobsDBPremium.GetJobsFromJobsdb(listPremiumCompany);
            }

            Assert.AreNotEqual(0, result.Count);
        }

        [TestMethod]
        public void TestGetUrlContent()
        {
            Debug.WriteLine("Start: TestGetUrlContent");
            jobModel.JobURL = "http://id.jobsdb.com/ID/id/Home/PremiumCompanies";

            resultGetUrlContent = cJobsDBPremium.GetUrlContent(jobModel.JobURL);

            Assert.AreNotEqual(string.Empty, resultGetUrlContent);
        }

        [TestMethod]
        public void TestGetListOfCompany()
        {
            TestGetUrlContent();
            Debug.WriteLine("Start: TestGetListOfCompany");
            String paramHTML = resultGetUrlContent;
            int resultGetListOfCompanyCount = 0;

            resultGetListOfCompany = cJobsDBPremium.GetListOfCompany(paramHTML);

            resultGetListOfCompanyCount = resultGetListOfCompany.Count;
            Debug.WriteLine("resultGetListOfCompanyCount: " + resultGetListOfCompanyCount);

            Assert.AreNotEqual(0, resultGetListOfCompanyCount);
        }

        [TestMethod]
        public void TestCheckJobAvailability()
        {
            TestGetListOfCompany();
            Debug.WriteLine("Start: TestCheckJobAvailability");
            List<String> paramListOfCompany = resultGetListOfCompany;

            resultCheckJobAvailability = cJobsDBPremium.CheckJobAvailability(paramListOfCompany);

            Debug.WriteLine("resultCheckJobAvailability.Count: " + resultCheckJobAvailability.Count);
            Assert.AreNotEqual(0, resultCheckJobAvailability.Count);
        }

        [TestMethod]
        public void TestGetJobsFromJobsdb()
        {
            TestCheckJobAvailability();
            Debug.WriteLine("Start: TestGetJobsFromJobsdb");
            List<String> paramListString = resultCheckJobAvailability;
            List<JobModel> resultGetJobsFromJobsdb = new List<JobModel>();

            MatchCollection jobMatchCollection = Regex.Matches(html, @"posLink"" href=""(.+?)"" id="".+?"">(.+?)<");
            foreach (Match job in jobMatchCollection)
            {
                Debug.WriteLine(job.Groups[1].Value + " " + job.Groups[1].Value);
                resultGetJobsFromJobsdb.Add(new JobModel() { JobURL = job.Groups[1].Value, JobName = job.Groups[2].Value });
            }

            Debug.WriteLine("Count: " + resultGetJobsFromJobsdb.Count);
            Assert.AreNotEqual(0, resultGetJobsFromJobsdb.Count);
        }
    }

}
