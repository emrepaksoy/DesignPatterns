using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrototypePattern
{
    public abstract class Prototype
    {

        public string Id { get; }

        public Prototype(string id)
        {
            Id = id;
        }

        public abstract Prototype Clone();

    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1( string id): base(id)
        {

        }
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id)
        {
        }

        public override Prototype Clone() => (Prototype)this.MemberwiseClone();
    }
}
