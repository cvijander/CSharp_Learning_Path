internal class Program
{
    private static void Main(string[] args)
    {
        Car myCar = new Car();

        myCar.Make = "Oldsmobile";
        myCar.Model = "Cutlas Supreme";
        myCar.Year = 1986;
        myCar.Color = "Silver";


        Car myOtherCar;
        myOtherCar = myCar;

        Car myThirdCar = new Car();

        Car myForthCar = new Car("Toyota", "Supra", 2010, "Purple");

        Car.MyMethod();

        Console.WriteLine($"{myCar.Make}  {myCar.Model}  {myCar.Color} {myCar.Year}");

        Console.WriteLine($"{myOtherCar.Make} -  {myOtherCar.Model} - {myOtherCar.Color} - {myOtherCar.Year}");

        Console.WriteLine($"{myThirdCar.Make}");

        Console.WriteLine($"{myForthCar.Model}  {myForthCar.Make}  {myForthCar.Color} {myForthCar.Year}");

        myOtherCar.Model = "98";


        Console.WriteLine($"{myCar.Make}  {myCar.Model}  {myCar.Color} {myCar.Year}");

        Console.WriteLine($"{myOtherCar.Make} -  {myOtherCar.Model} - {myOtherCar.Color} - {myOtherCar.Year}");

        //myOtherCar = null;

        Console.WriteLine("Removed myOtherCar \"handle\"");

        Console.WriteLine($"{myCar.Make}  {myCar.Model}  {myCar.Color} {myCar.Year}");

        Console.WriteLine($"{myOtherCar.Make} -  {myOtherCar.Model} - {myOtherCar.Color} - {myOtherCar.Year}");

        Console.ReadLine();

    }

}

class Car
{
    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public string Color { get; set; }


    public Car()
    {
        Make = "Nissan";
    }

    public Car(string make, string model, int year, string color )
    {
        Make = make;
        Model = model;
        Year = year;
        Color = color;
    }

    public static void MyMethod()
    {
        Console.WriteLine("Calling my methond");
    }
}