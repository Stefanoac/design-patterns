using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var payment = new Paypal();
            //var payment = new Payoneer();
            //var payment = new PayoneerAdapter(new Payoneer());
            var payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PayPalPayment();
            payment.PayPalReceive();

            Console.ReadLine();
        }
    }
}
