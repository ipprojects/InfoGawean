using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoGawean.Models
{
    public class JobModel
    {
        public String JobName { get; set; }
        public String JobLink { get; set; }

        public String JobText { get; set; }

        public string JobType { get; set; }

        public int JobFavourite { get; set; }

        public DateTime JobPublished { get; set; }

        public DateTime EntryDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public int Active { get; set; }
    }
}
