using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{
    public abstract class EmployeeComponent
    {
        public abstract void Add(EmployeeComponent c);
        public abstract void Remove(EmployeeComponent c);
        public abstract void Display(int depth);
    }
}
