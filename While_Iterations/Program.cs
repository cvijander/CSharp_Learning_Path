internal class Program
{
    private static void Main(string[] args)
    {
        bool displayMenu = true;

        while (displayMenu == true)
        {
            displayMenu = MainMenu();
        }
        
    }

    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Print numbers ");
        Console.WriteLine("2) Guessing game ");
        Console.WriteLine("3) Exit ");

        string result = Console.ReadLine();

        if (result == "1")
        {
            Console.WriteLine("You choose a number option 1");
            PrintNumbers();
            return true;
        }
        else if (result == "2")
        {
            Console.WriteLine("You choose a number option 2");
            GuessingGame();
            return true;
        }
        else if (result == "3")
        {
            Console.WriteLine("You choose EXIT");
            return false;
        }
        else
        {
            Console.WriteLine("Error");
            return true;
        }
    }

    private static void PrintNumbers()
    {
        Console.Clear();
        Console.WriteLine("Print numbers");
        Console.Write("Type a number: ");
        int result = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter < result + 1)
        {
            Console.Write(counter);
            Console.Write("-");
            counter++;
        }
        Console.ReadLine();
    }

    private static void GuessingGame()
    {
        Console.Clear();
        Console.WriteLine("Guessing game");

        Random myRandom = new Random();
        int randomNumber = myRandom.Next(1, 11);

        int guesses = 0;

        bool incorrect = true;

        do
        {
            Console.WriteLine("Guess a number between 1 and 10: ");
            string result = Console.ReadLine();
            guesses++;

            if (result == randomNumber.ToString())
            {
                incorrect = false;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        } while (incorrect == true);

        Console.WriteLine($"Correct it took you {guesses} guesses. ");

        Console.ReadLine();
    }
}