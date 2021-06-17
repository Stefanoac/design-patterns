using System;

namespace ChainOfResponsability.Middlewares
{
    class CheckWeakPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("123456"))
            {
                Console.WriteLine("Senha frágil, por favor alterar senha para mais segurança");
            }

            return CheckNext(email, password);
        }
    }
}
