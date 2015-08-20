using InfoGawean.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace InfoGawean.Business
{
    public class JobsDBPremium
    {
        private WebClient webClient = new WebClient();
        private String html = "";

        public delegate void ScanProgressEventHandler(JobModel data, String state);
        public event ScanProgressEventHandler ScanProgress;
        protected virtual void OnScanProgress(JobModel data, String state)
        {
            if (ScanProgress != null)
                ScanProgress(data, state);
        }

        public void ScanJobsDBPremium()
        {
            List<JobModel> result = new List<JobModel>();

            String paramListOfCompanyLink = "http://id.jobsdb.com/ID/id/Home/PremiumCompanies";
            List<JobModel> getListOfCompany;
            getListOfCompany = GetListOfCompany(paramListOfCompanyLink);

            String companyHTMLContent;
            foreach (JobModel company in getListOfCompany)
            {
                company.JobName = company.JobName.Replace("\r", "").Replace("\n", "");
                company.JobName = HttpUtility.HtmlDecode(company.JobName);
                OnScanProgress(company, "CheckJobAvailability");

                /// Cek apakah perusahaan memiliki lowongan IT
                companyHTMLContent = "";
                if (CheckJobAvailability(company, ref companyHTMLContent) == false)
                {
                    List<JobModel> getJobs = GetJobs(companyHTMLContent);


                    foreach (JobModel job in getJobs)
                    {
                        job.JobName = HttpUtility.HtmlDecode(job.JobName).Replace("\r", "").Replace("\n", "");
                        job.JobText = String.Format("[{0}] {1} - Di publikasikan tanggal {2}",
                                      DateTime.Now.ToString("ddMMyyyy"), job.JobName, job.JobPublished.ToString("dd/MM/yyyy"));

                        int resultSaveJob = SaveJob(job);
                        result.Add(job);

                        OnScanProgress(job, "JobAvailable");
                    }
                }
            }
        }

        public List<JobModel> GetListOfCompany(string paramListOfCompanyLink)
        {
            List<JobModel> resultGetListOfCompany = new List<JobModel>();

            html = webClient.DownloadString(paramListOfCompanyLink);
            MatchCollection mainMatchCollection = Regex.Matches(html, @"class=""pmLogoCap_s"">\s+<.+href="".+"">\s+(.+)\s+");

            foreach (Match itemMatchCollection in mainMatchCollection)
            {
                resultGetListOfCompany.Add(new JobModel() { JobName = itemMatchCollection.Groups[1].Value });
            }

            return resultGetListOfCompany;
        }

        public bool CheckJobAvailability(JobModel company, ref string companyHTMLContent)
        {
            String getCompanyURL = "http://id.jobsdb.com/ID/ID/Search/FindJobs?KeyOpt=COMPLEX&JSRV=1&RLRSF=1&JobCat=131&SearchFields=Positions,Companies&recentSelected=94&Key=";
            String formatCompanyURL = String.Format("{0}{1}", getCompanyURL, company.JobName);

            companyHTMLContent = webClient.DownloadString(formatCompanyURL);

            Match matchNoResult = Regex.Match(companyHTMLContent, @"<p class=""no-result-note"">\s+(.+)\s+<");

            return matchNoResult.Success;
        }

        public List<JobModel> GetJobs(string companyHTMLContent)
        {
            List<JobModel> resultGetJobsFromJobsdb = new List<JobModel>();

            MatchCollection jobMatchCollection = Regex.Matches(companyHTMLContent, @"posLink"" href=""(.+?)"" id="".+?"">(.+?)<");
            foreach (Match job in jobMatchCollection)
            {

                companyHTMLContent = webClient.DownloadString(job.Groups[1].Value);
                Match getDate = Regex.Match(companyHTMLContent, @"itemprop=.datePosted.+?--(\d{8})");

                string tJobDate = getDate.Groups[1].Value;

                if (getDate.Success)
                {
                    if (tJobDate.Length > 0)
                        tJobDate = string.Format("{0}-{1}-{2} 00:00:00", tJobDate.Substring(0, 4), tJobDate.Substring(4, 2), tJobDate.Substring(6, 2));
                    else
                        tJobDate = "2000-12-12 12:12:12";

                    if (tJobDate.Length != 19)
                        tJobDate = "2000-12-12 12:12:12";

                }
                else
                    tJobDate = "2000-12-12 12:12:12";


                DateTime jobDate = DateTime.Parse(tJobDate);

                JobModel jobModel = new JobModel() { JobLink = job.Groups[1].Value, JobName = job.Groups[2].Value, JobPublished = jobDate };

                resultGetJobsFromJobsdb.Add(jobModel);
            }

            return resultGetJobsFromJobsdb;
        }

        public int SaveJob(JobModel job)
        {
            job.JobType = "JobsDBPremiumKhususIT";
            job.JobFavourite = 0;
            job.JobPublished = DateTime.Now;
            job.EntryDate = DateTime.Now;
            job.UpdateDate = DateTime.Now;
            job.Active = 1;

            return 1;
        }

    }
}