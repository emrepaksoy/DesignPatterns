using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations
{
    public interface IDatabaseFactory
    {
        IConnection CreateConnection();
        ICommand CreateCommand();
    }
}
