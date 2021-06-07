using AbstractFactory.App;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();
        }

        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;
            string company = "Line";

            if (company == "Uber")
            {
                transportFactory = new UberTransport();
            }
            else if (company == "Nine")
            {
                transportFactory = new NineNineTransport();
            }
            else
            {
                transportFactory = new LineTransport();
            }

            app = new Application(transportFactory);

            return app;
        }
    }
}
