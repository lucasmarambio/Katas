namespace strategy
{
    public class CostCalculationService_WithStrategy
    {
        private readonly IShippingStrategy _shippingStrategy;

        public CostCalculationService_WithStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return _shippingStrategy.CalculateCost(order);
        }
    }
}
