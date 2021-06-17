using System;

namespace ChainOfResponsability.Middlewares
{
    abstract class Middleware
    {
        private Middleware _next;

        public Middleware Linkwith(Middleware next)
        {
            this._next = next;

            return next;
        }

        public abstract Boolean Check(string email, string password);

        protected Boolean CheckNext(string email, string password)
        {
            if (_next == null)
            {
                return true;
            }

            return this._next.Check(email, password);
        }
    }
}
