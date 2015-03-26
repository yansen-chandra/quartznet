using CEZ.Core.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEZ.Core.Infrastructure.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void Warn(string message)
        {
            Console.WriteLine(message);
        }

        public void Debug(string message)
        {
            Console.WriteLine(message);
        }

        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        public void Error(string message, Exception x)
        {
            Console.WriteLine(message);
        }

        public void Error(Exception x)
        {
            Console.WriteLine(LogUtility.BuildExceptionMessage(x));
        }

        public void Fatal(string message)
        {
            Console.WriteLine(message);
        }

        public void Fatal(Exception x)
        {
            Console.WriteLine(LogUtility.BuildExceptionMessage(x));
        }
    }
}
