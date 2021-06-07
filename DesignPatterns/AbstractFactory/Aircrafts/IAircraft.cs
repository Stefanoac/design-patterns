using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Aircrafts
{
    interface IAircraft
    {
        void CheckWind();
        void StartRoute();
        void GetCargo();
    }
}
