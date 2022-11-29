namespace StrategyPattern
{
    public class Ticket
    {
        private IPromoteStrategy _promoteStrategy;
        private double price;
        private string name;

        public IPromoteStrategy GetPromoteStrategy()
        {
            return _promoteStrategy;
        }

        public void SetPromoteStrategy(IPromoteStrategy value)
        {
            _promoteStrategy = value;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double value)
        {
            price = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public Ticket()
        {
        }

        public Ticket(IPromoteStrategy promoteStrategy)
        {
            _promoteStrategy = promoteStrategy;
        }

        public double GetPromotedPrice()
        {
            return _promoteStrategy.DoDiscount(price);
        }
    }
}