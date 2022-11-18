using DatabaseOperations.Databases.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Databases.Factory
{
    public class MySQLDatabaseFactory : IDatabaseFactory
    {
        public ICommand CreateCommand() =>  new MySQLCommand();
        

        public IConnection CreateConnection() => new MySQLConnection();
        
    }
}
