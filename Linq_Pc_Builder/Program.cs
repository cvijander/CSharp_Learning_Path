internal class Program
{
    private static void Main(string[] args)
    {
        List<PcComponent> inventory = new List<PcComponent>()
        {

        new Cpu() { Ean = "CPU01", Manufacturer = "AMD", Model = "Ryzen 5 5600X", Price = 160, ReleaseYear = 2020, Cores = 6, Socket = "AM4", TdpW = 65 },
            new Cpu() { Ean = "CPU02", Manufacturer = "AMD", Model = "Ryzen 7 5800X3D", Price = 320, ReleaseYear = 2022, Cores = 8, Socket = "AM4", TdpW = 105 },
            new Cpu() { Ean = "CPU03", Manufacturer = "AMD", Model = "Ryzen 9 7950X", Price = 600, ReleaseYear = 2022, Cores = 16, Socket = "AM5", TdpW = 170 },
            new Cpu() { Ean = "CPU04", Manufacturer = "Intel", Model = "Core i5-12400F", Price = 150, ReleaseYear = 2022, Cores = 6, Socket = "LGA1700", TdpW = 65 },
            new Cpu() { Ean = "CPU05", Manufacturer = "Intel", Model = "Core i7-13700K", Price = 410, ReleaseYear = 2022, Cores = 16, Socket = "LGA1700", TdpW = 253 },
            new Cpu() { Ean = "CPU06", Manufacturer = "Intel", Model = "Core i9-14900K", Price = 590, ReleaseYear = 2023, Cores = 24, Socket = "LGA1700", TdpW = 253 },

            // --- GRAFIČKE KARTICE ---
            new Gpu() { Ean = "GPU01", Manufacturer = "Nvidia", Model = "RTX 3060", Price = 280, ReleaseYear = 2021, VramGb = 12, TdpW = 170 },
            new Gpu() { Ean = "GPU02", Manufacturer = "Nvidia", Model = "RTX 3080", Price = 700, ReleaseYear = 2020, VramGb = 10, TdpW = 320 },
            new Gpu() { Ean = "GPU03", Manufacturer = "Nvidia", Model = "RTX 4070 Ti", Price = 800, ReleaseYear = 2023, VramGb = 12, TdpW = 285 },
            new Gpu() { Ean = "GPU04", Manufacturer = "Nvidia", Model = "RTX 4090", Price = 1600, ReleaseYear = 2022, VramGb = 24, TdpW = 450 },
            new Gpu() { Ean = "GPU05", Manufacturer = "AMD", Model = "RX 6700 XT", Price = 330, ReleaseYear = 2021, VramGb = 12, TdpW = 230 },
            new Gpu() { Ean = "GPU06", Manufacturer = "AMD", Model = "RX 7900 XTX", Price = 950, ReleaseYear = 2022, VramGb = 24, TdpW = 355 },

            // --- RAM MEMORIJE ---
            new Ram() { Ean = "RAM01", Manufacturer = "Corsair", Model = "Vengeance LPX", Price = 45, ReleaseYear = 2019, CapacityGb = 16, DdrType = "DDR4", SpeedMhz = 3200 },
            new Ram() { Ean = "RAM02", Manufacturer = "G.Skill", Model = "Trident Z Neo", Price = 75, ReleaseYear = 2020, CapacityGb = 32, DdrType = "DDR4", SpeedMhz = 3600 },
            new Ram() { Ean = "RAM03", Manufacturer = "Kingston", Model = "Fury Beast", Price = 110, ReleaseYear = 2022, CapacityGb = 32, DdrType = "DDR5", SpeedMhz = 5600 },
            new Ram() { Ean = "RAM04", Manufacturer = "G.Skill", Model = "Trident Z5 RGB", Price = 150, ReleaseYear = 2023, CapacityGb = 32, DdrType = "DDR5", SpeedMhz = 6400 },


            // --- MATIČNE PLOČE ---
            new Motherboard() { Ean = "MB01", Manufacturer = "Gigabyte", Model = "B650 Aorus Elite", Price = 200, ReleaseYear = 2022, Socket = "AM5", FormFactor = "ATX", RamSlots = 4, SataConnectors = 4 },
            new Motherboard() { Ean = "MB02", Manufacturer = "Asus", Model = "ROG Strix Z790-H", Price = 380, ReleaseYear = 2023, Socket = "LGA1700", FormFactor = "ATX", RamSlots = 4, SataConnectors = 4 },
            new Motherboard() { Ean = "MB03", Manufacturer = "MSI", Model = "MAG B550 TOMAHAWK", Price = 150, ReleaseYear = 2020, Socket = "AM4", FormFactor = "ATX", RamSlots = 4, SataConnectors = 6 },

            // --- NAPAJANJA (PSU) ---
            new PowerSupply() { Ean = "PSU01", Manufacturer = "Corsair", Model = "RM850x", Price = 140, ReleaseYear = 2021, Wattage = 850, EfficiencyRating = "80+ Gold", IsModular = true },
            new PowerSupply() { Ean = "PSU02", Manufacturer = "Seasonic", Model = "Focus GX-750", Price = 120, ReleaseYear = 2020, Wattage = 750, EfficiencyRating = "80+ Gold", IsModular = true },
            new PowerSupply() { Ean = "PSU03", Manufacturer = "be quiet!", Model = "System Power 10", Price = 65, ReleaseYear = 2022, Wattage = 650, EfficiencyRating = "80+ Bronze", IsModular = false }
        };


        var allPcCompponentsAfter2021 = inventory.Where(component => component.ReleaseYear > 2021);

        foreach (var item in allPcCompponentsAfter2021)
        {
            Console.WriteLine($"{item.Ean} {item.Manufacturer} {item.FullName}");
        }

        var amdOnly = inventory.Count(component => component.Manufacturer.ToUpper() == "AMD");
        Console.WriteLine(amdOnly);

        var any1000 = inventory.Any(component => component.Price > 1000);
        Console.WriteLine(any1000);

        var maxPrice = inventory.Max(component => component.Price);
        Console.WriteLine(maxPrice);

        var FullName = inventory.Select(component => component.FullName);
        foreach (var item in FullName)
        {
            Console.WriteLine(item);
        }

        //  var fullNameLess200 = inventory.Select(component => component.FullName).Where( component => component.Price < 200);

        var fullNameLess200 = inventory.Where(component => component.Price < 200).Select(component => component.FullName);

        Console.WriteLine(fullNameLess200);

        foreach (var item in fullNameLess200)
        {
            Console.WriteLine(item);
        }

        // var priceSelect = inventory.Select(component => component.Price).Where(component => component.full);

        var amdMaxtoMinOnlyNames = inventory.Where(component => component.Manufacturer.ToUpper() == "AMD").OrderByDescending(component => component.Price).Select(component => component.FullName);

        foreach (var item in amdMaxtoMinOnlyNames)
        {
            Console.WriteLine($"{item}");
        }

        var intelNamesMore300 = inventory.Where(component => component.Manufacturer.ToUpper() == "INTEL").Where(component => component.Price > 300).Select(component => component.FullName);

        foreach (var item in intelNamesMore300)
        {
            Console.WriteLine($"{item}");
        }


        Console.ReadLine();
    }
}

class PcComponent
{
    public string Manufacturer { get; set; }

    public string Model { get; set; }

    public string FullName => $"{Manufacturer} {Model}"; 
    public double Price { get; set; }

    public int ReleaseYear { get; set; }

    public string Ean { get; set; }
}

class Cpu : PcComponent
{
    public int Cores { get; set; }
    public string Socket { get; set; }

    public int TdpW { get; set; }
}

class Gpu : PcComponent
{
    public int VramGb { get; set; }

    public int TdpW { get; set; }
}

class Ram :PcComponent
{
    public int CapacityGb { get; set; }

    public string DdrType { get; set; }

    public int SpeedMhz { get; set; }
}

class Motherboard : PcComponent
{
    public string Socket { get; set; }
    public string FormFactor { get; set; }
    public int RamSlots { get; set; }

    public int SataConnectors { get; set; }
}

class PowerSupply : PcComponent
{
    public int Wattage { get; set; }

    public string EfficiencyRating { get; set; }
    public bool IsModular { get; set; }
    
}

