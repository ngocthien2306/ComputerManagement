using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureCore.DatabaseEngines.Configuration
{
    public class DbConnectionsManager
    {
        public DbConnectionInfo FrameworkConnection { get; set; }
        public DbConnectionInfo DbConnection1 { get; set; }
        public DbConnectionInfo DbConnection2 { get; set; }
        public DbConnectionInfo DbConnection3 { get; set; }
        public DbConnectionInfo DbConnection4 { get; set; }
        public DbConnectionInfo DbConnection5 { get; set; }
    }
    public class DbConnectionInfo
    {
        public string ConnectionString { get; set; }
    }

    public enum DbConnectionEnum
    {
        Framework,
        Connection1,
        Connection2,
        Connection3,
        Connection4,
        Connection5
    }




}
