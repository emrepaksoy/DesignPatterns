using DatabaseOperations.Databases.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Databases.Factory
{
    public class PostgreSQLDatabaseFactory : IDatabaseFactory
    {
        public ICommand CreateCommand() => new PostgreSQLCommand();

        public IConnection CreateConnection() => new PostgreSQLConnection();
    }
}
