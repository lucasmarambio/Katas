namespace strategy.ShippingStrategies
{
    public class UpsShippingStrategy : IShippingStrategy
    {
        public double CalculateCost(Order order)
        {
            return 4.25d;
        }
    }
}
