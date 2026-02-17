using System.ComponentModel.DataAnnotations;

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
        Console.WriteLine("Choose an option: ");
        Console.WriteLine("1) Option 1");
        Console.WriteLine("2) Option 2");
        Console.WriteLine("3) Exit");

        string userInput = Console.ReadLine();

        if(userInput == "1")
        {
            PrintNumbers();
            return true;
        }
        else if (userInput == "2")
        {
            GuessingGame();
            return true;
        }

        else if (userInput == "3")
        {
            Console.WriteLine("Exit");               
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
        Console.WriteLine("Printing numbers");       

        int result = GetUserInput();
       

            for (int i = 1; i < result; i++)
            {
                Console.Write(i + "-");              
               
            }
            Console.Write(result);
            Console.ReadLine();
        
    }

    private static void GuessingGame()
    {
        Console.Clear();
        Console.WriteLine("Guessing game  ,enter a number between 1 - 10 ");    

       int randomNumber = GetRandomNumber();

        int userInput = GetUserInput();

        int counter = 1;

        while (userInput != randomNumber)
        {
            Console.WriteLine("Wrong number ,try again: ");
            userInput = GetUserInput();
            counter++;
        }
        if (userInput == randomNumber)
        {
            Console.WriteLine($"You found our number in only {counter} guesses");
        }
        Console.ReadLine();
    }

    private static int GetUserInput()
    {
        Console.Clear();
        Console.Write("Type a number: ");
        string input = Console.ReadLine();
        int result;

        if (int.TryParse(input, out result))
        {
            return result;
        }
        else
        {
            Console.WriteLine($"You did not type a number , your result is: {result}");
            return 0;
        }
    }

    private static int GetRandomNumber()
    {
        Random random = new Random();

        int randomNumber = random.Next(1, 11);

        return randomNumber;
    }




}