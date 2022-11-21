using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProxyPattern
{
    public class Proxy : Subject
    {
        private RealSubject realSubject;
        public override void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}
