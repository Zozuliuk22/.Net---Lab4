using Storage.Models;
using System;
using System.Text;

namespace Shop.Decorators
{
    public class OrderItemDecorator : OrderItem
    {
        protected OrderItem Order;

        public OrderItemDecorator(OrderItem order)
        {
            Order = order;
        }

        public override void AddProduct(Product product)
        {
            Order.AddProduct(product);
        }

        public override decimal CalculatePrice()
        {
            return Order.CalculatePrice();
        }

        public override string ToString()
        {
            return Order.ToString();
        }
    }
}
