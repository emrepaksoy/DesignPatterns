using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteBuilder
{
    public interface IVehicleBuilder
    {
        IVehicleBuilder SetVehicleModel(string model);
        RouteBuilderCon SetVehicleDriver(string driver);
    }
}
