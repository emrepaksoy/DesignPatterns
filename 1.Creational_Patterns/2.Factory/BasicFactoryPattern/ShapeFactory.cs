using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFactoryPattern
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
                return null;
            switch (shapeType)
            {
                case "Rectangle":
                    return new Rectangle();
                case "Square":
                    return new Square();
                default: throw new ArgumentException();
            }
        }
    
    }
}
