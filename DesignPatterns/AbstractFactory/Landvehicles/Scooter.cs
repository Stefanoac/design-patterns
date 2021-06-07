using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Landvehicles
{
    class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda para envio via patinete.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega via patinete.");
        }
    }
}
