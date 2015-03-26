using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CEZ.Tools.QuartzConfigEditor.Entity
{
    // helper class to omit XML decl at start of document when serializing
    public class XTWFND : XmlTextWriter
    {
        public XTWFND(System.IO.TextWriter w) : base(w) { Formatting = System.Xml.Formatting.Indented; }
        public override void WriteStartDocument() { }
    }
}
