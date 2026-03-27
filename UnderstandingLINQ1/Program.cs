using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Car> myCars = new List<Car>()
        {
            new Car() { VIN = "A1", Make = "BMW" ,    Model = "550i",     StickerPrice = 55000, Year = 2009 },
            new Car() { VIN = "B2", Make = "Toyota" , Model = "4Runner" , StickerPrice = 35000 , Year = 2010},
            new Car() { VIN = "C3", Make = "BMW" ,    Model = "745li",    StickerPrice = 75000,  Year = 2008},
            new Car() { VIN = "D4" ,Make = "Ford" ,   Model = "Escape" ,  StickerPrice = 25000,  Year = 2008},
            new Car() { VIN = "E5", Make = "BMW" ,    Model = "55i",      StickerPrice = 57000,  Year = 2010},
            new Car() { VIN = "GT01", Make = "Volkswagen", Model = "Golf 2 GTI", StickerPrice = 5000, Year = 1988 },
            new Car() { VIN = "GT02", Make = "Nissan", Model = "Skyline GT-R R34", StickerPrice = 85000, Year = 1999 },
            new Car() { VIN = "GT03", Make = "Toyota", Model = "Supra RZ", StickerPrice = 70000, Year = 1997 },
            new Car() { VIN = "GT04", Make = "Mazda", Model = "RX-7 Type R", StickerPrice = 45000, Year = 1995 },
            new Car() { VIN = "GT05", Make = "Mitsubishi", Model = "Lancer Evo VI", StickerPrice = 35000, Year = 1999 },
            new Car() { VIN = "GT06", Make = "Honda", Model = "NSX", StickerPrice = 60000, Year = 1992 },
            new Car() { VIN = "GT07", Make = "Subaru", Model = "Impreza WRX STI", StickerPrice = 30000, Year = 1998 },
            new Car() { VIN = "GT08", Make = "Suzuki", Model = "Escudo Pikes Peak", StickerPrice = 1500000, Year = 1998 }, // GT2 apsolutna zver!
            new Car() { VIN = "GT09", Make = "Dodge", Model = "Viper GTS", StickerPrice = 55000, Year = 1999 },
            new Car() { VIN = "GT10", Make = "BMW", Model = "M3 E30", StickerPrice = 40000, Year = 1989 },
            new Car() { VIN = "GT11", Make = "Mercedes", Model = "190E 2.5-16", StickerPrice = 50000, Year = 1990 },
            new Car() { VIN = "GT12", Make = "Lancia", Model = "Delta HF Integrale", StickerPrice = 38000, Year = 1992 },
            new Car() { VIN = "GT13", Make = "Aston Martin", Model = "DB7", StickerPrice = 42000, Year = 1994 },
            new Car() { VIN = "GT14", Make = "TVR", Model = "Cerbera Speed 12", StickerPrice = 250000, Year = 1998 },
            new Car() { VIN = "GT15", Make = "Zastava", Model = "Yugo GV", StickerPrice = 1500, Year = 1988 },

            new Car() { VIN = "V001", Make = "Toyota", Model = "Corolla", StickerPrice = 15000, Year = 2015 },
            new Car() { VIN = "V002", Make = "Toyota", Model = "Camry", StickerPrice = 22000, Year = 2018 },
            new Car() { VIN = "V003", Make = "Toyota", Model = "RAV4", StickerPrice = 28000, Year = 2019 },
            new Car() { VIN = "V004", Make = "Toyota", Model = "Highlander", StickerPrice = 32000, Year = 2021 },
            new Car() { VIN = "V005", Make = "Toyota", Model = "Prius", StickerPrice = 24000, Year = 2017 },

            new Car() { VIN = "V006", Make = "Honda", Model = "Civic", StickerPrice = 16000, Year = 2016 },
            new Car() { VIN = "V007", Make = "Honda", Model = "Accord", StickerPrice = 21000, Year = 2018 },
            new Car() { VIN = "V008", Make = "Honda", Model = "CR-V", StickerPrice = 27000, Year = 2020 },
            new Car() { VIN = "V009", Make = "Honda", Model = "Pilot", StickerPrice = 35000, Year = 2022 },
            new Car() { VIN = "V010", Make = "Honda", Model = "Fit", StickerPrice = 18000, Year = 2015 },

            new Car() { VIN = "V011", Make = "Ford", Model = "F-150", StickerPrice = 45000, Year = 2021 },
            new Car() { VIN = "V012", Make = "Ford", Model = "Mustang", StickerPrice = 38000, Year = 2019 },
            new Car() { VIN = "V013", Make = "Ford", Model = "Explorer", StickerPrice = 26000, Year = 2018 },
            new Car() { VIN = "V014", Make = "Ford", Model = "Focus", StickerPrice = 12000, Year = 2014 },
            new Car() { VIN = "V015", Make = "Ford", Model = "Ranger", StickerPrice = 31000, Year = 2020 },

            new Car() { VIN = "V016", Make = "Chevrolet", Model = "Silverado", StickerPrice = 42000, Year = 2020 },
            new Car() { VIN = "V017", Make = "Chevrolet", Model = "Malibu", StickerPrice = 19000, Year = 2017 },
            new Car() { VIN = "V018", Make = "Chevrolet", Model = "Equinox", StickerPrice = 23000, Year = 2019 },
            new Car() { VIN = "V019", Make = "Chevrolet", Model = "Tahoe", StickerPrice = 34000, Year = 2021 },
            new Car() { VIN = "V020", Make = "Chevrolet", Model = "Cruze", StickerPrice = 14000, Year = 2015 },

            new Car() { VIN = "V021", Make = "Volkswagen", Model = "Golf", StickerPrice = 17000, Year = 2016 },
            new Car() { VIN = "V022", Make = "Volkswagen", Model = "Jetta", StickerPrice = 19000, Year = 2018 },
            new Car() { VIN = "V023", Make = "Volkswagen", Model = "Passat", StickerPrice = 21000, Year = 2019 },
            new Car() { VIN = "V024", Make = "Volkswagen", Model = "Tiguan", StickerPrice = 28000, Year = 2020 },
            new Car() { VIN = "V025", Make = "Volkswagen", Model = "Atlas", StickerPrice = 33000, Year = 2022 },

            new Car() { VIN = "V026", Make = "BMW", Model = "320i", StickerPrice = 29000, Year = 2015 },
            new Car() { VIN = "V027", Make = "BMW", Model = "X3", StickerPrice = 41000, Year = 2019 },
            new Car() { VIN = "V028", Make = "BMW", Model = "X5", StickerPrice = 52000, Year = 2021 },
            new Car() { VIN = "V029", Make = "BMW", Model = "M3", StickerPrice = 65000, Year = 2020 },
            new Car() { VIN = "V030", Make = "BMW", Model = "428i", StickerPrice = 31000, Year = 2016 },

            new Car() { VIN = "V031", Make = "Audi", Model = "A3", StickerPrice = 28000, Year = 2017 },
            new Car() { VIN = "V032", Make = "Audi", Model = "A4", StickerPrice = 34000, Year = 2019 },
            new Car() { VIN = "V033", Make = "Audi", Model = "Q5", StickerPrice = 45000, Year = 2020 },
            new Car() { VIN = "V034", Make = "Audi", Model = "Q7", StickerPrice = 55000, Year = 2021 },
            new Car() { VIN = "V035", Make = "Audi", Model = "A6", StickerPrice = 42000, Year = 2018 },

            new Car() { VIN = "V036", Make = "Mercedes", Model = "C300", StickerPrice = 33000, Year = 2018 },
            new Car() { VIN = "V037", Make = "Mercedes", Model = "E350", StickerPrice = 41000, Year = 2019 },
            new Car() { VIN = "V038", Make = "Mercedes", Model = "GLC300", StickerPrice = 46000, Year = 2020 },
            new Car() { VIN = "V039", Make = "Mercedes", Model = "GLE350", StickerPrice = 54000, Year = 2021 },
            new Car() { VIN = "V040", Make = "Mercedes", Model = "S550", StickerPrice = 68000, Year = 2017 },

            new Car() { VIN = "V041", Make = "Nissan", Model = "Altima", StickerPrice = 18000, Year = 2016 },
            new Car() { VIN = "V042", Make = "Nissan", Model = "Sentra", StickerPrice = 15000, Year = 2015 },
            new Car() { VIN = "V043", Make = "Nissan", Model = "Rogue", StickerPrice = 25000, Year = 2019 },
            new Car() { VIN = "V044", Make = "Nissan", Model = "Pathfinder", StickerPrice = 31000, Year = 2021 },
            new Car() { VIN = "V045", Make = "Nissan", Model = "Maxima", StickerPrice = 22000, Year = 2018 },

            new Car() { VIN = "V046", Make = "Hyundai", Model = "Elantra", StickerPrice = 16000, Year = 2017 },
            new Car() { VIN = "V047", Make = "Hyundai", Model = "Sonata", StickerPrice = 20000, Year = 2019 },
            new Car() { VIN = "V048", Make = "Hyundai", Model = "Tucson", StickerPrice = 26000, Year = 2020 },
            new Car() { VIN = "V049", Make = "Hyundai", Model = "Santa Fe", StickerPrice = 32000, Year = 2021 },
            new Car() { VIN = "V050", Make = "Hyundai", Model = "Kona", StickerPrice = 24000, Year = 2018 },

            new Car() { VIN = "V051", Make = "Kia", Model = "Optima", StickerPrice = 19000, Year = 2018 },
            new Car() { VIN = "V052", Make = "Kia", Model = "Forte", StickerPrice = 15000, Year = 2016 },
            new Car() { VIN = "V053", Make = "Kia", Model = "Sorento", StickerPrice = 27000, Year = 2020 },
            new Car() { VIN = "V054", Make = "Kia", Model = "Sportage", StickerPrice = 33000, Year = 2021 },
            new Car() { VIN = "V055", Make = "Kia", Model = "Soul", StickerPrice = 18000, Year = 2019 },

            new Car() { VIN = "V056", Make = "Subaru", Model = "Outback", StickerPrice = 28000, Year = 2019 },
            new Car() { VIN = "V057", Make = "Subaru", Model = "Forester", StickerPrice = 26000, Year = 2018 },
            new Car() { VIN = "V058", Make = "Subaru", Model = "Crosstrek", StickerPrice = 24000, Year = 2020 },
            new Car() { VIN = "V059", Make = "Subaru", Model = "Impreza", StickerPrice = 21000, Year = 2017 },
            new Car() { VIN = "V060", Make = "Subaru", Model = "Legacy", StickerPrice = 23000, Year = 2018 },

            new Car() { VIN = "V061", Make = "Mazda", Model = "Mazda3", StickerPrice = 18000, Year = 2017 },
            new Car() { VIN = "V062", Make = "Mazda", Model = "Mazda6", StickerPrice = 22000, Year = 2019 },
            new Car() { VIN = "V063", Make = "Mazda", Model = "CX-5", StickerPrice = 27000, Year = 2020 },
            new Car() { VIN = "V064", Make = "Mazda", Model = "CX-9", StickerPrice = 34000, Year = 2021 },
            new Car() { VIN = "V065", Make = "Mazda", Model = "CX-3", StickerPrice = 21000, Year = 2018 },

            new Car() { VIN = "V066", Make = "Lexus", Model = "RX350", StickerPrice = 42000, Year = 2019 },
            new Car() { VIN = "V067", Make = "Lexus", Model = "ES350", StickerPrice = 38000, Year = 2018 },
            new Car() { VIN = "V068", Make = "Lexus", Model = "NX300", StickerPrice = 39000, Year = 2020 },
            new Car() { VIN = "V069", Make = "Lexus", Model = "IS300", StickerPrice = 35000, Year = 2019 },
            new Car() { VIN = "V070", Make = "Lexus", Model = "GX460", StickerPrice = 50000, Year = 2021 },

            new Car() { VIN = "V071", Make = "Jeep", Model = "Grand Cherokee", StickerPrice = 36000, Year = 2018 },
            new Car() { VIN = "V072", Make = "Jeep", Model = "Wrangler", StickerPrice = 40000, Year = 2020 },
            new Car() { VIN = "V073", Make = "Jeep", Model = "Cherokee", StickerPrice = 31000, Year = 2019 },
            new Car() { VIN = "V074", Make = "Jeep", Model = "Compass", StickerPrice = 24000, Year = 2017 },
            new Car() { VIN = "V075", Make = "Jeep", Model = "Renegade", StickerPrice = 21000, Year = 2016 },

            new Car() { VIN = "V076", Make = "Porsche", Model = "Macan", StickerPrice = 52000, Year = 2019 },
            new Car() { VIN = "V077", Make = "Porsche", Model = "Cayenne", StickerPrice = 65000, Year = 2020 },
            new Car() { VIN = "V078", Make = "Porsche", Model = "911", StickerPrice = 95000, Year = 2021 },
            new Car() { VIN = "V079", Make = "Porsche", Model = "Panamera", StickerPrice = 85000, Year = 2018 },
            new Car() { VIN = "V080", Make = "Porsche", Model = "Cayman", StickerPrice = 60000, Year = 2017 },

            new Car() { VIN = "V081", Make = "Volvo", Model = "XC90", StickerPrice = 48000, Year = 2020 },
            new Car() { VIN = "V082", Make = "Volvo", Model = "XC60", StickerPrice = 41000, Year = 2019 },
            new Car() { VIN = "V083", Make = "Volvo", Model = "S60", StickerPrice = 37000, Year = 2018 },
            new Car() { VIN = "V084", Make = "Volvo", Model = "S90", StickerPrice = 45000, Year = 2021 },
            new Car() { VIN = "V085", Make = "Volvo", Model = "V60", StickerPrice = 39000, Year = 2019 },

            new Car() { VIN = "V086", Make = "Fiat", Model = "500", StickerPrice = 12000, Year = 2015 },
            new Car() { VIN = "V087", Make = "Fiat", Model = "500X", StickerPrice = 16000, Year = 2017 },
            new Car() { VIN = "V088", Make = "Fiat", Model = "124 Spider", StickerPrice = 22000, Year = 2018 },
            new Car() { VIN = "V089", Make = "Fiat", Model = "500L", StickerPrice = 15000, Year = 2016 },
            new Car() { VIN = "V090", Make = "Fiat", Model = "Panda", StickerPrice = 11000, Year = 2014 },

            new Car() { VIN = "V091", Make = "Land Rover", Model = "Range Rover", StickerPrice = 75000, Year = 2021 },
            new Car() { VIN = "V092", Make = "Land Rover", Model = "Discovery", StickerPrice = 55000, Year = 2019 },
            new Car() { VIN = "V093", Make = "Land Rover", Model = "Evoque", StickerPrice = 42000, Year = 2018 },
            new Car() { VIN = "V094", Make = "Land Rover", Model = "Velar", StickerPrice = 48000, Year = 2020 },
            new Car() { VIN = "V095", Make = "Land Rover", Model = "Defender", StickerPrice = 62000, Year = 2021 },

            new Car() { VIN = "V096", Make = "Tesla", Model = "Model 3", StickerPrice = 45000, Year = 2020 },
            new Car() { VIN = "V097", Make = "Tesla", Model = "Model S", StickerPrice = 75000, Year = 2019 },
            new Car() { VIN = "V098", Make = "Tesla", Model = "Model X", StickerPrice = 85000, Year = 2021 },
            new Car() { VIN = "V099", Make = "Tesla", Model = "Model Y", StickerPrice = 52000, Year = 2022 },
            new Car() { VIN = "V100", Make = "Tesla", Model = "Roadster", StickerPrice = 120000, Year = 2023 },

            new Car() { VIN = "GTA01", Make = "Alfa Romeo", Model = "155 2.5 V6 TI", StickerPrice = 35000, Year = 1993 },
            new Car() { VIN = "GTA02", Make = "Alfa Romeo", Model = "156 2.5 V6 24V", StickerPrice = 28000, Year = 1998 },
            new Car() { VIN = "GTA03", Make = "Alfa Romeo", Model = "GTV 3.0 V6 24V", StickerPrice = 32000, Year = 1998 },

            // Starteri i legende sa istoka (Japan)
            new Car() { VIN = "GTJ01", Make = "Mazda", Model = "Demio LX G Package", StickerPrice = 3500, Year = 1997 }, // Ultimativni GT2 starter!
            new Car() { VIN = "GTJ02", Make = "Mazda", Model = "Eunos Roadster (MX-5)", StickerPrice = 5000, Year = 1989 },
            new Car() { VIN = "GTJ03", Make = "Mazda", Model = "RX-7 Savanna (FC)", StickerPrice = 12000, Year = 1990 },
            new Car() { VIN = "GTJ04", Make = "Toyota", Model = "Sprinter Trueno GT-APEX (AE86)", StickerPrice = 8000, Year = 1983 },
            new Car() { VIN = "GTJ05", Make = "Toyota", Model = "Celica GT-Four", StickerPrice = 18000, Year = 1994 },
            new Car() { VIN = "GTJ06", Make = "Toyota", Model = "MR2 GT-S", StickerPrice = 15000, Year = 1997 },
            new Car() { VIN = "GTJ07", Make = "Nissan", Model = "Silvia K's (S13)", StickerPrice = 9000, Year = 1988 },
            new Car() { VIN = "GTJ08", Make = "Nissan", Model = "180SX Type S", StickerPrice = 10000, Year = 1996 },
            new Car() { VIN = "GTJ09", Make = "Nissan", Model = "Skyline GTS-t Type M (R32)", StickerPrice = 14000, Year = 1989 },
            new Car() { VIN = "GTJ10", Make = "Honda", Model = "Civic SiR-II (EG)", StickerPrice = 6000, Year = 1993 },
            new Car() { VIN = "GTJ11", Make = "Honda", Model = "CR-X SiR", StickerPrice = 5500, Year = 1990 },
            new Car() { VIN = "GTJ12", Make = "Honda", Model = "Integra Type R", StickerPrice = 22000, Year = 1998 },
            new Car() { VIN = "GTJ13", Make = "Mitsubishi", Model = "FTO GPX", StickerPrice = 13000, Year = 1994 },
            new Car() { VIN = "GTJ14", Make = "Mitsubishi", Model = "3000GT VR-4", StickerPrice = 30000, Year = 1998 },
            new Car() { VIN = "GTJ15", Make = "Subaru", Model = "Legacy Touring Wagon", StickerPrice = 11000, Year = 1993 },
            new Car() { VIN = "GTJ16", Make = "Subaru", Model = "Impreza WRX Type R STI", StickerPrice = 28000, Year = 1998 }
        };

        // linq query 
        var bmws = from car in myCars
                   where car.Make == "BMW"
                   && car.Year == 2010 
                   select car;

        var orderedCars = from car in myCars
                          orderby car.Year descending
                          select car;



        // linq method 

        var methodBMWS = myCars.Where(car => car.Make == "BMW" && car.Year == 2010);

        var methodOrderedCars = myCars.OrderByDescending(car => car.Year);

        var firstCar = myCars.First(car => car.Make == "BMW");

        var firstCarYear = myCars.OrderByDescending(car => car.Year).First(car => car.Make == "Alfa Romeo");



        foreach (var car in bmws)
        {
            Console.WriteLine($"{car.Model}  {car.VIN}");
        }

        Console.WriteLine("-----------");

        foreach (var car in methodBMWS)
        {
            Console.WriteLine($"{car.Model} {car.VIN}");
        }

        Console.WriteLine("------------------");

        foreach (var car in orderedCars)
        {
            Console.WriteLine($"{car.Year} {car.Model} {car.VIN}  {car.StickerPrice}");
        }

        Console.WriteLine("------------------");

        foreach (var car in methodOrderedCars)
        {
            Console.WriteLine($"{car.Year} {car.Model} {car.VIN}  {car.StickerPrice}");
        }

        Console.WriteLine("------------------");

        Console.WriteLine($"{firstCar.Model} {firstCar.VIN}");

        Console.WriteLine("------------------");

        Console.WriteLine($"{firstCarYear.VIN} {firstCarYear.StickerPrice}");

        Console.WriteLine(myCars.TrueForAll(car => car.Year > 2012));

        Console.WriteLine("-------------");


        myCars.ForEach(car => car.StickerPrice -= 3000);
        myCars.ForEach(car => Console.WriteLine($"{car.VIN}  {car.StickerPrice}"));


        Console.WriteLine(myCars.Exists(car => car.Model == "754li"));

        Console.WriteLine(myCars.Sum(car => car.StickerPrice));

        Console.WriteLine(myCars.GetType());

        Console.WriteLine(bmws.GetType());

        Console.WriteLine(orderedCars.GetType());


        Console.WriteLine(methodBMWS.GetType());

        Console.WriteLine(methodOrderedCars.GetType());

        Console.WriteLine(firstCar.GetType());

        Console.WriteLine(firstCarYear.GetType());

        Console.WriteLine("------------");

        var priceLow50000 = myCars.Where(car => car.StickerPrice < 50000).OrderBy(car => car.StickerPrice);
        foreach (var item in priceLow50000)
        {
            Console.WriteLine($"{item.StickerPrice}");
        }
        Console.WriteLine(" *********************");

        var carsBetween1990And1999 = myCars.Where(car => car.Year >= 1990 && car.Year <= 1999).OrderByDescending(car => car.Year);

        foreach (var item in carsBetween1990And1999)
        {
            Console.WriteLine($"{item.VIN}  {item.Year}");
        }

        Console.ReadLine();
    }
}
class Car
{
    public string VIN { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public double StickerPrice { get; set; }
}


// https://www.youtube.com/watch?v=0QUgvfuKvWU  622 - 645