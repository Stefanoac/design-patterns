using FactoryMethod.Vehicles;
using System;

namespace FactoryMethod.Factories
{
    class CarTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
