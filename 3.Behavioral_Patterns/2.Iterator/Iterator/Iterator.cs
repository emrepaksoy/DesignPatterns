using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Iteratorr : IAbstractIterator
    {
        Collection collection;
        int current = 0;
        int step = 1;
        public int Step
        {
            get { return step; }
            set { step = value; }
        }
        public Iteratorr(Collection collection)
        {
            this.collection = collection;
        }

        public bool IsDone
        {
            get { return current >= collection.Count; }
        }

        public Item CurrentItem
        {
            get { return collection[current] as Item; }
        }
        public Item First()
        {
            current = 0;
            return collection[current] as Item;
        }

        public Item Next()
        {
            current += step;
            if (!IsDone)
                return collection[current] as Item;
            else
                return null;
        }
    }
}
