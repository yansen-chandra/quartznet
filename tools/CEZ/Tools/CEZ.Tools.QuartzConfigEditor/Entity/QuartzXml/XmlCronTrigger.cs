using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CEZ.Tools.QuartzConfigEditor.Entity
{
    [XmlRoot("cron")]
    public class XmlCronTrigger : XmlBaseTrigger
    {

        [XmlElement(ElementName = "cron-expression")]
        public string CronExpression { get; set; }
        

    }
}
