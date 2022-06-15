using System.Text;

namespace Storage.Models.Categories
{
    public class Motherboard : Category
    {
        public int MaxMemoryFrequency { get; set; }

        public string Socket { get; set; }

        public string Chipset { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Category: {Name}");
            builder.AppendLine($"Max Memory Frequency: {MaxMemoryFrequency} MHz");
            builder.AppendLine($"Socket: {Socket}");
            builder.AppendLine($"Chipset: {Chipset}");
            return builder.ToString();
        }
    }
}
