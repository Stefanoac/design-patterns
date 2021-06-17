using Bridge.Platforms;
using System;

namespace Bridge.Transmissions
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform)
            : base(platform)
        {

        }

        public void Subtitles()
        {
            Console.WriteLine("Legendas ativadas na transmissão");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários ativadas na Live");
        }

        public void Record()
        {
            Console.WriteLine("Iniciando a gravação da Live");
        }
    }
}
