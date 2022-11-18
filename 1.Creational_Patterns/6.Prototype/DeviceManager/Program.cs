
using DeviceManager;

DevicePrototypeRegistry _deviceRegistry = new DevicePrototypeRegistry();

var smartphone = new SmartPhone() { Id = 1, Name = "IPhone"};
_deviceRegistry.Add(smartphone);

var copy = _deviceRegistry.GetCopyById(1);
copy.Id = 2;

Console.WriteLine($"Smart Phone: {smartphone.Id}, {smartphone.Name}");
Console.WriteLine($"Copy Smart Phone: {copy.Id}, {copy.Name}");


