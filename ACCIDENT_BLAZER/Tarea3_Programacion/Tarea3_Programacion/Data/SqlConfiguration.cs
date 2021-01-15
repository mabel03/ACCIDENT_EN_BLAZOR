using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea3_Programacion.Data
{
    public class SqlConfiguration
    {
        public SqlConfiguration()
        {
        }

        public SqlConfiguration(string connectionString) => ConnectionString = connectionString;

        public string ConnectionString { get; }
    }
}
