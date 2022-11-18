using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteBuilder
{
    public class RouteBuilderCon : IAddressBuilder, IVehicleBuilder
    {
        private Route _route;

        public RouteBuilderCon NewRoute()
        {
            _route = new Route
            {
                StartTime = DateTime.Now
            };
            return this;
        }

        public RouteBuilderCon SetId(int id)
        {
            _route.Id = id;
            return this;
        }

        public RouteBuilderCon SetEndTime(DateTime dateTime)
        {
            _route.EndTime = dateTime;
            return this;
        }
        public RouteBuilderCon SetStreetNumber(int number)
        {
            if (_route.Address == null || string.IsNullOrEmpty(_route.Address.StreetName))
            {
                throw new Exception("Address not initialized. Please set the street name");
            }

            _route.Address.Number = number;
            return this;
        }


        public IAddressBuilder SetStreetName(string name)
        {
            _route.Address = new Address()
            {
                StreetName = name
            };

            return this;
        }

        public IVehicleBuilder SetVehicleModel(string model)
        {
            _route.Vehicle = new Vehicle()
            {
                Model = model
            };

            return this;
        }
        public RouteBuilderCon SetVehicleDriver(string driver)
        {
            if (_route.Vehicle == null || string.IsNullOrEmpty(_route.Vehicle.Model))
            {
                throw new Exception("Vehicle not initialized. Please set the vehicle model");
            }

            _route.Vehicle.Driver = driver;
            return this;
        }

        public Route Build()
        {
            // validate all required parameters
            return _route;
        }
    }
}
