using ChainOfResponsability.Servers;
using System;

namespace ChainOfResponsability.Middlewares
{
    class CheckUserMiddleware : Middleware
    {
        private Server _server;

        public CheckUserMiddleware(Server server)
        {
            this._server = server;
        }

        public override bool Check(string email, string password)
        {
            if (!this._server.HasEmail(email))
            {
                Console.WriteLine("E-mail inválido");
                return false;
            }

            if (!this._server.IsValidPassword(email, password))
            {
                Console.WriteLine("E-mail e/ou senha inválidos");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
