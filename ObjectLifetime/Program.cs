internal class Program
{
    private static void Main(string[] args)
    {
        Car myCar = new Car();

        Car myThirdCar = new Car("Honda", "Civic", 2005, "Yellow");

        /*
                myCar.Make = "Oldsmobile";
                myCar.Model = "Cutlas Supreme";
                myCar.Year = 1986;
                myCar.Color = "Silver";

                Car myOtherCar;

                myOtherCar = myCar;


                Console.WriteLine($"{myCar.Make} {myCar.Model}  {myCar.Year}  {myCar.Color}");

                Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model}  {myOtherCar.Year} {myOtherCar.Color}");



                myOtherCar.Model = "98";

                Console.WriteLine("------------------");
                Console.WriteLine($"{myCar.Make} {myCar.Model}  {myCar.Year}  {myCar.Color}");

                Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model}  {myOtherCar.Year} {myOtherCar.Color}");

                Console.WriteLine("------------------");

                myOtherCar = null;

                Console.WriteLine("------------------");
                Console.WriteLine($"{myCar.Make} {myCar.Model}  {myCar.Year}  {myCar.Color}");

                Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Model}  {myOtherCar.Year} {myOtherCar.Color}");



                Console.ReadLine();

                */

        Console.WriteLine($"{myCar.Make}  {myCar.Model} {myCar.Year}  {myCar.Color}");

        Console.WriteLine($"{myThirdCar.Make}  {myThirdCar.Model} {myThirdCar.Color} {myThirdCar.Year}");
        Console.ReadLine();


    }
}

class Car
{

    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public string Color { get; set; }


    // konstruktor

    public Car()
    {
        this.Make = "Nissan";
    }

    public Car(string make,string model, int year , string color)
    {
        Make = make;
        Model = model;
        Color = color;
        Year = year;
    }

}

// https://www.youtube.com/watch?v=0QUgvfuKvWU
// 440 konstruktor 
//455 static