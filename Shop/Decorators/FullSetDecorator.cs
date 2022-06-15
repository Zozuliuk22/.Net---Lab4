namespace Shop.Decorators
{
    public class FullSetDecorator : OrderItemDecorator
    {
        public FullSetDecorator(OrderItem order) : base(order) { }

        public override decimal CalculatePrice()
        {
            return Order.CalculatePrice() * 1.05m;
        }
    }
}
