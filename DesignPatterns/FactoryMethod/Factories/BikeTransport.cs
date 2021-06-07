using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    class BikeTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}
