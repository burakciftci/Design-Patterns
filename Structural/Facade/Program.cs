// The client code may have some of the subsystem's objects already
// created. In this case, it might be worthwhile to initialize the
// Facade with these objects instead of letting the Facade create
// new instances.
using Facade.Model;

Subsystem1 subsystem1 = new Subsystem1();
Subsystem2 subsystem2 = new Subsystem2();
ModelFacade facade = new ModelFacade(subsystem1, subsystem2);
Client.ClientCode(facade);

class Client
{
    // The client code works with complex subsystems through a simple
    // interface provided by the Facade. When a facade manages the lifecycle
    // of the subsystem, the client might not even know about the existence
    // of the subsystem. This approach lets you keep the complexity under
    // control.
    public static void ClientCode(ModelFacade facade)
    {
        Console.Write(facade.Operation());
    }
}