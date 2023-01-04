## Factory Pattern

The Factory Design Pattern is probably the most used design pattern in modern programming languages like Java and C#. It comes in different variants and implementations. If you are searching for it, most likely, you'll find references about the GoF patterns: Factory Method and Abstract Factory.

 

In this article we'll describe a flavor of factory pattern commonly used nowdays. You can also check the original Factory Method pattern which is very similar.

![](https://github.com/emrepaksoy/DesignPatterns/blob/master/1.Creational_Patterns/2.Factory/BasicFactoryPattern/factory_pattern_uml_diagram.jpg)

The implementation is really simple

* The client needs a product, but instead of creating it directly using the new operator, it asks the factory object for a new product, providing the information about the type of object it needs.
* The factory instantiates a new concrete product and then returns to the client the newly created product(casted to abstract product class).
* The client uses the products as abstract products without being aware about their concrete implementation.


