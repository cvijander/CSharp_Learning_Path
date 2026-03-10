internal class Program
{
    private static void Main(string[] args)
    {
        Car myCar = new Car();

        myCar.Make = "Oldsmobile";
        myCar.Model = "Cutlas Supreme";
        myCar.Color = "Silver";
        myCar.Year = 1986;

        Car myOtherCar;
        myOtherCar = myCar;


        Console.WriteLine($" {myCar.Make} {myCar.Model} {myCar.Color} {myCar.Year}");

        Console.WriteLine($"{myOtherCar.Make} - {myOtherCar.Model} - {myOtherCar.Color} - {myOtherCar.Year}");

        myOtherCar.Model = "98";


        Console.WriteLine($" {myCar.Make} {myCar.Model} {myCar.Color} {myCar.Year}");

        Console.WriteLine($"{myOtherCar.Make} - {myOtherCar.Model} - {myOtherCar.Color} - {myOtherCar.Year}");

        Console.WriteLine("set to null");

        myOtherCar = null;

        Console.WriteLine($" {myCar.Make} {myCar.Model} {myCar.Color} {myCar.Year}");

        Console.WriteLine($"{myOtherCar.Make} - {myOtherCar.Model} - {myOtherCar.Color} - {myOtherCar.Year}");

        Console.ReadLine();


    }
}

class Car
{

    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public string Color { get; set; }


}