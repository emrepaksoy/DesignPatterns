using BasicDecoratorPattern;

ConcreteComponent c = new ConcreteComponent();
ConcreteDecoratorA d1 = new ConcreteDecoratorA();
ConcreteDecoratorB d2 = new ConcreteDecoratorB();
// Link decorators
d1.SetComponent(c);
d2.SetComponent(d1);
d2.Operation();
