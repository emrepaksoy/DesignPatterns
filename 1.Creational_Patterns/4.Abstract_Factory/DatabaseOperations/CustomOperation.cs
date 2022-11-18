using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations
{
    public class CustomOperation
    {
        private ICommand _command;
        private IConnection _connection;
        
        public CustomOperation(IDatabaseFactory factory)
        {
            _command = factory.CreateCommand();
            _connection = factory.CreateConnection();   
        }

        public void RemoveById(int id)
        {
            _connection.OpenConnection();
            _command.ExecuteCommand("Delete .....");
            _connection.CloseConnection();
        }

        public void Add(int id)
        {
            _connection.OpenConnection();
            _command.ExecuteCommand("Insert .....");
            _connection.CloseConnection();
        }
    }
}
