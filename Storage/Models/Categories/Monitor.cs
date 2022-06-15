using Storage.Enums;
using System.Text;

namespace Storage.Models.Categories
{
    public class Monitor : Category
    {
        public float Diagonal { get; set; }

        public int UpdateFrequency { get; set; }

        public MatrixType MatrixType { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Category: {Name}");
            builder.AppendLine($"Update Frequency: {UpdateFrequency} Hz");
            builder.AppendLine($"Diagonal: {Diagonal}\"");
            builder.AppendLine($"Matrix Type: {MatrixType}");
            return builder.ToString();
        }
    }
}
