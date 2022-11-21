using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicIteratorPattern
{
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
