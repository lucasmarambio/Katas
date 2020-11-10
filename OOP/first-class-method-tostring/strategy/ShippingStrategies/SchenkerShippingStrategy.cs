namespace strategy.ShippingStrategies
{
    public class SchenkerShippingStrategy : IShippingStrategy
    {
        public double CalculateCost(Order order)
        {
            return 3.00d;
        }
    }
}
