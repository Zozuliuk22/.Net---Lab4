using Storage.Models;
using System.Linq;
using System.Text;

namespace Shop.Decorators
{
    public class FullSetDecorator : OrderItemDecorator
    {
        public FullSetDecorator(OrderItem order) : base(order) { }

        public override void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public override decimal CalculatePrice()
        {
            if (Products.Count > 0)
            {
                var localSum = Products.Sum(p => p.Price);
                return (localSum + Order.CalculatePrice()) * 1.05m;
            }
            return Order.CalculatePrice();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(Order.ToString());
            foreach (var item in Products)
                builder.Append(item.ToString());            
            return builder.ToString();
        }
    }
}
