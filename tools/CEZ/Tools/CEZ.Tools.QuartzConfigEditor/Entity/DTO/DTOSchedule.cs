using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEZ.Tools.QuartzConfigEditor.Entity.DTO
{
    public class DTOSchedule
    {
        private string _Path;

        public string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }

        //List<XmlJob> Jobs

        private List<XmlJob> _Jobs;

        public List<XmlJob> Jobs
        {
            get { return _Jobs; }
            set { _Jobs = value; }
        }

        public DTOSchedule()
        {

        }

        public DTOSchedule(XmlSchedule xmlSchedule)
        {
            this._Jobs = CreateJobsFromXmlSchedule(xmlSchedule);
        }


        private List<XmlJob> CreateJobsFromXmlSchedule(XmlSchedule xmlSchedule)
        {
            List<XmlJob> jobs = new List<XmlJob>();
            jobs.AddRange(xmlSchedule.Jobs);
            foreach (XmlTrigger xmlTrig in xmlSchedule.Triggers)
            {
                XmlBaseTrigger trigger = xmlTrig.GetTrigger();
                XmlJob job = jobs.FirstOrDefault(x => x.Name == trigger.JobName
                     && x.Group == trigger.JobGroup);
                if(job != null)
                {
                    job.Triggers.Add(xmlTrig);
                }
            }

            return jobs;

        }

        public XmlJob GetJobByName(string jobName)
        {
            return this.Jobs.FirstOrDefault(x => x.Name == jobName);
        }

        public XmlSchedule GetJobSchedule()
        {
            XmlSchedule sch = new XmlSchedule();

            sch.Jobs = this.Jobs.ToArray();
            List<XmlTrigger> triggers = new List<XmlTrigger>();
            foreach(XmlJob job in this.Jobs)
            {
                triggers.AddRange(job.Triggers);
            }
            sch.Triggers = triggers.ToArray();
            return sch;
        }
    }
}
