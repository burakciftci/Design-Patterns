// The client code.
using State.Model;

var context = new Context(new ConcreteStateA());
context.Request1();
context.Request2();
