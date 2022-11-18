using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAbstractFactoryPattern
{
    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name +
             " interacts with " + a.GetType().Name);
        }
    }

    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name +
             " interacts with " + a.GetType().Name);
        }
    }
}
