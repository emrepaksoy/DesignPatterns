## Builder Pattern

The more complex an application is the complexity of classes and objects used increases. Complex objects are made of parts produced by other objects that need special care when being built. An application might need a mechanism for building complex objects that is independent from the ones that make up the object. If this is the problem you are being confronted with, you might want to try using the Builder (or Adaptive Builder) design pattern.

This pattern allows a client object to construct a complex object by specifying only its type and content, being shielded from the details related to the object�s representation. This way the construction process can be used to create different representations. The logic of this process is isolated form the actual steps used in creating the complex object, so the process can be used again to create a different object form the same set of simple objects as the first one.

* Defines an instance for creating an object but letting subclasses decide which class to instantiate
* Refers to the newly created object through a common interface

## Implemantation

The Builder design pattern uses the Factory Builder pattern to decide which concrete class to initiate in order to build the desired type of object, as we will see below in the UML diagram:

![](https://github.com/emrepaksoy/DesignPatterns/blob/master/1.Creational_Patterns/5.Builder/BasicBuilderPattern/builder.png)

The participants classes in this pattern are:

* The Builder class specifies an abstract interface for creating parts of a Product object.
* The ConcreteBuilder constructs and puts together parts of the product by implementing the Builder interface. It defines and keeps track of the representation it creates and provides an interface for saving the product.
* The Director class constructs the complex object using the Builder interface.
* The Product represents the complex object that is being built.

The client, that may be either another object or the actual client that calls the main() method of the application, initiates the Builder and Director class. The Builder represents the complex object that needs to be built in terms of simpler objects and types. The constructor in the Director class receives a Builder object as a parameter from the Client and is responsible for calling the appropriate methods of the Builder class. In order to provide the Client with an interface for all concrete Builders, the Builder class should be an abstract one. This way you can add new types of complex objects by only defining the structure and reusing the logic for the actual construction process. The Client is the only one that needs to know about the new types, the Director needing to know which methods of the Builder to call.

Builder Pattern is used when:

* the creation algorithm of a complex object is independent from the parts that actually compose the object
* the system needs to allow different representations for the objects that are being built
