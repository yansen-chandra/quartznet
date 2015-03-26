using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEZ.Core.Infrastructure.Configuration
{
    public class PluginConfig : ConfigurationElement
    {
        public PluginConfig() { }

        public PluginConfig(string name, string dllPath, string type)
        {
            Name = name;
            DllPath = dllPath;
            Type = type;
        }

        [ConfigurationProperty("Name", DefaultValue = "", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)this["Name"]; }
            set { this["Name"] = value; }
        }

        [ConfigurationProperty("DllPath", DefaultValue = "", IsRequired = true, IsKey = false)]
        public string DllPath
        {
            get { return (string)this["DllPath"]; }
            set { this["DllPath"] = value; }
        }

        [ConfigurationProperty("Type", DefaultValue = "", IsRequired = true, IsKey = false)]
        public string Type
        {
            get { return (string)this["Type"]; }
            set { this["Type"] = value; }
        }
    }
}
