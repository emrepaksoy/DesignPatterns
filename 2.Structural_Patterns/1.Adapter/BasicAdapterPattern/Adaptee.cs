using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAdapterPattern
{
    public class Adaptee
    {
        public void SpecificRequest() => Console.WriteLine("Called SpecificRequest()...");
    }
}
