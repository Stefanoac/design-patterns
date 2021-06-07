using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    class LineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
