using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators
{
    public class BlackSugar : MilkTeaDecorator
    {
        public BlackSugar(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double Cost()
        {
            return 2d + base.Cost();
        }
    }
}