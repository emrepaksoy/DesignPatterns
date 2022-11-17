using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancer
{
    public sealed class SingletonLoadBalancer
    {
        private static readonly SingletonLoadBalancer Instance = new SingletonLoadBalancer();

        private readonly List<Server> servers;
        private readonly Random random = new Random();

        private SingletonLoadBalancer()
        {

            servers = new List<Server> {
               new Server{ Name = "ServerI", IP = "120.14.220.18" },
                  new Server{ Name = "ServerII", IP = "120.14.220.19" },
                  new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                  new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                  new Server{ Name = "ServerV", IP = "120.14.220.22" },
            };
        }

        public static SingletonLoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                int r = random.Next(servers.Count);
                return servers[r];
            }
        }

    }
}
