
using BasicFactoryPattern;

ShapeFactory shapeFactory = new ShapeFactory();
IShape shape = shapeFactory.GetShape("Rectangle");
IShape shape2 = shapeFactory.GetShape("Square");

shape.draw();
shape2.draw();

