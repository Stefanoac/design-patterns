using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server _server;

        static void Main(string[] args)
        {
            Init();

            var done = false;

            do
            {
                Console.WriteLine("Digite o seu e-mail: ");
                string email = Console.ReadLine();

                Console.WriteLine("Digite sua senha");
                string password = Console.ReadLine();

                done = _server.LogIn(email, password);

            } while (!done);

            Console.ReadLine();
        }

        static void Init()
        {
            _server = new Server();

            _server.RegisterUser("master@hcode.com.br", "123456");
            _server.RegisterUser("user@hcode.com.br", "12345689");

            var middleware = new CheckUserMiddleware(_server);
            middleware.Linkwith(new CheckPermissionMiddleware());
            middleware.Linkwith(new CheckWeakPasswordMiddleware());
            
            _server.SetMiddleware(middleware);



        }
    }
}
