using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Platforms
{
    interface IPlatform
    {
        void ConfigureRMTP();
        void AuthToken();
    }
}
