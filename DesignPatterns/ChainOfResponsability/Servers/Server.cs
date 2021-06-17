using ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;

namespace ChainOfResponsability.Servers
{
    class Server
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();

        private Middleware _middleware;

        public void SetMiddleware(Middleware middleware)
        {
            this._middleware = middleware;
        }

        public Boolean LogIn(string email, string password)
        {
            if (this._middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autorizado com sucesso!");
                Console.WriteLine("Seja bem vindo");

                return true;
            }

            return false;
        }

        public void RegisterUser(string email, string password)
        {
            this._users[email] = password;
        }

        public Boolean HasEmail(string email)
        {
            return this._users.ContainsKey(email);
        }

        public Boolean IsValidPassword(string email, string password)
        {
            var value = string.Empty;
            this._users.TryGetValue(email, out value);

            return password == value;
        }
    }
}
