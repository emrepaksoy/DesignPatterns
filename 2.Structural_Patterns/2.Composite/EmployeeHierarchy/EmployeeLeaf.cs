using EmployeeHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{
    public class EmployeeLeaf : EmployeeComponent
    {
        protected BaseModel model;

        public EmployeeLeaf(BaseModel model)
        {
            this.model = model;
        }

        public override void Add(EmployeeComponent c) => Console.WriteLine("Cannot add to a leaf");
        
        public override void Remove(EmployeeComponent c)=>Console.WriteLine("Cannot remove from a leaf");
        

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + $"name: {model.Name}, position:{model.Position}");
        }
    }
}
