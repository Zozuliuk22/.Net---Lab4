using System.Text;

namespace Storage.Models.Categories
{
    public class PowerUnit : Category
    {
        public int Power { get; set; }

        public string Cooling { get; set; }

        public string PowerConnector { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Category: {Name}");
            builder.AppendLine($"Power: {Power} W");
            builder.AppendLine($"Cooling: {Cooling}");
            builder.AppendLine($"Power Connector: {PowerConnector}");
            return builder.ToString();
        }
    }
}
