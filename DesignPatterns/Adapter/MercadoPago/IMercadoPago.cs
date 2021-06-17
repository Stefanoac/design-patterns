namespace Adapter
{
    interface IMercadoPago
    {
        Token AuthToken();
        void SendPay();
        void ReceivePay();
    }
}
