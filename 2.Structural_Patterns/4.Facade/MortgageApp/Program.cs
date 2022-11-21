using MortgageApp;

Mortgage mortgage = new Mortgage();

Customer customer = new Customer("Ann McKinsey");

bool eligible = mortgage.IsEligible(customer, 12000);

Console.WriteLine("\n" + customer.Name +
        " has been " + (eligible ? "Approved" : "Rejected"));
