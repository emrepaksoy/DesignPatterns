
using LoadBalancer;

var b1 = SingletonLoadBalancer.GetLoadBalancer();
var b2 = SingletonLoadBalancer.GetLoadBalancer();

if (b1 == b2)
{
    Console.WriteLine("Same instance");
}

var balancer = SingletonLoadBalancer.GetLoadBalancer();

for (int i = 0; i < 20; i++)
{
    string serverName = balancer.NextServer.Name;
    Console.WriteLine("Dispatch request to: " + serverName);
}