using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    public class PaymentContext
    {
        private IPayment PaymentStrategy;
      
        public void SetPaymentStrategy(IPayment strategy)
        {
            this.PaymentStrategy = strategy;
        }
        public void Pay(double amount)
        {
            PaymentStrategy.Pay(amount);
        }
    }
}
