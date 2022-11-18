using Converter;

var adapterResult = new XmlToJsonAdapter(new ThirdParyAPI()).ConvertXmlToJson();
Console.WriteLine(adapterResult.ToString());
