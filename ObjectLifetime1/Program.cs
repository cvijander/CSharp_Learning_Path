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

       // myOtherCar = null;

        Console.WriteLine($" {myCar.Make} {myCar.Model} {myCar.Color} {myCar.Year}");

        Console.WriteLine($"{myOtherCar.Make} - {myOtherCar.Model} - {myOtherCar.Color} - {myOtherCar.Year}");

        Car myThirdCar = new Car();

        Car myFourthCar = new Car("Ford", "Mondeo", 1999, "Yellow");

        Console.WriteLine($"{myFourthCar.Make} {myFourthCar.Model} {myFourthCar.Color} {myFourthCar.Year}");

        Console.WriteLine($"{myThirdCar.Make} ");

        Console.ReadLine();


    }
}

class Car
{

    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public string Color { get; set; }

    public Car ()
    {
        Make = "Nissan";
        //this.Make = "Nissan"; 
    }

    public Car (string make, string model, int year, string color )
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }


}

//4 46 konstruktyori 
//430 - lifetime 
//