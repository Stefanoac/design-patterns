using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Components
{
    class AirBag
    {
        private int quantity;

        public AirBag(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
    }
}
