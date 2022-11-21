using BasicStrategyPattern;

Context context;

context = new Context(new ConcreteStrategyA());
context.ContextInterface();
context = new Context(new ConcreteStrategyB());
context.ContextInterface();
context = new Context(new ConcreteStrategyC());
context.ContextInterface();