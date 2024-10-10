using Proxy.Interface;
using Proxy.Model;

Client client = new Client();

Console.WriteLine("Client: Executing the client code with a real subject:");
RealSubject realSubject = new RealSubject();
client.ClientCode(realSubject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
ProxyDP proxy = new ProxyDP(realSubject);
client.ClientCode(proxy);

public class Client
{
    // The client code is supposed to work with all objects (both subjects
    // and proxies) via the Subject interface in order to support both real
    // subjects and proxies. In real life, however, clients mostly work with
    // their real subjects directly. In this case, to implement the pattern
    // more easily, you can extend your proxy from the real subject's class.
    public void ClientCode(ISubjectProxy subject)
    {
        // ...

        subject.Request();

        // ...
    }
}