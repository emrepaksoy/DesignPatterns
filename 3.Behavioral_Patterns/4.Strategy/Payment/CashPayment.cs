using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    public class CashPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " By Cash");
        }
    }
}
