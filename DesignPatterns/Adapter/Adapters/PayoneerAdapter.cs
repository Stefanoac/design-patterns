using System;

namespace Adapter
{
    class PayoneerAdapter : IPaypalPayment
    {
        private Payoneer _payoneer;

        public PayoneerAdapter(Payoneer payoneer)
        {
            this._payoneer = payoneer;
            Console.WriteLine("Realizando adaptação do payoneer para paypal;");
        }

        public Token AuthToken()
        {
            return this._payoneer.AuthToken();
        }

        public void PayPalPayment()
        {
            this._payoneer.SendPayment();
        }

        public void PayPalReceive()
        {
            this._payoneer.ReceivePayment();
        }
    }
}
