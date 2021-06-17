namespace Adapter
{
    interface IPaypalPayment
    {
        Token AuthToken();        
        void PayPalPayment();
        void PayPalReceive();
    }
}
