using Builder.Components;

namespace Builder.Products
{
    class Vehicle
    {        
        private int seats;
        private Engine engine;
        private AirBag airbag;
        private Transmission transmission;
        private VehicleType vehicleType;

        public int Seats
        {
            get => seats;
            set => seats = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public AirBag AirBag
        {
            get => airbag;
            set => airbag = value;
        }

        public Transmission Transmission
        {
            get => transmission;
            set => transmission = value;
        }

        public VehicleType VehicleType
        {
            get => vehicleType;
            set => vehicleType = value;
        }

    }
}
