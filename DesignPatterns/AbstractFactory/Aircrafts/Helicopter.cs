using System;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Vento sudeste, vento ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok, ligando as helices");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciado decolagem");
        }
    }
}
