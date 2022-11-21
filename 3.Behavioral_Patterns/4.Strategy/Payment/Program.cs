using Payment;

PaymentContext context = new PaymentContext();

context.SetPaymentStrategy(new CreditCardPayment());

context.Pay(1050);

context.SetPaymentStrategy(new DebitCardPayment());
context.Pay(2000);