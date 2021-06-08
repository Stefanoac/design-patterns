using Builder.Builders;
using Builder.Directors;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new VehicleBuilder();
            var director = new Director(builder);

            // Sedan
            director.ConstructSedanCar();
            var sedan = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo: {sedan.VehicleType}");


            // Truck
            director.ConstructTruck();
            var truck = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo: {truck.VehicleType}");


            // SUV
            director.ConstructSVU();
            var suv = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo: {suv.VehicleType}, com {suv.AirBag.Quantity} air bags");


            Console.ReadLine();

        }
    }
}
