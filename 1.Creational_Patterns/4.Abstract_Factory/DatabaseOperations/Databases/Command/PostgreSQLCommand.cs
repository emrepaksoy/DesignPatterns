using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Databases
{
    public class PostgreSQLCommand : ICommand
    {
        public void ExecuteCommand(string query) => Console.WriteLine("PostgreSQL Command");
        
    }
}
