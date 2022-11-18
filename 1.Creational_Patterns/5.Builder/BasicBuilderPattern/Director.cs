using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBuilderPattern
{
    public class Director
    {
        public void Constract(Builder builer)
        {
            builer.BuildPartA();
            builer.BuildPartB();
        }
    }
}
