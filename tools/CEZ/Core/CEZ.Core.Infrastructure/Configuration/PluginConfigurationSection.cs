
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEZ.Core.Infrastructure.Configuration
{
    public class PluginConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("Plugins", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(PluginCollection),
            AddItemName = "add",
            ClearItemsName = "clear",
            RemoveItemName = "remove")]
        public PluginCollection Plugins
        {
            get
            {
                return (PluginCollection)base["Plugins"];
            }
        }
    }
}
