using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBridgePattern
{
    public class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public virtual void Operation()
        {
            implementor.Operation();
        }
    }

    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }

}
