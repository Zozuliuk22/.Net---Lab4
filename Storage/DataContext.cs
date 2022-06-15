using Storage.Models;
using Storage.Models.Categories;
using Storage.Enums;
using System.Collections.Generic;

namespace Storage
{
    public static class DataContext
    {
        public static List<Product> Monitors { get; } = new()
        {
            new Product(new Monitor()
            {
                Name = "Acer Monitors",
                Diagonal = 27,
                MatrixType = MatrixType.IPS,
                UpdateFrequency = 75
            })
            {
                Name = "Monitor Acer Nitro VG270",
                VendorCode = "284869838",
                Price = 6599
            },
            
            new Product(new Monitor()
            {
                Name = "Acer Monitors",
                Diagonal = 29,
                MatrixType = MatrixType.IPS,
                UpdateFrequency = 75
            })
            {
                Name = "Монитор Acer V277Ubmiipx",
                VendorCode = "11449344",
                Price = 7999
            },

            new Product(new Monitor()
            {
                Name = "Dell Monitors",
                Diagonal = 27,
                MatrixType = MatrixType.VA,
                UpdateFrequency = 75
            })
            {
                Name = "Monitor Dell SE2722H",
                VendorCode = "294615473",
                Price = 6099
            },

            new Product(new Monitor()
            {
                Name = "Dell Monitors",
                Diagonal = 27,
                MatrixType = MatrixType.IPS,
                UpdateFrequency = 60
            })
            {
                Name = "Monitor Dell P2720DC",
                VendorCode = "219872521",
                Price = 7599
            },
        };

        public static List<Product> Motherboards { get; } = new()
        {
            new Product(new Motherboard()
            {
                Name = "Asus Motherboards",
                MaxMemoryFrequency = 3200,
                Socket = "Socket 1200",
                Chipset = "Intel H510"
            })
            {
                Name = "Motherboard Asus Prime H510M-A",
                VendorCode = "277908328",
                Price = 2349
            },

            new Product(new Motherboard()
            {
                Name = "Asus Motherboards",
                MaxMemoryFrequency = 4600,
                Socket = "Socket 1200",
                Chipset = "Intel B560"
            })
            {
                Name = "Motherboard Asus Prime B560-Plus",
                VendorCode = "277887743",
                Price = 4399
            },

            new Product(new Motherboard()
            {
                Name = "MSI Motherboards",
                MaxMemoryFrequency = 3200,
                Socket = "Socket AM4",                
                Chipset = "Intel X570"
            })
            {
                Name = "Motherboard MSI MAG X570S Torpedo MAX",
                VendorCode = "331988209",
                Price = 7028
            },

            new Product(new Motherboard()
            {
                Name = "MSI Motherboards",
                MaxMemoryFrequency = 3000,
                Socket = "Socket AM4",
                Chipset = "AMD B450"
            })
            {
                Name = "Motherboard MSI B450 Tomahawk Max II",
                VendorCode = "276484553",
                Price = 2955
            },
        };

        public static List<Product> PowerUnits { get; } = new()
        {
            new Product(new PowerUnit()
            {
                Name = "Asus Power Units",
                Power = 750,
                Cooling = "Fan 135 mm",
                PowerConnector = "1x4+4pin"
            })
            {
                Name = "Power Unit ASUS TUF Gaming 80+ Bronze",
                VendorCode = "260704411",
                Price = 2619
            },

            new Product(new PowerUnit()
            {
                Name = "Asus Power Units",
                Power = 1200,
                Cooling = "Fan 135 mm",
                PowerConnector = "2x4+4pin"
            })
            {
                Name = "Power Unit Asus ROG Thor",
                VendorCode = "67931651",
                Price = 11749
            },

            new Product(new PowerUnit()
            {
                Name = "FSP Power Units",
                Power = 850,
                Cooling = "Fan 135 mm",
                PowerConnector = "2x4+4pin"
            })
            {
                Name = "Power Unit FSP Hydro G Pro",
                VendorCode = "256901776",
                Price = 4889
            },

            new Product(new PowerUnit()
            {
                Name = "FSP Power Units",
                Power = 650,
                Cooling = "Fan 135 mm",
                PowerConnector = "2x4+4pin"
            })
            {
                Name = "Power Unit FSP Hydro G Pro",
                VendorCode = "256901366",
                Price = 3619
            },

        };

        public static List<Product> Processors { get; } = new()
        {
            new Product(new Processor()
            {
                Name = "Intel Processors",
                ClockFrequency = 2.3f,
                CoresNumber = 16,
                ThreadsNumber = 24,
            })
            {
                Name = "Processor Intel Core i9-12900K",
                VendorCode = "323245369",
                Price = 23001
            },

            new Product(new Processor()
            {
                Name = "Intel Processors",
                ClockFrequency = 2.9f,
                CoresNumber = 6,
                ThreadsNumber = 12,
            })
            {
                Name = "Processor Intel Core i5-10400F",
                VendorCode = "209011471",
                Price = 4459
            },

            new Product(new Processor()
            {
                Name = "AMD Processors",
                ClockFrequency = 3.4f,
                CoresNumber = 16,
                ThreadsNumber = 32,
            })
            {
                Name = "Processor AMD Ryzen 9 5950X",
                VendorCode = "257322056",
                Price = 21120
            },

            new Product(new Processor()
            {
                Name = "AMD Processors",
                ClockFrequency = 3.8f,
                CoresNumber = 8,
                ThreadsNumber = 16,
            })
            {
                Name = "Processor AMD Ryzen 7 5800X",
                VendorCode = "257395336",
                Price = 12704
            },
        };

        public static List<Product> VideoCards { get; } = new()
        {
            new Product(new VideoCard()
            {
                Name = "Asus Video Cards",
                MemorySize = 16,
                GraphicsChip = "RX 6800 XT",
                MemoryType = MemoryType.GDDR6
            })
            {
                Name = "Video Card Asus PCI-Ex Radeon",
                VendorCode = "264926146",
                Price = 43199
            },

            new Product(new VideoCard()
            {
                Name = "Asus Video Cards",
                MemorySize = 6,
                GraphicsChip = "GeForce GTX 1660 Ti",
                MemoryType = MemoryType.GDDR6
            })
            {
                Name = "Video Card Asus PCI-Ex",
                VendorCode = "312775885",
                Price = 13879
            },

            new Product(new VideoCard()
            {
                Name = "AFOX Video Cards",
                MemorySize = 6,
                GraphicsChip = "GeForce GTX 1060",
                MemoryType = MemoryType.GDDR5
            })
            {
                Name = "Video Card AFOX PCI-Ex",
                VendorCode = "332716435",
                Price = 16599
            },

            new Product(new VideoCard()
            {
                Name = "AFox Video Cards",
                MemorySize = 2,
                GraphicsChip = "GeForce GT730",
                MemoryType = MemoryType.GDDR5
            })
            {
                Name = "Video Card AFOX PCI-Ex",
                VendorCode = "74213043",
                Price = 2789
            },
        };
    }
}
