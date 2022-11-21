using BasicBridgePattern;

Abstraction ab = new RefinedAbstraction();

ab.Implementor = new ConcreteImplementorA();
ab.Operation();

ab.Implementor = new ConcreteImplementorB();
ab.Operation();