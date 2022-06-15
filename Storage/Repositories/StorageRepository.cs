using Storage.Models;
using System.Collections.Generic;

namespace Storage.Repositories
{
    public class StorageRepository
    {
        public List<Product> GetMonitors()
        {
            return DataContext.Monitors;
        }

        public List<Product> GetProcessors()
        {
            return DataContext.Processors;
        }

        public List<Product> GetMotherboards()
        {
            return DataContext.Motherboards;
        }

        public List<Product> GetVideoCards()
        {
            return DataContext.VideoCards;
        }

        public List<Product> GetPowerUnits()
        {
            return DataContext.PowerUnits;
        }
    }
}
