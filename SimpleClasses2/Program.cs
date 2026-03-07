internal class Program
{
    private static void Main(string[] args)
    {

        Car myCar = new Car();
        myCar.Model = "Odsmobile";
        myCar.Make = "Cutlas Supreme";
        myCar.Year = 1986;
        myCar.Color = "Silver";

        Console.WriteLine($"{myCar.Model}  {myCar.Make}  {myCar.Color}  {myCar.Year}");

        Console.WriteLine($"{Determine(myCar):C}");

        Console.WriteLine($"Determince car from car method {myCar.DetermineMarketValue():C}");

        Console.ReadLine();

    }

    private static decimal Determine(Car car)
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

    public decimal DetermineMarketValue()
    {
        decimal carValue;

        if (Year > 2000)
        {
            carValue = 10000;
        }
        else
        {
            carValue = 2000;
        }

        return carValue;
    }


}