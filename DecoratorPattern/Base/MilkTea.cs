using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Base
{
    public class MilkTea : IMilkTea
    {
        public double Cost()
        {
            return 5d;
        }
    }
}
