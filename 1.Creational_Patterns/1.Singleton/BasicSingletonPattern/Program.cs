
using BasicSingletonPattern;


//Singleton instance = Singleton.GetInstance();
//Singleton instance2 = Singleton.GetInstance();

Singleton instance = Singleton.GetInstance;
Singleton instance2 = Singleton.GetInstance;

instance.doSomeThing();

if(instance.Equals(instance2))
    Console.WriteLine("True");

