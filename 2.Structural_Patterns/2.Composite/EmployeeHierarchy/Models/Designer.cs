using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeeHierarchy.position;

namespace EmployeeHierarchy.Models
{
    public class Designer : BaseModel
    {
        public Designer(Position position, string name) : base(position, name)
        {
        }
    }
}
