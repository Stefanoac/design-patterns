using System;

namespace AbstractFactory.Aircrafts
{
    class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Ventos verificados, ventos a 25km, ventos ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros a bordo, voô autorizado");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciado decolagem");
        }
    }
}
