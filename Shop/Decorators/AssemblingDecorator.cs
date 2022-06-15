namespace Shop.Decorators
{
    public class AssemblingDecorator : OrderItemDecorator
    {
        public AssemblingDecorator(OrderItem order) : base(order) { }

        public override decimal CalculatePrice()
        {
            return Order.CalculatePrice() * 1.15m;
        }


    }
}
