using System.Linq;

namespace Shop
{
    public class OrderItemDefault : OrderItem
    {
        public override decimal CalculatePrice()
        {
            if (Products.Count > 0)
                return Products.Sum(p => p.Price);

            return 0;
        }
    }
}
