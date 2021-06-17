﻿using System;

namespace Adapter
{
    class Paypal : IPaypalPayment
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando pagamento com PayPal");
        }

        public void PayPalReceive()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}
