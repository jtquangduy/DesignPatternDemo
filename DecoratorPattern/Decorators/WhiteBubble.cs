using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators
{
    public class WhiteBubble : MilkTeaDecorator
    {
        public WhiteBubble(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double Cost()
        {
            return 1.5 + base.Cost();
        }
    }
}