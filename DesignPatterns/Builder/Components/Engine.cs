using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Components
{
    class Engine
    {
        private int power;

        public Engine(int power)
        {
            this.Power = power;
        }

        public int Power
        {
            get => power;
            set => power = value;
        }        
    }
}
