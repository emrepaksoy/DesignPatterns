using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Converter
{
    public class ThirdParyAPI
    {
		public XDocument GetXML()
		{
			var xDocument = new XDocument();
			var xElement = new XElement("Customers");
			var xAttributes = CustomerDataProvider.GetData()
				.Select(m => new XElement("Customer",
									new XAttribute("City", m.City),
									new XAttribute("Name", m.Name),
									new XAttribute("Address", m.Address)));

			xElement.Add(xAttributes);
			xDocument.Add(xElement);
			return xDocument;
		}

	}

	public static class CustomerDataProvider
	{
		public static List<Customer> GetData() =>
		   new List<Customer>
		   {
			new Customer { City = "Italy", Name = "Alfa Romeo", Address = "Address1" },
			new Customer { City = "UK", Name = "Aston Martin", Address = "Address1"  },
			new Customer { City = "USA", Name = "Dodge", Address = "Address1"  },
			new Customer { City = "Japan", Name = "Subaru", Address = "Address1"  },
			new Customer { City = "Germany", Name = "BMW", Address = "Address1"  }
		   };
	}
	public class Customer
	{
		public string Name { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
	}
}
