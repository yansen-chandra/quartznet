using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CEZ.Core.Infrastructure.Utilities
{
    // helper class to omit XML decl at start of document when serializing
    public class XTWFND : XmlTextWriter
    {
        public XTWFND(System.IO.TextWriter w) : base(w) { Formatting = System.Xml.Formatting.Indented; }
        public override void WriteStartDocument() { }
    }

    public class SerializationUtility
    {
        public static T Deserialize<T>(string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringReader reader = new StringReader(xmlString);
            T obj = (T)serializer.Deserialize(reader);
            return obj;
        }

        public static string Serialize<T>(T obj)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (StringWriter textWriter = new StringWriter())
            {
                //xmlSerializer.Serialize(textWriter, obj);
                xmlSerializer.Serialize(new XTWFND(textWriter), obj);
                return textWriter.ToString();
            }

        }


    }
}
