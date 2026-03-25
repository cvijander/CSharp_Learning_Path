internal class Program
{
    private static void Main(string[] args)
    {
        List<Car> myCars = new List<Car>()
        {
            new Car() { VIN = "A1", Make = "BMW" ,    Model = "550i",     StickerPrice = 55000, Year = 1 },
            new Car() { VIN = "B2", Make = "Toyota" , Model = "4Runner" , StickerPrice = 35000 , Year = 2},
            new Car() { VIN = "C3", Make = "BMW" ,    Model = "745li",    StickerPrice = 75000,  Year = 3},
            new Car() { VIN = "D4" ,Make = "Ford" ,   Model = "Escape" ,  StickerPrice = 25000,  Year = 4},
            new Car() { VIN = "E5", Make = "BMW" ,    Model = "55i",      StickerPrice = 57000,  Year =2010}
        };

        // LINQ query

        var bmws = from car in myCars
                   where car.Make == "BMW"
                   select car;


        // LINQ method

        foreach (var car in bmws)
        {
            Console.WriteLine($"{car.Model} {car.VIN}");
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


// https://www.youtube.com/watch?v=0QUgvfuKvWU  622 -
