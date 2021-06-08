using Builder.Components;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builders
{
    interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void SetAirbag(AirBag airbag);
        void SetTransmission(Transmission transmission);
        void SetVehicleType(VehicleType vehicleType);
    }
}
