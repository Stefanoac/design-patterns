using Builder.Components;
using Builder.Products;
using System;

namespace Builder.Builders
{
    class VehicleBuilder : IBuilder
    {
        // Produto
        private Vehicle vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            var result = vehicle;
            Reset();

            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void SetEngine(Engine engine)
        {
            vehicle.Engine = engine;
        }

        public void SetAirbag(AirBag airbag)
        {
            vehicle.AirBag = airbag;
        }

        public void SetSeats(int seats)
        {
            vehicle.Seats = seats;
        }

        public void SetAirBags(AirBag airbag)
        {
            vehicle.AirBag = airbag;
        }

        public void SetTransmission(Transmission transmission)
        {
            vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            vehicle.VehicleType = vehicleType;
        }
    }
}
