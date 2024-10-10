// The other part of the client code constructs the actual chain.
using ChainOfResponsibility.Model;

var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();

monkey.SetNext(squirrel).SetNext(dog);

// The client should be able to send a request to any handler, not
// just the first one in the chain.
Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
Client.ClientCode(monkey);
Console.WriteLine();

Console.WriteLine("Subchain: Squirrel > Dog\n");
Client.ClientCode(squirrel);

class Client
{
    // The client code is usually suited to work with a single handler. In
    // most cases, it is not even aware that the handler is part of a chain.
    public static void ClientCode(AbstractHandler handler)
    {
        foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
        {
            Console.WriteLine($"Client: Who wants a {food}?");

            var result = handler.Handle(food);

            if (result != null)
            {
                Console.Write($"   {result}");
            }
            else
            {
                Console.WriteLine($"   {food} was left untouched.");
            }
        }
    }
}