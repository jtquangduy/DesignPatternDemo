using System;

namespace DecoratorPattern.Base
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;

        protected MilkTeaDecorator(IMilkTea milkTea)
        {
            _milkTea = milkTea;
        }

        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}