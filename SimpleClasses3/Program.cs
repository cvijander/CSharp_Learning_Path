internal class Program
{
    private static void Main(string[] args)
    {
        Car myCar = new Car();

        myCar.Make = "Oldsmobile";
        myCar.Model = "Cutlas supreme";
        myCar.Year = 1986;
        myCar.Color = "Silver";

        Console.WriteLine($"my fancy car is {myCar.Make}  {myCar.Model}   {myCar.Year}  {myCar.Color}");

        // Console.WriteLine($"{DetermineMarketValue(myCar):C}");

        Console.WriteLine($"{myCar.DetermineMarket():C}");
        Console.ReadLine();
    }

    private static decimal DetermineMarketValue(Car car)
    {
        decimal value = 100;
        return value;
    }

}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }


    public decimal DetermineMarket()
    {
        decimal carValue;

        if (Year > 1990)
        {
            carValue = 10000;    
        }
        else
        {
            carValue = 200;
        }

        return carValue;
    }


}