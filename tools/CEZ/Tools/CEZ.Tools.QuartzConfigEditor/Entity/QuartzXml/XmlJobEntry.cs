using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CEZ.Tools.QuartzConfigEditor.Entity
{
    [Serializable]
    [XmlRoot("entry")]
    public class XmlJobEntry
    {
        public string key { get; set; }
        public string value { get; set; }
    }

}
