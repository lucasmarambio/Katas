namespace strategy.ShippingStrategies
{
    public class FedexShippingStrategy : IShippingStrategy
    {
        public double CalculateCost(Order order)
        {
            return 5.00d;
        }
    }
}
