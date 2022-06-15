using System.Text;

namespace Storage.Models
{
    public class Product
    {
        public string Name { get; set; }

        public string VendorCode { get; set; }

        public decimal Price { get; set; }

        public Category Category { get; }

        public Product(Category category)
        {
            Category = category;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(Name);
            builder.AppendLine($"Vendor Code: {VendorCode}");
            builder.AppendLine($"Price: {Price} UAH");
            builder.AppendLine(Category.ToString());
            return builder.ToString();
        }
    }
}
