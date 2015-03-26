using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CEZ.Tools.QuartzConfigEditor.Entity
{
    [XmlRoot("trigger")]
    public class XmlTrigger
    {
        [XmlElement(ElementName = "simple")]
        public XmlSimpleTrigger SimpleTrigger { get; set; }

        [XmlElement(ElementName = "cron")]
        public XmlCronTrigger CronTrigger { get; set; }

        public XmlBaseTrigger GetTrigger()
        {
            if (SimpleTrigger != null)
                return SimpleTrigger;
            else if (CronTrigger != null)
                return CronTrigger;

            return null;
        }
    }

}
