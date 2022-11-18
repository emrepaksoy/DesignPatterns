using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteBuilder
{
    public interface IAddressBuilder
    {
        IAddressBuilder SetStreetName(string name);
        RouteBuilderCon SetStreetNumber(int number);

    }
}
