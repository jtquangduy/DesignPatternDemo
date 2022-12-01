using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators
{
    public class Bubble : MilkTeaDecorator
    {
        public Bubble(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double Cost()
        {
            return 1d + base.Cost();
        }
    }
}