
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEZ.Core.Infrastructure.Configuration
{
    public class PluginCollection : ConfigurationElementCollection
    {
        public PluginCollection()
        {
            //Console.WriteLine("PluginCollection Constructor");
        }

        public PluginConfig this[int index]
        {
            get { return (PluginConfig)BaseGet(index); }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public void Add(PluginConfig PluginConfig)
        {
            BaseAdd(PluginConfig);
        }

        public void Clear()
        {
            BaseClear();
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new PluginConfig();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((PluginConfig)element).Name;
        }

        public void Remove(PluginConfig PluginConfig)
        {
            BaseRemove(PluginConfig.Name);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }
    }
}
