namespace Shop.Decorators
{
    public class PackagingDecorator : OrderItemDecorator
    {
        public PackagingDecorator(OrderItem order) : base(order) { }

        public override decimal CalculatePrice()
        {
            return Order.CalculatePrice() + 250;
        }
    }
}
