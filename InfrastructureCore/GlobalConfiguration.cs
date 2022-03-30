using InfrastructureCore.DatabaseEngines.Configuration;
using InfrastructureCore.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureCore
{
    public static class GlobalConfiguration
    {
        public static IList<ModuleInfo> Modules { get; set; } = new List<ModuleInfo>();

        public static DbConnectionsManager DbConnections { get; private set; } = new DbConnectionsManager();

        public static IList<string> AngularModules { get; } = new List<string>();

        public static void RegisterAngularModule(string angularModuleName)
        {
            AngularModules.Add(angularModuleName);
        }
    }
}
