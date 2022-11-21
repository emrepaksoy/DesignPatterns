using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeeHierarchy.position;

namespace EmployeeHierarchy.Models
{
    public abstract class BaseModel
    {
        public string Name { get; set; }

        public Position Position { get; set; }

        protected BaseModel(Position position, string name)
        {
            Position = position;
            Name = name;
        }
    }
}
