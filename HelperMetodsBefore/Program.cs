// See https://aka.ms/new-console-template for more information

Console.WriteLine("The name game");

Console.Write("What's your first name? ");
string firstName = Console.ReadLine();

Console.Write("What's your last name? ");
string lastName = Console.ReadLine();

Console.Write("In what city were you born? ");
string city = Console.ReadLine();

char [] firstNameArray = firstName.ToCharArray();
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

Console.WriteLine("Result: " + result);
