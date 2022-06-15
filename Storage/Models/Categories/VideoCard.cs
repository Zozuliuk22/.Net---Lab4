using Storage.Enums;
using System.Text;

namespace Storage.Models.Categories
{
    public class VideoCard : Category
    {
        public int MemorySize { get; set; }

        public string GraphicsChip { get; set; }

        public MemoryType MemoryType { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Category: {Name}");
            builder.AppendLine($"Memory Size: {MemorySize} Gb");
            builder.AppendLine($"Graphics Chip: {GraphicsChip}");
            builder.AppendLine($"Memory Type: {MemoryType}");
            return builder.ToString();
        }
    }
}
