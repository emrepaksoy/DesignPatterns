using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteBuilder
{
    public class Route
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Address Address { get; set; }
        public Vehicle Vehicle { get; set; }

        public static RouteBuilderCon Builder => new RouteBuilderCon();
    }
}
