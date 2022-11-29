using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class NoDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price;
        }
    }
}
