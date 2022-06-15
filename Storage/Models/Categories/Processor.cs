using System.Text;

namespace Storage.Models.Categories
{
    public class Processor : Category
    {
        public float ClockFrequency { get; set; }

        public int CoresNumber { get; set; }

        public int ThreadsNumber { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Category: {Name}");
            builder.AppendLine($"Clock Frequency: {ClockFrequency} GHz");
            builder.AppendLine($"Cores Number: {CoresNumber}");
            builder.AppendLine($"Threads Number: {ThreadsNumber}");
            return builder.ToString();
        }
    }
}
