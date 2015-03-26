using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CEZ.Tools.QuartzConfigEditor.Entity
{
    [XmlRoot("simple")]
    public class XmlSimpleTrigger : XmlBaseTrigger
    {
        /*
    <trigger>
      <simple>
        <name>xmlTrigger1</name>
        <group>xmljobGroup1</group>
        <description>SimpleTriggerDescription</description>
        <job-name>jobName1</job-name>
        <job-group>jobGroup1</job-group>
        <start-time>1982-06-28T18:15:00.0Z</start-time>
        <end-time>2020-05-04T18:13:51.0Z</end-time>
        <misfire-instruction>SmartPolicy</misfire-instruction>
        <repeat-count>100</repeat-count>
        <repeat-interval>5000</repeat-interval>
      </simple>
    </trigger>
         
 */

        //[XmlElement(ElementName = "name")]
        //public string Name { get; set; }

        //[XmlElement(ElementName = "group")]
        //public string Group { get; set; }

        //[XmlElement(ElementName = "description")]
        //public string Description { get; set; }

        //[XmlElement(ElementName = "job-name")]
        //public string JobName { get; set; }

        //[XmlElement(ElementName = "job-group")]
        //public string JobGroup { get; set; }

        [XmlElement(ElementName = "start-time")]
        public DateTime StartTime { get; set; }

        [XmlElement(ElementName = "end-time")]
        public DateTime EndTime { get; set; }

        [XmlElement(ElementName = "misfire-instruction")]
        public string MisfireInstruction { get; set; }

        [XmlElement(ElementName = "repeat-count")]
        public int RepeatCount { get; set; }

        [XmlElement(ElementName = "repeat-interval")]
        public int RepeatInterval { get; set; }
    }
}
