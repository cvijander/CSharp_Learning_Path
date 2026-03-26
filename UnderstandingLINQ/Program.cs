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
            new Car() { VIN = "E5", Make = "BMW" ,    Model = "55i",      StickerPrice = 57000,  Year =2010}
        };

        // LINQ query
        /*
        var bmws = from car in myCars
                   where car.Make == "BMW"
                   && car.Year == 2010 
                   select car;
        */


        var orderedCars = from car in myCars
                          orderby car.Year descending
                          select car;

        // LINQ method


        //var bmws = myCars.Where(p => p.Make == "BMW");
        // var bmws = myCars.Where(car => car.Make == "BMW" && car.Year == 2010);

        var orderedMethodCars = myCars.OrderByDescending(car => car.Year);

        var firstCar = myCars.First(car => car.Make == "BMW");
        var firstCarBmwSorted = myCars.OrderByDescending(car => car.Year).First(car => car.Make == "BMW");

        foreach (var car in orderedCars)
        {
            Console.WriteLine($"{car.Model} {car.VIN}  {car.Year}");
        }

        foreach (var car in orderedMethodCars)
        {
            Console.WriteLine($"{car.Model} {car.VIN}  {car.Year}");
        }

        Console.WriteLine($"first car is :  { firstCar.Model}");
        Console.WriteLine($" first car sorted  { firstCarBmwSorted.Model} ");
        Console.WriteLine(myCars.TrueForAll(car => car.Year > 2012));
        Console.WriteLine(myCars.TrueForAll(car => car.Year > 2007));

        myCars.ForEach(car => car.StickerPrice -= 3000);
        myCars.ForEach(car => Console.WriteLine($"{car.VIN} {car.StickerPrice:C}"));

        Console.WriteLine(myCars.Exists(car => car.Model == "745li"));
        Console.WriteLine(myCars.Sum(car => car.StickerPrice));
        Console.WriteLine(myCars.GetType());
        Console.WriteLine(orderedCars.GetType());
        Console.WriteLine(orderedMethodCars.GetType());
        Console.WriteLine(firstCarBmwSorted.GetType());
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
