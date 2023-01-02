## Singleton Pattern

Sometimes it's important to have only one instance for a class. For example, in a system there should be only one window manager (only a file system or only a print spooler). Usually singletons are used for centralized management of internal or external resources and they provide a global point of access to themselves.

The singleton pattern is one of the simplest design patterns: it involves only one class which is responsible to make sure there is no more than one instance; it does it by instantiating itself and in the same time it provides a global point of access to that instance. By doing it, the singleton class ensures the same instance can be used from everywhere, preventing direct invocation of the singleton constructor


## Implementation 

The implementation involves a static member in the Singleton class which keeps the reference to the instance, a private constructor and a static public method that returns the static member reference.

![](https://github.com/emrepaksoy/DesignPatterns/blob/master/1.Creational_Patterns/1.Singleton/BasicSingletonPattern/Singleton.png)

The Singleton Pattern defines a getInstance operation which exposes the unique instance which is accessed by the clients. getInstance() is is responsible for creating its class unique instance in case it is not created yet and to return that instance.

```C# 
public class Singleton
{
    private static Singleton Instance;
    private Singleton()
    {
      ...
    }
    public static Singleton GetInstance()
    {
      if(Instance == null)
         Instance = new Singleton();
      return Instance ;
    }
    
    public void DoSomething()
    {
      Console.WriteLine("asd asd");
    }
}

```

You can notice in the above code that `GetInstance` method ensures that only one instance of the class is created. The constructor should not be accessible from the outside of the class to ensure the only way of instantiating the class would be only through the getInstance method.

The `GetInstance` method is used also to provide a global point of access to the object and it can be used in the following manner:

```C#
Singleton.GetInstance().DoSomething();

//You can also see that the objects are the same

Singleton instance = Singleton.GetInstance();
Singleton instance2 = Singleton.GetInstance();

if (instance.Equals(instance2))
    Console.WriteLine("True");
    
```
## Applicability & Examples

According to the definition the singleton pattern should be used when there must be exactly one instance of a class, and when it must be accessible to clients from a global access point. Here are some real situations where the singleton is used:

**Example 1 - Logger Classes**

The Singleton pattern is used in the design of logger classes. This classes are ussualy implemented as a singletons, and provides a global logging access point in all the application components without being necessary to create an object each time a logging operations is performed.

**Example 2 - Configuration Classes**
The Singleton pattern is used to design the classes which provides the configuration settings for an application. By implementing configuration classes as Singleton not only that we provide a global access point, but we also keep the instance we use as a cache object. When the class is instantiated( or when a value is read ) the singleton will keep the values in its internal structure. If the values are read from the database or from files this avoids the reloading the values each time the configuration parameters are used.

**Example 3 - Accesing resources in shared mode**

It can be used in the design of an application that needs to work with the serial port. Let's say that there are many classes in the application, working in an multi-threading environment, which needs to operate actions on the serial port. In this case a singleton with synchronized methods could be used to be used to manage all the operations on the serial port.

**Example 4 - Factories implemented as Singletons**

Let's assume that we design an application with a factory to generate new objects(Acount, Customer, Site, Address objects) with their ids, in an multithreading environment. If the factory is instantiated twice in 2 different threads then is possible to have 2 overlapping ids for 2 different objects. If we implement the Factory as a singleton we avoid this problem. Combining Abstract Factory or Factory Method and Singleton design patterns is a common practice.




