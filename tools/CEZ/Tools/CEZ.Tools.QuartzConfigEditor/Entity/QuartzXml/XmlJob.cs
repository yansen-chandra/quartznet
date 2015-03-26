using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CEZ.Tools.QuartzConfigEditor.Entity
{
    [Serializable]
    [XmlRoot("job")]
    public class XmlJob
    {
        /*
         
      <name>xmljobName1</name>
      <group>xmljobGroup1</group>
      <description>jobDesciption1</description>
      <job-type>NEC.NCSS.NIS.TaskScheduler.ConsoleApp.SimpleJob, NEC.NCSS.NIS.TaskScheduler.ConsoleApp</job-type>
      <durable>true</durable>
      <recover>false</recover>
      <job-data-map>
        <entry>
          <key>key0</key>
          <value>value0</value>
        </entry>
        <entry>
          <key>key1</key>
          <value>value1</value>
        </entry>
        <entry>
          <key>key2</key>
          <value>value2</value>
        </entry>
      </job-data-map>         
         */

        private string _Name;

        [XmlElement(ElementName = "name")]
        public string Name { 
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                UpdateTrigger(_Name, _Group);
            }
        }

        private string _Group;

        [XmlElement(ElementName = "group")]
        public string Group 
        {
            get
            {
                return _Group;
            }
            set
            {
                _Group = value;
                UpdateTrigger(_Name, _Group);
            }
        }

        private void UpdateTrigger(String jobName, string jobGroup)
        {
            foreach (XmlTrigger trigger in Triggers)
            {
                XmlBaseTrigger t = trigger.GetTrigger();
                if (t != null)
                {
                    t.JobName = jobName;
                    t.JobGroup = jobGroup;
                }
            }
        }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "job-type")]
        public string JobType { get; set; }

        [XmlElement(ElementName = "durable")]
        public string Durable { get; set; }

        [XmlElement(ElementName = "recover")]
        public string Recover { get; set; }

        [XmlArray("job-data-map")]
        [XmlArrayItem("entry")]
        public XmlJobEntry[] JobDataMaps { get; set; }

        private List<XmlTrigger> _Triggers;
        [XmlIgnore]
        public List<XmlTrigger> Triggers 
        {
            get
            {
                return _Triggers;
            }
            set
            {
                _Triggers = value;
            }
        }

        public List<XmlBaseTrigger> GetAllTriggers()
        {
            List<XmlBaseTrigger> trig = this.Triggers.Select(x => x.GetTrigger()).ToList();
            return trig;
        }

        public XmlJob()
        {
            Triggers = new List<XmlTrigger>();
        }
    }
}
