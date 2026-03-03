using System.Runtime.CompilerServices;

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
        Console.WriteLine("1) Print numbers");
        Console.WriteLine("2) Guessing game");
        Console.WriteLine("3) Exit");
        string result = Console.ReadLine();

        if (result == "1")
        {
            PrintNumbers();
            return true;
        }
        else if (result == "2")
        {
            GuessingNumber();
            return true;
        }
        else if (result == "3")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private static void PrintNumbers()
    {
        Console.Clear();
        Console.WriteLine("Print numbers");
        Console.Write("Type a number:");
        int counter = 1;
        int output ;
        string input = Console.ReadLine().Trim();
        if (int.TryParse(input, out output))
        {
            while (counter < output)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.Write(output);

            
        }
        else
        {
            Console.WriteLine("Error");
        }
        
        Console.ReadLine();
    }

    private static void GuessingNumber()
    {
        Console.Clear();
        Console.WriteLine("Guess a number");

        Random myRandom = new Random();
        int randomNumber = myRandom.Next(1, 11);

        int guesses = 0;
        bool incorrect = true;

        do
        {
            Console.WriteLine("Guess a number betwwen 1 and 10: ");
            string userInput = Console.ReadLine().Trim();
            int output;
            guesses++; 


            if (int.TryParse(userInput, out output))
            {
                if(output == randomNumber)
                {
                    incorrect = false;

                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }

           


        } while (incorrect);
        Console.WriteLine($"Correct, it took you {guesses} guesses.");
        Console.ReadLine();
    }
}