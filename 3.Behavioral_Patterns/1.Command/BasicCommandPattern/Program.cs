using BasicCommandPattern;

Command command = new ConcreteCommand(new Receiver());
Invoker invoker = new Invoker();
// Set and execute command
invoker.SetCommand(command);
invoker.ExecuteCommand();
