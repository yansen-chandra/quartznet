using log4net.Appender;
using log4net.Config;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Interface.Infrastructure.Configuration
{
    public class Log4NetConfig
    {
        public static void InitializeLog4Net()
        {
            //initialize the log4net configuration based on the log4net.config file
            XmlConfigurator.ConfigureAndWatch(new FileInfo(System.AppDomain.CurrentDomain.BaseDirectory + @"\log4Net.config"));

            Hierarchy hier = log4net.LogManager.GetRepository() as Hierarchy;
            if (hier != null)
            {
                // Get ADONetAppender by name
                AdoNetAppender adoAppender = (from appender in hier.GetAppenders()
                                              where appender.Name.Equals("DbAppender", StringComparison.InvariantCultureIgnoreCase)
                                              select appender).FirstOrDefault() as AdoNetAppender;

                // Change only when the auto setting is set
                if (adoAppender != null && adoAppender.ConnectionString.Contains("{auto}"))
                {
                    //adoAppender.ConnectionString = ExtractConnectionStringFromEntityConnectionString(
                    //        GetEntitiyConnectionStringFromWebConfig());
                    adoAppender.ConnectionString = GetEntitiyConnectionStringFromWebConfig();

                    //refresh settings of appender
                    adoAppender.ActivateOptions();

                }
            }
        }

        private static string GetEntitiyConnectionStringFromWebConfig()
        {
            return ConfigurationManager.ConnectionStrings[ConstantUtility.Database.MvcDbConnectionStringConfig].ConnectionString;
        }

        private static string ExtractConnectionStringFromEntityConnectionString(string entityConnectionString)
        {
            // create a entity connection string from the input
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder(entityConnectionString);

            // read the db connectionstring
            return entityBuilder.ProviderConnectionString;
        }
    }
}
