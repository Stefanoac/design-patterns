using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Landvehicles
{
    interface ILandVehicle
    {
        void StartRoute();
        void GetCargo();
    }
}
