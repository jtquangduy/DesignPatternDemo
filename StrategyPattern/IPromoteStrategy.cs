using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IPromoteStrategy
    {
        double DoDiscount(double price);
    }
}
