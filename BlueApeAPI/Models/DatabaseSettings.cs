using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueApeAPI.Models
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
