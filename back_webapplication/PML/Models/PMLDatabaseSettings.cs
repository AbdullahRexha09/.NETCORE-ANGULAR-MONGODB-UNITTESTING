using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapplication.Models
{
    public class PMLDatabaseSettings : IPMLDatabaseSettings
    {
        public string UserCollectionName { get; set; } = "User";
        public string PMLLitsCollectionName { get; set; } = "PMLList";
        public string PMLTaskCollectionName { get; set; } = "PMLTask";
        public string ConnectionString { get; set; } = "mongodb://127.0.0.1:27017/?compressors=disabled&gssapiServiceName=mongodb";
        public string DatabaseName { get; set; } = "PMLDB";
    }
    public interface IPMLDatabaseSettings
    {
        string UserCollectionName { get; set; }
        string PMLLitsCollectionName { get; set; }
        string PMLTaskCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
