using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{
    public class EmployeeComposite : EmployeeComponent
    {
        protected string name;

        public EmployeeComposite(string name)
        {
            this.name = name;
        }

        List<EmployeeComponent> components = new List<EmployeeComponent>();

        public override void Add(EmployeeComponent c) => components.Add(c);
        public override void Remove(EmployeeComponent c) => components.Remove(c);
        
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            // Recursively display child nodes
            foreach (EmployeeComponent component in components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
