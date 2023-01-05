## Factory Method Pattern 

Also known as Virtual Constructor, the Factory Method is related to the idea on which libraries work: a library uses abstract classes for defining and maintaining relations between objects. One type of responsibility is creating such objects. The library knows when an object needs to be created, but not what kind of object it should create, this being specific to the application using the library.

The Factory method works just the same way: it defines an interface for creating an object, but leaves the choice of its type to the subclasses, creation being deferred at run-time. A simple real life example of the Factory Method is the hotel. When staying in a hotel you first have to check in. The person working at the front desk will give you a key to your room after you've paid for the room you want and this way he can be looked at as a �room� factory. While staying at the hotel, you might need to make a phone call, so you call the front desk and the person there will connect you with the number you need, becoming a �phone-call� factory, because he controls the access to calls, too.

* Defines an interface for creating objects, but let subclasses to decide which class to instantiate
* Refers to the newly created object through a common interface

## Implementation 

The pattern basically works as shown below, in the UML diagram:

![](https://github.com/emrepaksoy/DesignPatterns/blob/master/1.Creational_Patterns/3.Factory_Method/BasicFactoryMethodPattern/factory.png)

The participants classes in this pattern are:
* Product defines the interface for objects the factory method creates.
* ConcreteProduct implements the Product interface.
* Creator(also refered as Factory because it creates the Product objects) declares the method FactoryMethod, which returns a Product object. May call the generating method for creating Product objects
* ConcreteCreator overrides the generating method for creating ConcreteProduct objects

All concrete products are subclasses of the Product class, so all of them have the same basic implementation, at some extent. The Creator class specifies all standard and generic behavior of the products and when a new product is needed, it sends the creation details that are supplied by the client to the ConcreteCreator. Having this diagram in mind, it is easy for us now to produce the code related to it. Here is how the implementation of the classic Factory method should look:

```C#
public interface IProduct{}

public abstract class Creator
{
  public void Operation()
  {
    IProduct product = FactoryMethod(); 
  }
  
  protected abstract IProduct FactoryMethod();
}

public class ConcreteProduct : IProduct{}

public class ConcreteCreator : Creator
{
  protected IProduct FactoryMethod()
  {
    return new ConcreteProduct();
  }
}

public class Client
{
  Creator creator = new ConcreteCreator();
  creator.Operation();
}
```
The need for implementing the Factory Method is very frequent. The cases are the ones below:
* when a class can't anticipate the type of the objects it is supposed to create
* when a class wants its subclasses to be the ones to specific the type of a newly created object

When you design an application just think if you really need it a factory to create objects. Maybe using it will bring unnecessary complexity in your application. Anyway if you have many object of the same base type and you manipulate them mostly as abstract objects, then you need a factory.
