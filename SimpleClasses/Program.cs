internal class Program
{
    private static void Main(string[] args)
    {
        /* string car1Make;
         string car1Model;
         int car1Year;
         string car1Color;
        */

        Car myCar = new Car();
        myCar.Make = "Oldsmobil";
        myCar.Model = "Cutlas Supreme";
        myCar.Year = 1986;
        myCar.Color = "Silver";

        


        Console.WriteLine($" {myCar.Model}  {myCar.Make} {myCar.Year} {myCar.Color}");

        decimal value = DetermineMarketValue(myCar);

        Console.WriteLine($"{value:C}");

        Console.WriteLine(myCar.Determine());

        Console.ReadLine();



    }

    private static decimal DetermineMarketValue(Car car )
    {
        decimal carValue = 100.0M;

        return carValue;

        
    }

    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }   

        public string Color { get; set; }


        public decimal Determine()
        {
            decimal carValue;

            if (Year > 1990 )
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

    // https://www.youtube.com/watch?v=0QUgvfuKvWU

    // obeveno jos jednom ili 2 puta ! 
}