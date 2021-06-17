using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Platforms
{
    class Twitch : IPlatform
    {
        public Twitch()
        {
            ConfigureRMTP();
            Console.WriteLine("Twitch: Transmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Twitch: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Twitch: Configurando servidor RMTP");
        }
    }
}
