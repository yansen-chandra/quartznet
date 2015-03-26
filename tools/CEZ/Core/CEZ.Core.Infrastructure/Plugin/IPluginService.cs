using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEZ.Core.Infrastructure.Plugin
{
    public interface IPluginService
    {
        void Process();
        string GetName();
    }
}
