// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bob's big giveaway");
Console.Write("Choose a door: 1, 2 or 3 : ");
string userValue = Console.ReadLine();


// conditional operator
string message = (userValue == "1") ? "boat" : "strand of ligth";


Console.Write("You won a ");
Console.Write(message);
Console.Write(".");

Console.WriteLine("You won a  {0} .", message);
Console.WriteLine($"You won a {message}." );
Console.ReadLine();

