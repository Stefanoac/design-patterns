using Bridge.Platforms;
using System;

namespace Bridge.Transmissions
{
    class Live : ITransmission
    { 
        protected IPlatform _platform;

        public Live(IPlatform platform)
        {
            this._platform = platform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na plataforma: {_platform}");
        }

        public void Result()
        {
            Console.WriteLine($"*** ON AIR ***");
        }
    }
}
