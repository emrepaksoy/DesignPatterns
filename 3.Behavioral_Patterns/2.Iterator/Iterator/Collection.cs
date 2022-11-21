using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Collection : IAbstractCollection
    {
        List<Item> items = new List<Item>();

        public Iteratorr CreateIterator()
        {
            return new Iteratorr(this);
        }
        public int Count
        {
            get { return items.Count; }
        }

        public Item this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }
}
