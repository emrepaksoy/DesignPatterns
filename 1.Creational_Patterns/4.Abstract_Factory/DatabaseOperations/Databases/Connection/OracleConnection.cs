using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Databases.Connection
{
    public class OracleConnection : IConnection
    {
        public bool CloseConnection() => true;

        public bool OpenConnection() => true;
    }
}
