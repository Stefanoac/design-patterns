using System;

namespace Adapter
{
    class MercadoPago : IMercadoPago
    {
        private Token _token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePay()
        {
            _token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Mercado Pago");
        }

        public void SendPay()
        {
            _token = AuthToken();
            Console.WriteLine("Enviando pagamento com Mercado Pago");
        }
    }
}
