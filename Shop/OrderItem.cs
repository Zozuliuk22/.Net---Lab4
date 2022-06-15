using Storage.Models;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public abstract class OrderItem
    {
        protected List<Product> Products { get; } = new();

        public virtual void AddProduct(Product product)
        {
            if(product is not null)
                Products.Add(product);
        }

        public abstract decimal CalculatePrice();

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach(var item in Products)
                builder.Append(item.ToString());
            return builder.ToString();
        }
    }
}
