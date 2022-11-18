using RouteBuilder;

var route = Route.Builder.NewRoute()
  .SetId(1)
  .SetStreetName("My Street")
  .SetStreetNumber(5)
  .SetVehicleModel("Ford Fiesta")
  .SetVehicleDriver("John Doe")
  .SetEndTime(DateTime.Now.AddMinutes(15))
  .Build();

Console.WriteLine($"Id: {route.Id}\n" +
    $"Address : {route.Address.StreetName}, {route.Address.Number}\n" +
    $"Vehicle Driver: {route.Vehicle.Driver}\n" +
    $"Vehicle Model: {route.Vehicle.Model}\n" +
    $"Route start time: {route.StartTime}\n" +
    $"Route end time: {route.EndTime}");