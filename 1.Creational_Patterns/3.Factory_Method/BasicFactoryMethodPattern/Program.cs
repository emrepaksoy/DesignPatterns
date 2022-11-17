
using BasicFactoryMethodPattern;

Creator[] creators = new Creator[2];

creators[0] = new ConcreteCreatorA();
creators[1] = new ConcreteCreatorB();

foreach (var creator in creators)
{
    Product product = creator.FactoryMethod();
    Console.WriteLine($"Created {product.GetType().Name}");
}

