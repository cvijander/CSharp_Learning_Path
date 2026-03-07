internal class Program
{
    private static void Main(string[] args)
    {
        Car myCar = new Car();

        myCar.Make = "Oldsmobile";
        myCar.Model = "Cutlas Supreme";
        myCar.Year = 1986;
        myCar.Color = "Silver";

        Console.WriteLine($" {myCar.Make}  {myCar.Model}  {myCar.Year}  {myCar.Color}");

        decimal value = Determine(myCar);

        Console.WriteLine(value);

        Console.WriteLine($" This is method from my class , and my car is valued at  {myCar.DetermineMarketValue():C}");

        Console.ReadLine();

    }

    private static decimal Determine(Car car)
    {
        decimal carValue = 100;

        return carValue;
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

            if (Year > 1990)
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
}