using Manager;

EmployeeManagerFactory empFactory = new EmployeeManagerFactory();

IEmployeeManager empManager = empFactory.GetEmployeeManager(1);
IEmployeeManager empManager2 = empFactory.GetEmployeeManager(2);


Console.WriteLine($"Employee 1\nBonus :{empManager.GetBonus()}, Hourly Pay: {empManager.GetPay()}");
Console.WriteLine($"Employee 2\nBonus :{empManager2.GetBonus()}, Hourly Pay: {empManager2.GetPay()}");
