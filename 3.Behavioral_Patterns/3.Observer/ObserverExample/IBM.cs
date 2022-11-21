using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class IBM : Stock
    {
        public IBM(string symbol, double price)
           : base(symbol, price)
        {
        }
    }
}
