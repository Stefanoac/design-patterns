using System;

namespace Adapter
{
    class MercadoPagoAdapter : IPaypalPayment
    {
        private MercadoPago _mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this._mercadoPago = mercadoPago;
            Console.WriteLine("Realizando adaptação do Mercado Pago para PayPal;");
        }

        public Token AuthToken()
        {
            return this._mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this._mercadoPago.SendPay();
        }

        public void PayPalReceive()
        {
            this._mercadoPago.ReceivePay();
        }
    }
}
