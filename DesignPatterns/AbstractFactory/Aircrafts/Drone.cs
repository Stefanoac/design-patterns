using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Ventos ok, para o drone");
        }

        public void GetCargo()
        {
            Console.WriteLine("Encomenda pega, drone pronto para envio");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciado envio via drone");
        }
    }
}
