using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CEZ.Tools.QuartzConfigEditor.Entity
{
    [Serializable]
    [XmlRoot("schedule", Namespace = "http://quartznet.sourceforge.net/JobSchedulingData")]
    public class XmlSchedule
    {
        [XmlElement("job")]
        public XmlJob[] Jobs { get; set; }

        [XmlElement("trigger")]
        public XmlTrigger[] Triggers { get; set; }
    }

}
