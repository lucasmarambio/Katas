namespace strategy
{
    public interface IShippingStrategy
    {
        public double CalculateCost(Order order);
    }
}
