using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Platforms
{
    class TheLive : IPlatform
    {
        public TheLive()
        {
            ConfigureRMTP();
            Console.WriteLine("TheLive: Transmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("TheLive: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("TheLive: Configurando servidor RMTP");
        }
    }
}
