using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IPayoneerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
