internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("The Name Game");

        Console.Write("What's your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What's your last name? ");
        string lastName = Console.ReadLine();

        Console.Write("In what city were you born? ");
        string city = Console.ReadLine();

        /*
        char[] firstNameArray = firstName.ToCharArray();
        Array.Reverse(firstNameArray);

        char[] lastNameArray = lastName.ToCharArray();
        Array.Reverse(lastNameArray);

        char[] cityArray = city.ToCharArray();
        Array.Reverse(cityArray);

        string result = "";

        foreach (char item in firstNameArray)
        {
            result += item;
        }

        result = result + " ";

        foreach (char item in lastNameArray)
        {
            result += item;

        }

        result = result + " ";

        foreach (char item in cityArray)
        {
            result += item;
        }

        Console.WriteLine("Results: " + result);
        */
        Console.WriteLine("Results: ");
        ReverseString(firstName);
        ReverseString(lastName);
        ReverseString(city);
    }

    private static void ReverseString(string message)
    {
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        foreach (char item in messageArray)
        {
            Console.Write(item);
        }
        Console.Write(" ");

        // https://www.youtube.com/watch?v=0QUgvfuKvWU
    }
}