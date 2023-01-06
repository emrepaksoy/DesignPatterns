## Abstract Factory Pattern

Modularization is a big issue in today's programming. Programmers all over the world are trying to avoid the idea of adding code to existing classes in order to make them support encapsulating more general information. Take the case of a information manager which manages phone number. Phone numbers have a particular rule on which they get generated depending on areas and countries. If at some point the application should be changed in order to support adding numbers form a new country, the code of the application would have to be changed and it would become more and more complicated.

In order to prevent it, the Abstract Factory design pattern is used. Using this pattern a framework is defined, which produces objects that follow a general pattern and at runtime this factory is paired with any concrete factory to produce objects that follow the pattern of a certain country. In other words, the Abstract Factory is a super-factory which creates other factories (Factory of factories).

* Abstract Factory offers the interface for creating a family of related objects, without explicitly specifying their classes.

## Implementation

The pattern basically works as shown below, in the UML diagram:

![](https://github.com/emrepaksoy/DesignPatterns/blob/master/1.Creational_Patterns/4.Abstract_Factory/BasicAbstractFactoryPattern/abstract.png)

The classes that participate to the Abstract Factory pattern are:

* AbstractFactory - declares a interface for operations that create abstract products.
* ConcreteFactory - implements operations to create concrete products.
* AbstractProduct - declares an interface for a type of product objects.
* Product - defines a product to be created by the corresponding ConcreteFactory; it implements the AbstractProduct interface.
* Client - uses the interfaces declared by the AbstractFactory and AbstractProduct classes.

The AbstractFactory class is the one that determines the actual type of the concrete object and creates it, but it returns an abstract pointer to the concrete object just created. This determines the behavior of the client that asks the factory to create an object of a certain abstract type and to return the abstract pointer to it, keeping the client from knowing anything about the actual creation of the object.

The fact that the factory returns an abstract pointer to the created object means that the client doesn't have knowledge of the object's type. This implies that there is no need for including any class declarations relating to the concrete type, the client dealing at all times with the abstract type. The objects of the concrete type, created by the factory, are accessed by the client only through the abstract interface.

The second implication of this way of creating objects is that when the adding new concrete types is needed, all we have to do is modify the client code and make it use a different factory, which is far easier than instantiating a new type, which requires changing the code wherever a new object is created.

you can check out the The classic implementation for the Abstract Factory pattern [here](https://github.com/emrepaksoy/DesignPatterns/tree/master/1.Creational_Patterns/4.Abstract_Factory/BasicAbstractFactoryPattern)

We should use the Abstract Factory design pattern when:

* the system needs to be independent from the way the products it works with are created.
* the system is or should be configured to work with multiple families of products.
* a family of products is designed to work only all together.
* the creation of a library of products is needed, for which is relevant only the interface, not the implementation, too.


