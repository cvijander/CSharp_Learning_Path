internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("The Name Game");

        Console.Write("What's your name? ");
        string firstName = Console.ReadLine();

        Console.Write("What's your last name? ");
        string lastName = Console.ReadLine();

        Console.Write("In what city were you born? ");
        string city = Console.ReadLine();

        Console.WriteLine("Results: ");

        /*
        string reversedFirstName =  ReverseString(firstName);
        string reversedLastName = ReverseString(lastName);
        string reversedCity =  ReverseString(city);

        Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedCity));
        */

        DisplayResults(ReverseString(firstName), ReverseString(lastName), ReverseString(city));
        Console.WriteLine();
        DisplayResults(ReverseString(firstName) + " " + ReverseString(lastName) + " " + ReverseString(city));

       
    }

    /*
    private static void ReverseString(string message)
    {        
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);

        foreach (char item in messageArray)
        {
             Console.Write(item);
        }
        Console.Write(" ");
    }
    */

    private static string ReverseString(string message)
    {
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        return String.Concat(messageArray);
    }

    private static void DisplayResults(string reversedFirstName, string reversedLastName, string reversedCity)
    {
        Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedCity));
    }

    private static void DisplayResults(string message)
    {
        Console.Write(message);
    }
}