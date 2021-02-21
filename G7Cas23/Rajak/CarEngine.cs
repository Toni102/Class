using System;
using System.Collections.Generic;

namespace Rajak
{
    class CarEngine
    {

        public string Name { get;  }
        public int Power { get; }

        public CarEngine(string Name, int Power)
        {
            this.Name = Name;
            this.Power = Power;
        }
    }
}
