using CEZ.Core.Infrastructure.Configuration;
using CEZ.Core.Infrastructure.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CEZ.Core.Infrastructure.Plugin
{
    public class PluginManager
    {
        ILogger _Logger;
        //public List<Plugin> LoadPlugins(string xmlString)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(Plugin));
        //    StringReader reader = new StringReader(xmlString);
        //    List<Plugin> list = (List<Plugin>)serializer.Deserialize(reader);
        //    return list;
        //}
        public PluginManager()
        {
            _Logger = new ConsoleLogger();
        }

        public PluginManager(ILogger logger)
        {
            _Logger = logger;
        }

        public List<PluginConfig> LoadPlugins()
        {
            PluginConfigurationSection cs = ConfigurationManager.GetSection("PluginSection") as PluginConfigurationSection;
            //PluginConfig config = cs.Plugins[0];
            List<PluginConfig> list =
                (from PluginConfig s in cs.Plugins
                 select s).ToList();
            return list;
        }

        public void RunPlugin(string pluginName)
        {
            PluginConfig plugin = this.LoadPlugins().FirstOrDefault(x => x.Name == pluginName);
            RunPlugin(plugin);
        }

        public void RunPlugin(PluginConfig plugin)
        {
            if (plugin != null)
            {
                Assembly asm = Assembly.LoadFile(plugin.DllPath);
                Type pluginType = asm.GetType(plugin.Type);
                IPluginService pluginInstance = (IPluginService)Activator.CreateInstance(pluginType);
                _Logger.Debug("Plugin loaded: " + pluginInstance.GetName());
            }
        }

    }
}
