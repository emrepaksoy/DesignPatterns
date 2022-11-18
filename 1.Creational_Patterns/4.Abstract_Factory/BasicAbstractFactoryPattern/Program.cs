
using BasicAbstractFactoryPattern;
using BasicAbstractFactoryPattern.Factory;

AbstractFactory factory = new ConcreteFactory1();

Client client = new Client(factory);
client.Run();

AbstractFactory factory1 = new ConcreteFactory2();
client = new Client(factory1);
client.Run();


