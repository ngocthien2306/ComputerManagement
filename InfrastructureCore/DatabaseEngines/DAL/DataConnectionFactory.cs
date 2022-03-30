using DevExpress.Xpo;
using InfrastructureCore.DatabaseEngines.Configuration;
using InfrastructureCore.DatabaseEngines.Engines;
using System;

namespace InfrastructureCore.DatabaseEngines.DAL
{
    public class DataConnectionFactory 
    {
        public static IDataConnection GetConnection(string connectionInfo)
        { 
             return new MsDbConnection(connectionInfo);        
        }


    }

}