using Cutomers;

var customers = new Customer();
// Set ConcreteImplementor
customers.Data = new CustomersData("Chicago");
// Exercise the bridge
customers.Show();
customers.Next();
customers.Show();
customers.Next();
customers.Show();
customers.Add("Henry Velasquez");
customers.ShowAll();

