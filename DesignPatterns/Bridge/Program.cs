using Bridge.Platforms;
using Bridge.Transmissions;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            StartLiveAdvanced(new TheLive());
            Console.ReadLine();
        }

        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde.. Iniciando Live");

            var live = new Live(platform);
            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Aguarde.. Iniciando Live");

            var live = new AdvancedLive(platform);
            live.Subtitles();
            live.Comments();
            live.Broadcasting();
            live.Record();
            live.Result();            
        }
    }
}
