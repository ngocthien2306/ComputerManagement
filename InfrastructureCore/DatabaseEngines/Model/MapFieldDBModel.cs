using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureCore.DatabaseEngines.Model
{
    public class MapFieldDBModel
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public Type Type { get; set; }
    }
}
