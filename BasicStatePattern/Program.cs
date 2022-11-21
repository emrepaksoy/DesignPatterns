using BasicStatePattern;

var context = new Context(new ConcreteStateA());
// Issue requests, which toggles state
context.Request();
context.Request();
context.Request();
context.Request();